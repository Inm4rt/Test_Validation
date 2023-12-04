using DevExpress.Data.Filtering;
using ModelTestLib.Validation;
using ModelTestLib.Validation.Enums;
using ModelTestLib.Validation.objects;
using TestXAFAPP.Module.BusinessObjects.TestXAFAPP;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DevExpress.Xpo.Session session = new DevExpress.Xpo.Session();
            TakeValidation takeValidation = new TakeValidation("D:\\project\\TestXAFAPP\\TestXAFAPP.Module\\Model.DesignedDiffs.xafml");
            string a = takeValidation.GetCriteria("Order_Min_Cost", ValidationEnum.RuleCriteria);
            Order order = new Order(session);
            order.Cost = 250;
            order.Link = "d";
            order.Client = new Client(session);
            
            Assert.IsTrue((bool)order.Evaluate(CriteriaOperator.Parse(a)));
        }
        [Test]
        public void Test2()
        {
            DevExpress.Xpo.Session session = new DevExpress.Xpo.Session();
            RuleCriteriaValidation ruleCriteriaValidation = new RuleCriteriaValidation("Order_Min_Cost", "D:\\project\\TestXAFAPP\\TestXAFAPP.Module\\Model.DesignedDiffs.xafml");
            Order order = new Order(session);
            order.Cost = 250;
            order.Link = "d";
            order.Client = new Client(session);

            Assert.IsTrue((bool)order.Evaluate(CriteriaOperator.Parse(ruleCriteriaValidation.TargetCriteria)));
            Assert.IsTrue((bool)order.Evaluate(CriteriaOperator.Parse(ruleCriteriaValidation.Criteria)));
            Assert.IsFalse(ruleCriteriaValidation.InvertResult);
            Assert.AreEqual(typeof(Order).ToString(), ruleCriteriaValidation.TargetType);
            Assert.AreEqual(TargetContextIDsEnums.Delete, ruleCriteriaValidation.TargetContextIDs);
            Assert.AreEqual(ResultTypeEnum.Information, ruleCriteriaValidation.ResultType);
        }
    }
}