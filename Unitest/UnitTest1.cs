using UnitTestCase.Controllers;


namespace Unitest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var wfc = new WeatherForecastController();
            var result = wfc.Get();

            Assert.AreEqual(result, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var wfc = new WeatherForecastController();
            var result = wfc.Get();

            Assert.AreEqual(result.First().Date, result.First().Date);
        }
    }
}