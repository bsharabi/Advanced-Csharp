using System.ComponentModel.DataAnnotations;

namespace ProductServer.Models
{
    public class ZugiValidatorAttribute : ValidationAttribute
    {
        public ZugiValidatorAttribute() : base("my custom error message"){ }

        public override bool IsValid(object value)
        {
            double number = (double)value;
            return number % 2 == 0;
        }


    }
}