using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBWC.PresentationModels
{
    public class ServiceRequestModelValidator : AbstractValidator<ServiceRequestModel>
    {
        public ServiceRequestModelValidator()
        {
            this.RuleFor(ServiceRequestModel => ServiceRequestModel.ServiceId).NotEmpty().WithName("Service identity");
            this.RuleFor(ServiceRequestModel => ServiceRequestModel.Stam).Must(stam => (stam % 2) == 0);
        }

        public static bool IsValidIsraeliID(string id)
        {
            id = id.Trim();

            if (id.Length > 9 || id.Length < 5 || !int.TryParse(id, out _))
                return false;

            id = id.Length < 9 ? id.PadLeft(9, '0') : id;

            return id.Select(c => int.Parse(c.ToString())).Select((digit, i) => digit * ((i % 2) + 1)).Sum(step => step > 9 ? step - 9 : step) % 10 == 0;
        }
    }

    
}
