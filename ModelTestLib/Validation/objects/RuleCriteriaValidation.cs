using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelTestLib.Validation.Enums;

namespace ModelTestLib.Validation.objects
{
    public class RuleCriteriaValidation:Validation
    {
        public string Criteria { get; }
        public RuleCriteriaValidation(string id, string adres) :base(id, ValidationEnum.RuleCriteria, adres)
        {
            TakeValidation takeValidation = new TakeValidation(adres);
            Criteria = takeValidation.GetCriteria(id, ValidationEnum.RuleCriteria);
        }
    }
}
