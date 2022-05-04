using CustomerSupport.Models;
namespace CustomerSupport.Services;

public class DataService
{
    public DataService()
    {
        Inquiries = new List<Inquiry>();
    }
    public List<Inquiry> Inquiries { get; set; }

    public List<Inquiry> GetInquiries() => Inquiries;
}