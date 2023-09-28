using DotNetMachineTest.Models.context;
using DotNetMachineTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DotNetMachineTest.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitConversionController : ControllerBase
    {
        private readonly IUnitConversionService unitConversionService;
        private readonly MachineTestContext context;

        public UnitConversionController(IUnitConversionService unitConversionService, MachineTestContext context)
        {
            this.unitConversionService = unitConversionService;
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get(double value, string unitFrom, string unitTo)
        {
            var isValidUnit = context.Unit.Any(x => x.Name.ToLower() == unitFrom);
            if (!isValidUnit)
                return BadRequest();

            double response = 0;
            switch (unitFrom.ToLower())
            {
                case "celsius":
                    response = unitConversionService.CelsiusToFahrenheit(value, unitFrom);
                    break;
                case "fahrenheit":
                    response = unitConversionService.FahrenheitToCelsius(value, unitFrom);
                    break;
                case "meter":
                    response = unitConversionService.MeterToFeet(value, unitFrom);
                    break;
                case "feet":
                    response = unitConversionService.FeetToMeter(value, unitFrom);
                    break;
                default:
                    break;
            }
            return Ok($"Converted value from {unitFrom} to {unitTo} is {response}");
        }
    }
}
