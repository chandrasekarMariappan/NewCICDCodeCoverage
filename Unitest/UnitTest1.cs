using Microsoft.Extensions.Logging;
using UnitTestCase.Controllers;


namespace Unitest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ILogger<WeatherForecastController> _logger;
        [TestMethod]
        public void TestMethod1()
        {
            var wfc = new WeatherForecastController(_logger);
            var result = wfc.Get();

            Assert.AreEqual(result, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var wfc = new WeatherForecastController(_logger);
            var result = wfc.GetById(4);

            Assert.AreEqual(result.First().Date, result.First().Date);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var wfc = new WeatherForecastController(_logger);
            var result = wfc.GetById(4);

            Assert.AreEqual(result.First().Summary, result.First().Summary);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var wfc = new WeatherForecastController(_logger);
            var result = wfc.GetById(4);

            Assert.AreEqual(result.First().TemperatureC, result.First().TemperatureC);
        }
    }
}