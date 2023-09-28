namespace DotNetMachineTest.Services
{
    public interface IUnitConversionService
    {
        double CelsiusToFahrenheit(double value, string unitFrom);

        double FahrenheitToCelsius(double value, string unitFrom);

        double MeterToFeet(double value, string unitFrom);

        double FeetToMeter(double value, string unitFrom);
    }
}