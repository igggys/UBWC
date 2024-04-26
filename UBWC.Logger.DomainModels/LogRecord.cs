using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBWC.Logger.DomainModels
{
    public class LogRecord
    {
        public Guid? RequestId { get; set; }
        public required string ApplicationName { get; set; }
        public DateTime Start { get; set; }
        public required string Url { get; set; }
        public required string Method { get; set; }
        public required string Arguments { get; set; }
        public required List<Message> Messages { get; set; }
        public required string Result { get; set; }
        public required string Exception { get; set; }
        public DateTime? End { get; set; }
    }

    public class Message
    {
        public DateTime MessageTimePoint { get; set; }
        public required string ClassName { get; set; }
        public required string MethodName { get; set; }
        public required string Text { get; set; }
    }
}
