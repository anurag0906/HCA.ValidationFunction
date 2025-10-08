namespace HCA.AS.DomainModels.Interfaces
{
    public interface ICustomerInputDataModel
    {
        string customerId { get; set; }
        string email { get; set; }
        string phoneNumber { get; set; }
    }
}
