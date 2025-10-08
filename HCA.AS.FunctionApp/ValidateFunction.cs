using HCA.AS.BusinessLogic;
using HCA.AS.BusinessLogic.Interfaces;
using HCA.AS.DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace HCA.AS.FunctionApp;

public class ValidateFunction
{
    private readonly ILogger<ValidateFunction> _logger;
    private ICustomerDataValidation _customerDataValidation;

    public ValidateFunction(ILogger<ValidateFunction> logger, ICustomerDataValidation customerDataValidation)
    {
        _logger = logger;
        _customerDataValidation = customerDataValidation;
    }

    [Function("validate")]
    public async Task<HttpResponseData> RunAsync([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        var input = await JsonSerializer.DeserializeAsync<CustomerInputDataModel>(req.Body);

        var result = _customerDataValidation.ValidateCustomerData(input);

        var res = req.CreateResponse(System.Net.HttpStatusCode.OK);
        await res.WriteAsJsonAsync(result);

        return res;
    }
}