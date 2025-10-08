using HCA.AS.BusinessLogic.Interfaces;
using HCA.AS.BusinessLogic.Validator;
using HCA.AS.DomainModels;
using HCA.AS.DomainModels.Interfaces;

namespace HCA.AS.BusinessLogic;

public class CustomerDataValidation : ICustomerDataValidation
{
    public IEmailValidator _email { get; set; }
    public IPhoneNumberValidator _phone { get; set; }

    public CustomerDataValidation(IPhoneNumberValidator phoneNumberValidator, IEmailValidator emailValidator)
    {
        _phone = phoneNumberValidator;
        _email = emailValidator;
               
    }

    public ICustomerOutputValidationResponse ValidateCustomerData(ICustomerInputDataModel customer)
    {
        var emailResult = _email.ValidateEmail(customer.email);
        var phoneResult = _phone.ValidatePhoneNumber(customer.phoneNumber);
        //TODO: More Validators can be pluged in here, via DI, i.e. more business validation can be EXTENDED here    

        var response = new CustomerOutputValidationResponse()
        {
            customerId = customer.customerId,
            emailValidation = emailResult,
            phoneValidation = phoneResult
        };
        if (emailResult.isValid && phoneResult.isValid)
        {
            response.status = "Success";
        }
        else
        {
            response.status = "Failed";
        }

        return response;

    }
}
