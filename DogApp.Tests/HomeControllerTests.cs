using DogApp.Controlleres;
using DogApp.Models;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace DogApp.Tests
{
    public class HomeControllerTests
    {
        IDogRepository dogRepo;
        HomeController underTest;

        public HomeControllerTests()
        {
            dogRepo = Substitute.For<IDogRepository>();
            underTest = new HomeController(dogRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {           
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Gets_All_Dogs()
        {            
            underTest.Index();
            dogRepo.Received().GetAll();
        }

        [Fact] //controller passes Model into View
        public void Index_Sets_AllDogs_As_Model()
        {
            var expectedModel = new List<Dog>();
            dogRepo.GetAll().Returns(expectedModel);

            var result = underTest.Index();

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Sets_Dog_To_Model()
        {
            var expectedModel = new Dog();
            dogRepo.FindById(1).Returns(expectedModel); 

            var result = underTest.Details(1);

            var model = result.Model;
            Assert.Equal(expectedModel, model);
        }
    }
}
