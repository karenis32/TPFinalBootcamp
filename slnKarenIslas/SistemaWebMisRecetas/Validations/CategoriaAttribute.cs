﻿using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CategoriaAttribute: ValidationAttribute
    {
        public CategoriaAttribute()
        {
            ErrorMessage = "La categoria solo puede ser DESAYUNO";
        }
        public override bool IsValid(object value)
        {
            string categoria = (string)value;
            if (categoria != null && categoria.ToUpper() == "DESAYUNO")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
