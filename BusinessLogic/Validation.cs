using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Validation
    {
        public async Task<bool> ValidateUserInput(string InputType, object input)
        {
            return await Task.Run(() => ValidateInput(InputType, input));
        }

        bool ValidateInput(string InputType, object input)
        {
            switch (InputType.ToLower())
            {
                case "address":
                    return TryValidateAsAddress(input.ToString());
                case "cpr":
                    return TryValidateAsCPR(input.ToString());
                case "email":
                    return TryValidateAsEmail(input.ToString());
                case "name":
                    return TryValidateAsName(input.ToString());
                case "phone":
                    return TryValidateAsPhone(input.ToString());
                case "int":
                    return TryValidateAsInt(input.ToString());
                case "double":
                    return TryValidateAsDouble(input.ToString());
                default:
                    return false;
            }
        }
        bool TryValidateAsInt(string input)
        {
                int intInput = Convert.ToInt32(input.ToString());
                if (intInput > 0)
                {
                    return true;
                }
            return false;
        }
        bool TryValidateAsDouble(string input)
        {
            {
                    double doubleinput = Convert.ToDouble(input.ToString());
                    if (doubleinput > 0)
                    {
                        return true;
                    }
                    return false;
            }
        }
        bool TryValidateAsEmail(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                string regexStatement = @"^[a-zA-Z0-9æøåÆØÅ]+@[a-zA-Z0-9.-æøåÆØÅ]+\.[a-zA-Z]{2,}$";
                if (RegexCheckXAgainstYPattern(input, regexStatement))
                {
                    return true;
                }
            }
            return false;
        }
        bool TryValidateAsCPR(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                string regexStatement = @"^\d{6}-\d{4}$";
                if (RegexCheckXAgainstYPattern(input, regexStatement))
                {
                    return true;
                }
            }
            return false;
        }
        bool TryValidateAsPhone(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                string regexStatement = @"^\d{8}$";
                if (RegexCheckXAgainstYPattern(input, regexStatement))
                {
                    return true;
                }
            }
            return false;
        }
        bool TryValidateAsName(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                string regexStatement = @"^[a-zA-ZæøåÆØÅ]{2,}$";
                if (RegexCheckXAgainstYPattern(input, regexStatement))
                {
                    return true;
                }
            }
            return false;
        }
        bool TryValidateAsAddress(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                string regexStatement = @"^(?=.*[a-zA-ZæøåÆØÅ])(?=.*\d)[a-zA-ZæøåÆØÅ\d\s]+$";
                if (RegexCheckXAgainstYPattern(input, regexStatement))
                {
                    return true;
                }
            }
            return false;
        }
        bool RegexCheckXAgainstYPattern(string input, string pattern)
        {
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(input);
            if (isValid)
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
