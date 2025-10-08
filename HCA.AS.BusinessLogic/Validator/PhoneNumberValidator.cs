using HCA.AS.BusinessLogic.Interfaces;
using HCA.AS.DomainModels;
using HCA.AS.DomainModels.Interfaces;
using System.Text.RegularExpressions;

namespace HCA.AS.BusinessLogic.Validator;

//TODO: Validation class can be moved to a seperate project and injected via DI

public class PhoneNumberValidator : IPhoneNumberValidator
{
    public ICustomerValidationResult ValidatePhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            return new CustomerValidationResult(false, "Phone number cannot be empty.");
        }

        string pattern = @"^(\(\d{3}\)\s?|\d{3}-)\d{3}-\d{4}$";
        bool isMatch = Regex.IsMatch(phoneNumber, pattern);

        if (isMatch)
        {
            return new CustomerValidationResult(true, "Phone number is valid.");
        }
        else
        {
            return new CustomerValidationResult(false, "Invalid phone number format. Expected formats: 123-456-7890.");
        }
    }
}
