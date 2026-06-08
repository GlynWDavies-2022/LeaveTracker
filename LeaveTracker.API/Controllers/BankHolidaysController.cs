using LeaveTracker.Application.DTO.BankHoliday;
using LeaveTracker.Application.Interfaces;
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

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BankHolidayDTO>>> GetAllAsync()
    {
        var bankHolidays = await _bankHolidayService.GetAllAsync();

        var bankHolidaysDTO = new List<BankHolidayDTO>();

        foreach (var bankHoliday in bankHolidays)
        {
            bankHolidaysDTO.Add(new BankHolidayDTO
            {
                Name = bankHoliday.Name,
                Date = bankHoliday.Date
            });
        }

        return Ok(bankHolidaysDTO);
    }

    [HttpGet("{year}")]
    public async Task<ActionResult<IEnumerable<BankHolidayDTO>>> GetBankHolidaysByYear(int year)
    {
        var bankHolidays = await _bankHolidayService.GetAllByYearAsync(year);

        var bankHolidaysDTO = new List<BankHolidayDTO>();

        foreach (var bankHoliday in bankHolidays)
        {
            bankHolidaysDTO.Add(new BankHolidayDTO
            {
                Name = bankHoliday.Name,
                Date = bankHoliday.Date
            });
        }

        return Ok(bankHolidays);
    }
}
