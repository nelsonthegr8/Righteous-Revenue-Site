using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanceSite.Constructors;

namespace FinanceSite.UnitTests
{
    [TestClass]
    public class AtmChecklistTests
    {
        [TestMethod]
        public void AtmBillAmntBreakdown_ReturnsAmountBrokenDownByBills()
        {
            //Arrange 
            var AtmChecklist = new AtmChecklist("NelsonTheGr8","Wifi",128);
            //Act
            var result = AtmChecklist.twenty == 6 && AtmChecklist.ten == 0 && AtmChecklist.five == 1 && AtmChecklist.one == 3;
            //Assert
            Assert.IsTrue(result);
        }
    }
}
