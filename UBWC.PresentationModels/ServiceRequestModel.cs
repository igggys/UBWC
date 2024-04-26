namespace UBWC.PresentationModels
{
    public class ServiceRequestModel
    {
        public Guid ServiceId { get; set; }
        public required string RequestData { get; set; }
    }

    public class RequestData
    {
        public Guid LogId { get; set; }
    }
}
