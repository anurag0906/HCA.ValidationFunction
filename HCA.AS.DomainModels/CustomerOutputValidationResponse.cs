using HCA.AS.DomainModels.Interfaces;

namespace HCA.AS.DomainModels
{
    public class CustomerOutputValidationResponse : ICustomerOutputValidationResponse
    {
        public string customerId { get; set; }
        public ICustomerValidationResult emailValidation { get; set; }
        public ICustomerValidationResult phoneValidation { get; set; }
        public string status { get; set; }
    }
}
