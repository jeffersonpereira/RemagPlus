using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RemagPlus.Classes
{
    public static class ValidatedData
    {
        public static List<string> IsValid(object entity)
        {
            ValidationContext context=new ValidationContext(entity,null,null);
            IList<ValidationResult> error=new List<ValidationResult>();
            List<string> mensagens=new List<string>();
            if(Validator.TryValidateObject(entity,context,error,true))
            {
                foreach(ValidationResult e in error)
                {
                    mensagens.Add(e.ErrorMessage);
                }
            }
            return mensagens;
        }
    }
}
