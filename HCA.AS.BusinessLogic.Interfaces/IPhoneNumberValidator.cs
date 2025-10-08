using HCA.AS.DomainModels.Interfaces;

namespace HCA.AS.BusinessLogic.Interfaces;

public interface IPhoneNumberValidator
{
    ICustomerValidationResult ValidatePhoneNumber(string phoneNumber);
}
