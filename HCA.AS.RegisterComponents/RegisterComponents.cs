using HCA.AS.BusinessLogic;
using HCA.AS.BusinessLogic.Interfaces;
using HCA.AS.BusinessLogic.Validator;
using Microsoft.Extensions.DependencyInjection;

namespace HCA.AS.RegisterComponents;

public static class RegisterComponents
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        // Register Business Logic
        //services.AddScoped<ICustomerDataValidation, CustomerDataValidation>();
        services.AddTransient< ICustomerDataValidation , CustomerDataValidation >();
        services.AddTransient< IEmailValidator , EmailValidator >();
        services.AddTransient< IPhoneNumberValidator , PhoneNumberValidator >();
        // Register Repositories

        return services;
    }

}   

