using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class EdadAttribute: ValidationAttribute
    {
        public EdadAttribute()
        {
            ErrorMessage = "Debe ser mayor de edad.";
        }
        public override bool IsValid(object value)
        {
            int edad = (int)value;
            if (edad < 18)
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
