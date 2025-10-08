using HCA.AS.DomainModels;
using HCA.AS.DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HCA.AS.BusinessLogic.Validator; 

//TODO: Validation class can be moved to a seperate project and injected via DI
public class EmailValidator
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
