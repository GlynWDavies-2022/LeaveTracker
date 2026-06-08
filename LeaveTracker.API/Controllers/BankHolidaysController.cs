using LeaveTracker.Application.Interfaces;
using LeaveTracker.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LeaveTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BankHolidaysController : ControllerBase
{
    private readonly IBankHolidayRepository _bankHolidayRepository;

    private readonly IService<BankHoliday> _bankHolidayService;

    public BankHolidaysController(IService<BankHoliday> bankHolidayService, IBankHolidayRepository bankHolidayRepository)
    {
        _bankHolidayService = bankHolidayService;

        _bankHolidayRepository = bankHolidayRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<BankHoliday>> GetAllBankHolidaysAsync()
    {
        return await _bankHolidayRepository.GetAllAsync();
    }

    [HttpGet("{year}")]
    public async Task<IEnumerable<BankHoliday>> GetAllBankHolidaysByYearAsync(int year)
    {
        return await _bankHolidayRepository.GetAllByYearAsync(year);
    }
}
