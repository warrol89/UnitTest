using Microsoft.VisualStudio.TestTools.UnitTesting;
using sampleapi.service;
using Moq;
using sampleapi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace sampleapi.tests{
    
    [TestClass]
public class MockTest{

        private Mock<IService> _service;
        private ValuesController controller;

        [TestInitialize]
public void TestInitialize(){
            _service = new Mock<IService>();
            controller = new ValuesController();
}

[TestMethod]
[TestCategory("base")]
public void TestMethodController(){
            _service.Setup(_ => _.TestMethod(2)).Returns("success");

            var actualResult = controller.Get(1) as ObjectResult;

            Assert.AreSame(actualResult.Value, "success");
            Assert.AreEqual(actualResult.StatusCode, 200);

}



}


}