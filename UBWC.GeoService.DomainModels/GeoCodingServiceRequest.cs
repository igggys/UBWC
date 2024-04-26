using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UBWC.GeoService.PresentationModels
{
    public class GeoCodingServiceRequest
    {
        public GeoCodingResult[]? GeoCodingResult { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string? Message { get; set; }

        
    }
}
