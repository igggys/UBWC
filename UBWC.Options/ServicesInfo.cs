using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static UBWC.CryptoLib.SymmetricEncryption;

namespace UBWC.Options
{
    public class ServicesInfo
    {
        public required string ServiceName { get; set; }
        public required Guid ServiceId { get; set; }
        public required List<ServiceCriptoInfo> ServiceCriptoInfo { get; set; }
    }

    public class ServiceCriptoInfo
    {
        public required string ServiceName { get; set; }
        public required Guid ServiceId { get; set; }
        public required SymmetricKey SymmetricKey { get; set; }
    }
}
