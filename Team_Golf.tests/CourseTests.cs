using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Team_Golf.Controllers;
using System.Net.WebSockets;

namespace Team_Golf.tests
{
    public class CourseTests
    {
        [Fact]
        public void Index_Returns_View()
        {
            var underTest = new CourseController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
