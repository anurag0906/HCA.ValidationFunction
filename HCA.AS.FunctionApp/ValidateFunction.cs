using HCA.AS.BusinessLogic;
using HCA.AS.DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace HCA.AS.FunctionApp;

public class ValidateFunction
{
    private readonly ILogger<ValidateFunction> _logger;

    public ValidateFunction(ILogger<ValidateFunction> logger)
    {
        _logger = logger;
    }

    [Function("validate")]
    public async Task<HttpResponseData> RunAsync([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        var input = await JsonSerializer.DeserializeAsync<CustomerInputDataModel>(req.Body);

        var result = new CustomerDataValidation().ValidateCustomerData(input);

        var res = req.CreateResponse(System.Net.HttpStatusCode.OK);
        await res.WriteAsJsonAsync(result);

        return res;
    }
}