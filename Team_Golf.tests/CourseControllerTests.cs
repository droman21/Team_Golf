using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Team_Golf.Controllers;
using Team_Golf.Models;
using Xunit;

namespace Team_Golf.tests
{
    public class CourseControllerTests
    {
        CourseController underTest;
        //public CourseControllerTests()
        //{
        //    underTest = new CourseController();
        //}
        [Fact]
        public void Index_Returns_View()
        {

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_Model_to_View()
        {
            var result = underTest.Index();
            Assert.IsType<List<GolfCourse>>(result.Model);
        }
    }


}

