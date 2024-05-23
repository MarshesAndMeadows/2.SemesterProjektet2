using BusinessLogic;
using BusinessLogic.BusinessLogic;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;

namespace Controller
{
    public class Controllers
    {

        private readonly ClientBL clientBL;
        private readonly Validation validatior;

        public Controllers()
        {
            clientBL = new ClientBL();
            validatior = new Validation();
        }       

        public async Task<bool> CreateClientAsync(UIModels.UiClient client)
        {
            // You can add validation or other logic here if needed
            return await clientBL.CreateAsync(client);
        }

        // Method to validate first name
        public async Task<bool> ValidateFirstNameAsync(string firstName)
        {
            if (!string.IsNullOrEmpty(firstName))
            {
                return await validatior.ValidateUserInputAsync("name", firstName);
            }
            return false; // If field is empty, consider it invalid
        }

        // Method to validate last name
        public async Task<bool> ValidateLastNameAsync(string lastName)
        {
            if (!string.IsNullOrEmpty(lastName))
            {
                return await validatior.ValidateUserInputAsync("name", lastName);
            }
            return false; // If field is empty, consider it invalid
        }

        public async Task<bool> ValidateSexAsync(string sex)
        {
            if (!string.IsNullOrEmpty(sex))
            {
                return await validatior.ValidateUserInputAsync("sex", sex);
            }
            return false; // If field is empty, consider it invalid
        }

        // Method to validate email
        public async Task<bool> ValidateEmailAsync(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                return await validatior.ValidateUserInputAsync("email", email);
            }
            return false; // If field is empty, consider it invalid
        }

        // Method to validate phone
        public async Task<bool> ValidatePhoneAsync(string phone)
        {
            if (!string.IsNullOrEmpty(phone))
            {
                return await validatior.ValidateUserInputAsync("phone", phone);
            }
            return false; // If field is empty, consider it invalid
        }

        // Method to validate address
        public async Task<bool> ValidateAddressAsync(string address)
        {
            if (!string.IsNullOrEmpty(address))
            {
                return await validatior.ValidateUserInputAsync("address", address);
            }
            return false; // If field is empty, consider it invalid
        }
    }
}
