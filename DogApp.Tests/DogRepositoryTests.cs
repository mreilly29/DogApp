using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DogApp.Tests
{
    public class DogRepositoryTests
    {
        [Fact]
        public void GetAll_Returns_3_Dogs()
        {
            var underTest = new DogRepository();

            var result = underTest.GetAll();

            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void FindById_Returns_Correct_Dog()
        {
            var underTest = new DogRepository();

            var result = underTest.FindById(1);

            Assert.Equal(1, result.Id);
            Assert.Equal("Moana", result.Name);
        }

    }
}
