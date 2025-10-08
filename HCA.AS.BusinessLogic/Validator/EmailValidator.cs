using HCA.AS.BusinessLogic.Interfaces;
using HCA.AS.DomainModels;
using HCA.AS.DomainModels.Interfaces;
using System.Text.RegularExpressions;

namespace HCA.AS.BusinessLogic.Validator;


//TODO: Validation class can be moved to a seperate project and injected via DI
public class EmailValidator : IEmailValidator
{
    public ICustomerValidationResult ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return new CustomerValidationResult(false, "Email cannot be empty.");
        }

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        bool isMatch = Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);

        if (isMatch)
        {
            return new CustomerValidationResult(true, "Email is valid");
        }
        else
        {
            return new CustomerValidationResult(false, "Invalid email format.");
        }
    }
}
