using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Team_Golf.Controllers;
using System.Net.WebSockets;
using Team_Golf.Models;

namespace Team_Golf.tests
{
    public class CourseTests
    {
        GolfCourse underTest;

        public CourseTests()
        {
            underTest = new GolfCourse("Dan's Course", 5, "Good course.", "", "Par3");
        }
        [Fact]
        public void CourseConstructor_Sets_Name_On_CourseModel()
        {
            var result = underTest.Name;

            Assert.Equal("Dan's Course", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Id_On_CourseModel()
        {
            var result = underTest.Id;

            Assert.Equal(5, result);
        }
        [Fact]
        public void CourseConstructor_Sets_Description_On_CourseModel()
        {
            var result = underTest.Description;

            Assert.Equal("Good course.", result);
        }
    }
}
