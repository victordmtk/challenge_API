using challengeAPI.Holiday;
using Microsoft.AspNetCore.Mvc;

namespace challengeAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HolidayController : ControllerBase
{
    [HttpGet("{date}")]
    public string CheckHoliday(DateTime date)
    {
        List<DateTime> holidaysList = Holiday.Holiday.GetHoliday(date);
        if (Holiday.Holiday.IsHoliday(date))
        {
            return "é um feriado!";
        }
        return "não é feriado";
    }
}
    
