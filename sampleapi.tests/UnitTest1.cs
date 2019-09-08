using Microsoft.VisualStudio.TestTools.UnitTesting;
using sampleapi.Controllers;

namespace sampleapi.tests
{
    [TestClass]
    public class UnitTest1
    {
        private  ValuesController controller ;

        [TestInitialize]
        public  void Initialize(){
            controller = new ValuesController();
        }
        [TestMethod]
        public void TestMethod1()
        {
            var actualResult = controller.Get();
            Assert.IsInstanceOfType(actualResult)


        }
    }
}
