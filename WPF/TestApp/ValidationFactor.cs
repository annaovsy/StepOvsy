using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TestApp
{
    public class ValidationFactor : ValidationRule
    {
        public float Min { get; set; }
        public float Max { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                string str = (string)value;
                if (!string.IsNullOrWhiteSpace(str))
                    MainWindow.factorC.FactorTest = float.Parse(str, NumberStyles.Float);
                else
                    MainWindow.factorC.FactorTest = 0;
            }
            catch
            {
                return new ValidationResult(false, "Введен недопустимый символ!");
            }

            if (MainWindow.factorC.FactorTest >= Min && MainWindow.factorC.FactorTest <= Max)
            {
                return new ValidationResult(true, null);
            }
            else
                return new ValidationResult(false, $"Значение должно быть от {Min} до {Max}");
        }
    }
}
