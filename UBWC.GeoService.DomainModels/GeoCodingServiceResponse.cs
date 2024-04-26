using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBWC.GeoService.PresentationModels
{
    public class GeoCodingServiceResponse
    {
        public required string Address { get; set; }
        public required string Culture { get; set; }
    }
}
