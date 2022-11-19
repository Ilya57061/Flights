using Flights.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Flights.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexViewNameEqualIndex()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.Equal("~/Pages/Index.cshtml", result?.ViewName);
        }
        [Fact]
        public void IndexViewResultNotNull()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.NotNull(result);
        }
    }
}
