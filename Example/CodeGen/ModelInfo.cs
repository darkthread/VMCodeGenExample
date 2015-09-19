using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
    public class ModelInfo
    {
        public string Name;
        public string Remark;
        public List<PropInfo> Properties;
    }
    public class PropInfo {
        public string Name;
        public string DataType;
        public string CsType
        {
            get
            {
                if (Nullable && DataType != "string")
                    return DataType + "?";
                else 
                    return DataType;
            }
        }
        public string TsType
        {
            get
            {
                switch (DataType)
                {
                    case "int":
                    case "float":
                    case "double":
                    case "decimal":
                        return "number";
                    case "DateTime":
                        return "Date";
                    case "bool":
                        return "boolean";
                    case "string":
                        return "string";
                    default:
                        throw new ApplicationException(
                            "Unexpected Type - " + DataType);
                }
            }
        }
        public bool Nullable;
        public string Remark;
    }
}
