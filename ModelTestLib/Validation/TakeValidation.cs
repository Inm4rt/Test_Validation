using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ModelTestLib.Validation.Enums;

namespace ModelTestLib.Validation
{
    public class TakeValidation
    {
        XDocument xdoc;
        public TakeValidation(string adress)
        {
            xdoc = XDocument.Load(adress);
        }
        public string GetCriteria(string id, ValidationEnum validationType)
        {
            return GetNode(id, validationType, "Criteria");
        }
        public string GetTargetCriteria(string id, ValidationEnum validationType)
        {
            return GetNode(id, validationType, "TargetCriteria");
        }
        public string GetTargetType(string id, ValidationEnum validationType)
        {
            return GetNode(id, validationType, "TargetType");
        }
        public TargetContextIDsEnums GetTargetContextIDs(string id, ValidationEnum validationType)
        {
            string TargetContextIDs = GetNode(id, validationType, "TargetContextIDs");
            TargetContextIDsEnums targetContextIDsEnums;
            switch (TargetContextIDs)
            {
                case "Save":
                    targetContextIDsEnums = TargetContextIDsEnums.Save; 
                    break;
                case "Delete":
                    targetContextIDsEnums = TargetContextIDsEnums.Delete;
                    break;
                default:
                    targetContextIDsEnums = TargetContextIDsEnums.None; 
                    break;
            }
            return targetContextIDsEnums;
        }
        public ResultTypeEnum ResultType(string id, ValidationEnum validationType)
        {
            string resultType = GetNode(id, validationType, "ResultType");
            ResultTypeEnum resultTypeEnum;
            switch (resultType)
            {
                case "Error":
                    resultTypeEnum = ResultTypeEnum.Error;
                    break;
                case "Warning":
                    resultTypeEnum = ResultTypeEnum.Warning;
                    break;
                case "Information":
                    resultTypeEnum = ResultTypeEnum.Information;
                    break;
                default:
                    resultTypeEnum = ResultTypeEnum.None;
                    break;
            }
            return resultTypeEnum;
        }
        public bool GetInvertResult(string id, ValidationEnum validationType)
        {
            return bool.Parse(GetNode(id, validationType, "InvertResult"));
        }
        private string GetNode(string id, ValidationEnum validationType, string attribute)
        {
            IEnumerable<XElement> elements =
                from e in xdoc.Descendants(validationType.ToString())
                where (string)e.Attribute("Id") == id
                select e;
            return changeCode(elements?.FirstOrDefault()?.Attribute(attribute)?.ToString().Split("\"")[1]);
        }
        private string changeCode(string str)
        {
            return str.Replace("&gt;", ">").Replace("&lt;", "<");
        }
    }
}
