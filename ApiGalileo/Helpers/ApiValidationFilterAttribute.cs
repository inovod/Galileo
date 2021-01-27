using ApiGalileo.Api.Log;
using ApiGalileo.Features.Base;
using Business.Model.common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiGalileo.Helpers
{
    public class ApiValidationFilterAttribute : IActionFilter
    {
        private readonly ILog _looger;
        public ApiValidationFilterAttribute(ILog looger)
        {
            _looger = looger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result != null && context.Result.GetType() == typeof(BadRequestObjectResult))
            {
                var badRequestObjectResult = (BadRequestObjectResult)context.Result;
                try
                {
                    var validationModel = (ValidationModel)badRequestObjectResult.Value;
                    var validationResults = validationModel.GetValidationsErrors();
                    var errorDetails = new ErrorDetail(validationResults);
                    ErrorResponse _response = new ErrorResponse();
                    _response.message = errorDetails.Error;
                    _response.statusCode = "400";
                    badRequestObjectResult.Value = _response;
                }
                catch { }

                _looger.Error("BadRequestObjectResult");
            }
            if (context.Result != null && context.Result.GetType() == typeof(ApiResponseNoOk))
            {
                _looger.Error("ApiResponseNoOk");
            }
            if (context.Result != null && context.Result.GetType() == typeof(NotFoundObjectResult))
            {
                _looger.Error("NotFoundObjectResult");
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Method != "GET")
            {
                context.HttpContext.Request.Body.Position = 0;

                var reader = new StreamReader(context.HttpContext.Request.Body);
                var requestBody = JsonConvert.SerializeObject(reader.ReadToEnd(), Formatting.Indented);

                context.HttpContext.Items.Add("Request", requestBody);
            }
        }
    }
}
