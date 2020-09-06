using NUnit.Framework;
using WebApplication1.Repository;
using Moq;
using WebApplication1;
using System.Collections.Generic;

namespace NUnitTestApplication
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Return_All()
        {
            var mock = new Mock<IRuleRepository>();
            mock.Setup(p => p.GetRules()).Verifiable();
            mock.Setup(p => p.GetRules()).Returns(new List<RuleItem>());
            //Assert.IsTrue(mock.Object.GetRules().Count == 5);
        }

        [Test]
        public void Test_Verify_Rule()
        {
            var mock = new Mock<IRuleRepository>();
            mock.Setup(p => p.GetRuleByPaymentType(1)).Verifiable();
            mock.Setup(p => p.GetRuleByPaymentType(5)).Returns("Added a first aid video to packing slip as per court's order");
        }
    }
}