using Microsoft.VisualStudio.TestTools.UnitTesting;
using sampleapi.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
          


        }
    }
}
