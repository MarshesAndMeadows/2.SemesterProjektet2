using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IValidationStrategy
    {
        bool Validate(string input);
    }
    public class Validation
    {
        //Dictionary attribute to allow for selection of strategy.
        private readonly Dictionary<string, IValidationStrategy> strategies;
        public Validation()
        {
            //construct dictionary on instantiation.
            strategies = new Dictionary<string, IValidationStrategy>
            {
                { "address", new AddressValidation()},
                { "email", new EmailValidation()},
                { "name", new NameValidation()},
                { "cpr", new CprValidation()},
                { "phone", new PhoneValidation()},
                { "int", new IntValidation()},
                { "double", new DoubleValidation()},
                { "sex", new SexValidation() },

            };
        }
        //runs a selected strategy class asynchronously.
        public async Task<bool> ValidateUserInputAsync(string inputType, string input)
        {
            return await Task.Run(() => ValidateUserInput(inputType, input));
        }

        //matches selector with an entry from the dictionary, returns the connected strategy's validation method using the given input.
        public bool ValidateUserInput(string inputType, string input)
        {
            if (strategies.TryGetValue(inputType.ToLower(), out IValidationStrategy strategy))
            {
                return strategy.Validate(input);
            }
            return false;
        }
    }

    //the strategies and their patterns;
    public class AddressValidation : IValidationStrategy
    {
        public bool Validate(string input)
        {
            //check that input contains at lesat one alphabetic character, contains at least one digit, and is entirely composed of alphabetics, digits and whitespaces.
            string regexStatement = @"^(?=.*[a-zA-ZæøåÆØÅ])(?=.*\d)[a-zA-ZæøåÆØÅ\d\s]+$";
            return Regex.IsMatch(input, regexStatement);
        }
    }
    public class EmailValidation : IValidationStrategy
    {
        public bool Validate(string input)
        {
            string regexStatement = @"^[a-zA-Z0-9.æøåÆØÅ]+@[a-zA-Z0-9.-æøåÆØÅ]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(input, regexStatement);
        }
    }

    public class NameValidation : IValidationStrategy
    {
        public bool Validate(string input)
        {
            string regexStatement = @"^[a-zA-ZæøåÆØÅ\s]{2,}$";
            return Regex.IsMatch((string)input, regexStatement);
        }
    }

    public class SexValidation : IValidationStrategy
    {
        public bool Validate(string input)
        {
            throw new NotImplementedException();
        }
    }

    public class IntValidation : IValidationStrategy
    {
        public bool Validate(string input)
        {
            throw new NotImplementedException();
        }
    }

    public class DoubleValidation : IValidationStrategy
    {
        public bool Validate(string input)
        {
            throw new NotImplementedException();
        }
    }
    public class CprValidation : IValidationStrategy
    {
        public bool Validate(string input)
        {
            throw new NotImplementedException();
        }
    }

    public class PhoneValidation : IValidationStrategy
    {
        public bool Validate(string input)
        {
            throw new NotImplementedException();
        }
    }
}