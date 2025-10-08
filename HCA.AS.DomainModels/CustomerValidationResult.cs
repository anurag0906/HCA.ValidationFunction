using HCA.AS.DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.AS.DomainModels
{
    public class CustomerValidationResult : ICustomerValidationResult
    {
        public bool isValid { get; set; }
        public string message { get; set; }

        public CustomerValidationResult(bool isValid, string message)
        {
            this.isValid = isValid;
            this.message = message;
        }
    }
}
