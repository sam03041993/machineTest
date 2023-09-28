using DotNetMachineTest.Models.context;
using System.Linq;

namespace DotNetMachineTest.Services
{
    public class UnitConversionService : IUnitConversionService
    {
        private readonly MachineTestContext _context;
        public UnitConversionService(MachineTestContext context)
        {
            _context = context;
        }
        public double CelsiusToFahrenheit(double value, string unitFrom)
        {
            var rate = (from dbUnit in _context.Unit
                        join conversionRate in _context.ConversionRate on dbUnit.Id equals conversionRate.FromUnitId
                        where dbUnit.Name.ToLower() == unitFrom
                        select conversionRate.Rate).FirstOrDefault();

            return (value * rate) + 32;
        }

        public double FahrenheitToCelsius(double value, string unitFrom)
        {
            var rate = (from dbUnit in _context.Unit
                        join conversionRate in _context.ConversionRate on dbUnit.Id equals conversionRate.FromUnitId
                        where dbUnit.Name.ToLower() == unitFrom
                        select conversionRate.Rate).FirstOrDefault();

            return (value - 32) * rate;
        }

        public double MeterToFeet(double value, string unitFrom)
        {
            var rate = (from dbUnit in _context.Unit
                        join conversionRate in _context.ConversionRate on dbUnit.Id equals conversionRate.FromUnitId
                        where dbUnit.Name.ToLower() == unitFrom
                        select conversionRate.Rate).FirstOrDefault();

            return value * rate;
        }

        public double FeetToMeter(double value, string unitFrom)
        {
            var rate = (from dbUnit in _context.Unit
                        join conversionRate in _context.ConversionRate on dbUnit.Id equals conversionRate.FromUnitId
                        where dbUnit.Name.ToLower() == unitFrom
                        select conversionRate.Rate).FirstOrDefault();

            return value * rate;
        }
    }
}
