using HCA.AS.DomainModels.Interfaces;

namespace HCA.AS.BusinessLogic.Interfaces
{
    public interface IEmailValidator
    {
        ICustomerValidationResult ValidateEmail(string email);
    }
}
