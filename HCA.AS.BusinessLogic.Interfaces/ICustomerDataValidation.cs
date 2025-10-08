using HCA.AS.DomainModels.Interfaces;

namespace HCA.AS.BusinessLogic.Interfaces;

public interface ICustomerDataValidation
{
    ICustomerOutputValidationResponse ValidateCustomerData(ICustomerInputDataModel customer);
}
