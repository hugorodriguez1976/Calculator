using CalculatorTest.Controllers;
using CalculatorTest.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace CalculatorTestNunit
{
    [TestClass]
    public class OccupationControllerTest
    {
        private Mock<ICalculatorRepository> _mockCalculatorRepository;
        private CalculatorController controller;

        [SetUp]
        public void Setup()
        {
            _mockCalculatorRepository = new Mock<ICalculatorRepository>();
            _mockCalculatorRepository.Setup(m => m.Sum(It.IsAny<int>() , It.IsAny<int>())).Returns(10);
            _mockCalculatorRepository.Setup(m => m.Sub(It.IsAny<int>(), It.IsAny<int>())).Returns(2);
            _mockCalculatorRepository.Setup(m => m.Multiply(It.IsAny<int>(), It.IsAny<int>())).Returns(24);
            _mockCalculatorRepository.Setup(m => m.Divide(It.IsAny<Double>(), It.IsAny<Double>())).Returns(3);

            controller = new CalculatorController(_mockCalculatorRepository.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
        }

        [Test]
        public void SumTest()
        {
            IHttpActionResult getsumMethodResponse = controller.Sum(6 , 4);
            var contentResult = getsumMethodResponse as OkNegotiatedContentResult<int>;

            // Assert
            NUnit.Framework.Assert.IsNotNull(contentResult, "Result Content cant be null");
            NUnit.Framework.Assert.IsNotNull(contentResult.Content, "Result Content cant be null");
            NUnit.Framework.Assert.AreEqual(10, contentResult.Content, "Result should be 10");
        }


        [Test]
        public void SubTest()
        {
            IHttpActionResult getsubMethodResponse = controller.Sub(6, 4);
            var contentResult = getsubMethodResponse as OkNegotiatedContentResult<int>;

            // Assert
            NUnit.Framework.Assert.IsNotNull(contentResult, "Result Content cant be null");
            NUnit.Framework.Assert.IsNotNull(contentResult.Content, "Result Content cant be null");
            NUnit.Framework.Assert.AreEqual(2, contentResult.Content, "Result should be 2");
        }

        [Test]
        public void MultiplyTest()
        {
            IHttpActionResult getmultiplyMethodResponse = controller.Multiply(6, 4);
            var contentResult = getmultiplyMethodResponse as OkNegotiatedContentResult<int>;

            // Assert
            NUnit.Framework.Assert.IsNotNull(contentResult, "Result Content cant be null");
            NUnit.Framework.Assert.IsNotNull(contentResult.Content, "Result Content cant be null");
            NUnit.Framework.Assert.AreEqual(24, contentResult.Content, "Result should be 24");
        }

        [Test]
        public void DivideTest()
        {
            IHttpActionResult getdivideMethodResponse = controller.Divide(12, 4);
            var contentResult = getdivideMethodResponse as OkNegotiatedContentResult<double>;

            // Assert
            NUnit.Framework.Assert.IsNotNull(contentResult, "Result Content cant be null");
            NUnit.Framework.Assert.IsNotNull(contentResult.Content, "Result Content cant be null");
            NUnit.Framework.Assert.AreEqual(3, contentResult.Content, "Result should be 3");
        }
    }
}