using Microsoft.VisualStudio.TestTools.UnitTesting;
using KM1.Properties;

namespace KM1.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        // Otestuj funkci JeUspech
        [TestMethod]
        public void TestMethod1()
            
        {           
            // Tento test projde
            bool expectedResult = true;
            bool actualResult = Evidence.JeUspech(10);
            Assert.AreEqual(expectedResult, actualResult);

            // Tento test projde
            expectedResult = false;
            actualResult = Evidence.JeUspech(0);
            Assert.AreEqual(expectedResult, actualResult);
           
            // Jiný způsob testu
            Assert.IsTrue(Evidence.JeUspech(10));
        }
    }
}
