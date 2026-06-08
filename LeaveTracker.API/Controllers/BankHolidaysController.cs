using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LeaveTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BankHolidaysController : ControllerBase
{
    private readonly IRepository<BankHoliday> _bankHolidayRepository;

    public BankHolidaysController(IRepository<BankHoliday> bankHolidayRepository)
    {
        _bankHolidayRepository = bankHolidayRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<BankHoliday>> GetAllBankHolidaysAsync()
    {
        return await _bankHolidayRepository.GetAllAsync();
    }
}
