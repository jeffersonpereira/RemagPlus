using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace RemagLib
{
    public static class Security
    {
   
        public static string Encrypt(string text, bool useHash)
        {
            byte[] keyArray;
            byte[] toEcryptArray = UTF8Encoding.UTF8.GetBytes(text);
            System.Configuration.AppSettingsReader setingReader = new System.Configuration.AppSettingsReader();
            string key = (string)setingReader.GetValue("SecurityKey", typeof(string));
            if (useHash)
            {
                MD5CryptoServiceProvider hashMd5 = new MD5CryptoServiceProvider();
                keyArray = hashMd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashMd5.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }
            TripleDESCryptoServiceProvider crypto = new TripleDESCryptoServiceProvider();
            crypto.Key = keyArray;
            crypto.Mode = CipherMode.ECB;
            crypto.Padding = PaddingMode.PKCS7;
            ICryptoTransform transforme = crypto.CreateEncryptor();
            byte[] result = transforme.TransformFinalBlock(toEcryptArray, 0, toEcryptArray.Length);
            crypto.Clear();
            return Convert.ToBase64String(result, 0, result.Length);

        }

        public static string Decrypt(string cipherString, bool useHashing)
        {
            byte[] keyArray;
            //get the byte code of the string

            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            System.Configuration.AppSettingsReader settingsReader = new System.Configuration.AppSettingsReader();
            //Get your key from config file to open the lock!
            string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));

            if (useHashing)
            {
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
            }
            else
            {
                //if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. 
            //We choose ECB(Electronic code Book)

            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor                
            tdes.Clear();
            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        private static remag_usuario GetUsuario(DataEntities dataContext, string login, string senha)
        {
            return dataContext.remag_usuario.FirstOrDefault(u => u.login.Equals(login) && u.senha.Equals(senha));
        }

        public static bool IsAutenticate(DataEntities dataContext, string login, string senha, out string mensagem)
        {
            senha = Encrypt(senha, true);
            remag_usuario usuario = GetUsuario(dataContext,login, senha);
            if (usuario == null)
            {
                mensagem = "Usuário não foi encontrado ou senha inválida.";
                return false;
            }
            mensagem = "Seja bem vindo(a) "+usuario.nome+"!";
            return true;
        }

     }
}
