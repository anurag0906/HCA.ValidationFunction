using HCA.AS.DomainModels.Interfaces;

namespace HCA.AS.BusinessLogic.Interfaces;

public interface ICustomerDataValidation
{
  public  ICustomerOutputValidationResponse ValidateCustomerData(ICustomerInputDataModel customer);
}
