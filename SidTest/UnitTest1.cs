using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SidTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSid_false()
        {
            // Arrange
           /* Your_name craft = new Your_name();

            // Act
            String sid = "457842166464";*/

            // Assert
            Assert.ThrowsException<Exception>(() => craft.Make());
        }
    }
}
