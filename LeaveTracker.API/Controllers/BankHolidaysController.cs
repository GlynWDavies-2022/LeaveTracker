using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LeaveTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BankHolidaysController : ControllerBase
{
    private readonly IBankHolidayService _bankHolidayService;

    public BankHolidaysController(IBankHolidayService bankHolidayService)
    {
        _bankHolidayService = bankHolidayService;
    }

    [HttpGet("{year}")]
    public async Task<ActionResult<IEnumerable<BankHoliday>>> GetBankHolidaysByYear(int year)
    {
        var bankHolidays = await _bankHolidayService.GetAllByYearAsync(year);

        return Ok(bankHolidays);
    }
}
