using ExploringActions;
using ExploringActions.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
using Moq;

namespace TestExploringActions
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void Test_WeatherForecastControllerTest()
        {
            //arrange
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);

            //act
            var result = controller.Get();

            //result
            Assert.NotNull(result);
            Assert.IsType<WeatherForecast[]>(result);
        }
    }
}