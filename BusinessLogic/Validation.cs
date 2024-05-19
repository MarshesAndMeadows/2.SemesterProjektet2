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
        //async method for running validation asynchronously.
        public async Task<bool> ValidateUserInputAsync(string InputType, object input)
        {
            return await Task.Run(() => ValidateUserInput(InputType, input));
        }


        //Based on which selector string that is input, choose a method that validates appropriately.
        public bool ValidateUserInput(string InputType, object input)
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
                case "sex":
                    return TryValidateAsSex(input.ToString());
                default:
                    return false;
            }
        }

        //various input validators.
        bool TryValidateAsSex(string input)
        {
            return input.ToLower() == "f" || input.ToLower() == "m";
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

        //Some use Regex for pattern matching; pattern here for example checks if the string matches a pattern of; 
        //"any aA-zZ, numbers or æÆøØåÅ" a @ followed by "any of aA-zZ, numbers or æÆøØåÅ" and finally a.followed by "at least two of aA-zZ"
        bool TryValidateAsEmail(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                string regexStatement = @"^[a-zA-Z0-9.æøåÆØÅ]+@[a-zA-Z0-9.æøåÆØÅ]+\.[a-zA-Z]{2,}$";
                if (RegexCheckXAgainstYPattern(input, regexStatement))
                {
                    return true;
                }
            }
            return false;
        }
        //pattern checks for 6 digits followed by - and 4 more digits.
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

        //simple check for 8 digits.
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

        //check for it only containing letters and white spaces, atleast two characters long.
        bool TryValidateAsName(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                string regexStatement = @"^[a-zA-ZæøåÆØÅ\s]{2,}$";
                if (RegexCheckXAgainstYPattern(input, regexStatement))
                {
                    return true;
                }
            }
            return false;
        }

        //string must contain at least one alphabetic character, including æÆøØåÅ.
        //string must contain at least one digit.
        //string can only consist of alphabetics, digits and whitespace.

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

        //receives a string input (what needs to be validated.)
        //receives a pattern, which is also a string.
        //creates a new Regex instance, using the given pattern.
        //IsMatch is used with the pattern on the input.
        //bool is returned based on match with the pattern.
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