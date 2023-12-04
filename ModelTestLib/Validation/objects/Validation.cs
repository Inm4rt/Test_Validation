using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelTestLib.Validation.Enums;

namespace ModelTestLib.Validation.objects
{
    public abstract class Validation
    {
        public string Id { get; }
        public TargetContextIDsEnums TargetContextIDs { get; }
        public string TargetType { get; }
        public string TargetCriteria { get; }
        public ResultTypeEnum ResultType { get; } 
        public bool InvertResult { get; }
        public Validation(string id, ValidationEnum validationEnum, string adres)
        {
            TakeValidation takeValidation = new TakeValidation(adres);
            this.Id = id;
            TargetCriteria = takeValidation.GetTargetCriteria(id, validationEnum);
            TargetContextIDs = takeValidation.GetTargetContextIDs(id, validationEnum);
            TargetType = takeValidation.GetTargetType(id, validationEnum);
            ResultType = takeValidation.ResultType(id,validationEnum);
            InvertResult = takeValidation.GetInvertResult(id, validationEnum);
        }
    }
}
