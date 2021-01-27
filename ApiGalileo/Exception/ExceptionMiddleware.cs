using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ApiGalileo.Features.Base;
using Newtonsoft.Json;
using ApiGalileo.Api.Log;
using Business.Model.common;
using Microsoft.AspNetCore.Diagnostics;
using Business.Interfaces;

namespace ApiGalileo.Exception
{
    
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILog _log;
        public ExceptionMiddleware(RequestDelegate next, 
            ILog log)
        {
            _next = next;
            _log = log;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (System.Exception ex)
            {

                var exceptionHandlerPathFeature = httpContext.Features.Get<IExceptionHandlerPathFeature>();
                var cerror = (Business.Logs.CError)ex;
                // var errors = ((Business.Logs.CError)ex).ErrorDetails;
                var errorDetail = new ErrorDetail
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    // Errores = new List<ItemError>()
                };

                errorDetail.IdTransaction = cerror.ErrorDetails.Select(x => x.IdTransaction).First();
                
                foreach (var error in cerror.ErrorDetails)
                {
                    errorDetail.Error += error.Error;
                    // errorDetail.Errores.Add(new ItemError { Codigo = error.IdError.ToString(), Message = error.Error });
                }

                /// await _logTransaction.AddLogTransaction(cerror);

                _log.Error($"Something went wrong: {ex}");
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var json = JsonConvert.SerializeObject(errorDetail);
                await httpContext.Response.WriteAsync(json);
                //httpContext.Response.WriteAsync(errorDetail.ToString());
                // await HandleExceptionAsync(httpContext, ex);
            }

            if (!httpContext.Response.HasStarted)
            {
                httpContext.Response.ContentType = "application/json";

                var response = new ApiResponse(httpContext.Response.StatusCode);

                var json = JsonConvert.SerializeObject(response);

                await httpContext.Response.WriteAsync(json);
            }
        }



        //private async Task HandleExceptionAsync(HttpContext context, System.Exception exception)
        //{
        //    context.Response.ContentType = "application/json";
        //    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        //    var errorDetail = new ErrorDetail
        //    {
        //        StatusCode = (int)HttpStatusCode.InternalServerError,
        //        //Errores = new List<ItemError>()
        //    };
        //    try
        //    {
        //        if (exception.GetType() == typeof(CError))
        //        {
        //            var errors = (CError)exception;
        //            foreach (var ierr in errors.ErrorDetails)
        //            {
        //                errorDetail.Errores.Add(new ItemError { Codigo = ierr.Origen, Message = ierr.Error });
        //            }
        //        }
        //        else
        //        {
        //            errorDetail.Errores.Add(new ItemError { Codigo = "error interno", Message = exception.Message });
        //        }

        //    }
        //    catch (System.Exception) { }

        //    context.Response.ContentType = "application/json";
        //    string jsonString = JsonConvert.SerializeObject(errorDetail);
        //    await context.Response.WriteAsync(jsonString, System.Text.Encoding.UTF8);
        //}

    }
}
