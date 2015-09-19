using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.T4
{
    public partial class CsViewModels
    {
        public List<ModelInfo> Models;
        public CsViewModels(List<ModelInfo> models)
        {
            Models = models;
        }
    }
}
