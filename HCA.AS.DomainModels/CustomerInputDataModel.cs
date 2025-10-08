using HCA.AS.DomainModels.Interfaces;

namespace HCA.AS.DomainModels;

public class CustomerInputDataModel : ICustomerInputDataModel
{
    public string customerId { get; set; }
    public string email { get; set; }
    public string phoneNumber { get; set; }
}
