using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace OperasWebSite.Validations
{
    public class CheckValidYear: ValidationAttribute
    {
        public CheckValidYear() {
            ErrorMessage = "La opera registrada más antigua es en 1598 de Rinuccini";
        }

        public override bool IsValid(object value)
        {
            int year = (int)value;
            if (year < 1598)
            {
                return false;
            }
            else
            { 
                return true;
            }
        }

    }
}