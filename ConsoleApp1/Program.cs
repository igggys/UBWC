// See https://aka.ms/new-console-template for more information
using UBWC.PresentationModels;
using System.Text;
using FluentValidation;

Console.WriteLine("Start!");

ServiceRequestModel serviceRequestModel = new ServiceRequestModel { ServiceId = Guid.Empty, RequestData = "" };
ServiceRequestModelValidator validationRules = new ServiceRequestModelValidator();

try
{
    validationRules.Validate(serviceRequestModel, options => options.ThrowOnFailures());
    Console.WriteLine("IsValid is true");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadLine();
