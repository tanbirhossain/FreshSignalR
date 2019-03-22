namespace Web.Client.Models
{
    public interface IErrorViewModel
    {
        string RequestId { get; set; }
        bool ShowRequestId { get; }
    }
}