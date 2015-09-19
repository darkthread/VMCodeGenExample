using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeGen
{
    class Program
    {
        static List<ModelInfo> ReadModels()
        {
            XDocument xd = XDocument.Load("Model.xml");
            var models = new List<ModelInfo>();
            foreach (var xM in xd.Root.Elements("Model"))
            {
                var model = new ModelInfo()
                {
                    Name = xM.Attribute("Name").Value,
                    Remark = xM.Attribute("Remark").Value,
                    Properties = xM.Elements("Prop").Select(
                    o =>
                    {
                        var prop = new PropInfo()
                        {
                            Name = o.Attribute("Name").Value,
                            DataType = o.Attribute("Type").Value,
                            Remark = o.Attribute("Remark").Value
                        };
                        if (o.Attribute("Nullable") != null &&
                            o.Attribute("Nullable").Value == "true")
                            prop.Nullable = true;
                        return prop;
                    }).ToList()
                };
                models.Add(model);
            }
            return models;
        }


        static void Main(string[] args)
        {
            var models = ReadModels();
            var t4csvm = new T4.CsViewModels(models);
            File.WriteAllText(@"..\..\..\ViewModels\BaseModels.cs", t4csvm.TransformText(), Encoding.UTF8);
            var t4tsvm = new T4.TsViewModels(models);
            File.WriteAllText(@"..\..\..\Web\Scripts\BaseModels.ts", t4tsvm.TransformText(), Encoding.UTF8);
        }
    }
}
