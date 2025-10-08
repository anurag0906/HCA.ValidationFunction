namespace HCA.AS.DomainModels.Interfaces
{
    public interface ICustomerOutputValidationResponse
    {
        string customerId { get; set; }
        ICustomerValidationResult emailValidation { get; set; }
        ICustomerValidationResult phoneValidation { get; set; }
        string status { get; set; }
    }
}
