namespace HCA.AS.DomainModels.Interfaces;

public interface ICustomerValidationResult
{
    bool isValid { get; set; }
    string message { get; set; }
}
