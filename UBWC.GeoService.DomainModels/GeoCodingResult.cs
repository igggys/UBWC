using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBWC.GeoService.PresentationModels
{
    public class GeoCodingResult
    {
        public string? DisplayAddress { get; set; }
        public GeoLocation? GeoLocation { get; set; }
    }
}
