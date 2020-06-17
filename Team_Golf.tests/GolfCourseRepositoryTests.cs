using System;
using Xunit;
using Team_Golf.Models;
using System.Linq;
using Team_Golf.Repositories;

namespace Team_Golf.tests
{
    public class GolfCourseRepositoryTests : IDisposable
    {
        private GolfCourseContext db;
        private GolfCourseRepository underTest;

        public GolfCourseRepositoryTests()
        {
            db = new GolfCourseContext();
            db.Database.BeginTransaction();
            underTest = new GolfCourseRepository(db);
        }
        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }
        [Fact]
        public void Count_Starts_At_Zero()
        {
            var count = underTest.Count();
            Assert.Equal(0, count);
        }
        [Fact]
        public void Create_Increases_Count()
        {
            underTest.Create(new GolfCourse() { Name = "name" });
            var count = underTest.Count();
            Assert.Equal(1, count);
        }


    }
}
