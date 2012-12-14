using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RemagLib
{
    [MetadataType(typeof(remag_usuarioMetadata))]
    public partial class remag_usuario
    {

        string _novaSenha;
        public string Senha
        {
            get { return _novaSenha; }
            set { this.senha = Security.Encrypt(value, true); }
        }
    }


    public class remag_usuarioMetadata
    {
        [Required(ErrorMessage = "Nome não pode ficar em branco.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Login é obrigatório.")]
        public string login { get; set; }
        [Required(ErrorMessage = "Senha é obrigatória.")]
        public string senha { get; set; }

    }


}
