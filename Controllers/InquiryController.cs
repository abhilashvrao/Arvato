using Microsoft.AspNetCore.Mvc;
using CustomerSupport.Services;
using CustomerSupport.Models;

namespace CustomerSupport.Controllers;

[ApiController]
[Route("[controller]")]
public class InquiryController : ControllerBase
{
    private readonly DataService _dataService;
    public InquiryController(DataService dataService)
    {
        _dataService = dataService;
    }

    [HttpGet]
    public IEnumerable<Inquiry> Get()
    {
        return _dataService.GetInquiries();
    }

    [HttpPost]
    public IEnumerable<Inquiry> CreateInquiry(Inquiry inquiry)
    {
        _dataService.Inquiries.Add(inquiry);
        return _dataService.Inquiries;
    }
}