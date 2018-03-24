using Stolarus2.T4.Model;
using System.Collections.Generic;

namespace Stolarus2.T4.Templates
{
    public partial class RegisterModelBindersTemplate
    {
        public string RootNamespace { get; set; }

        public List<ModelInfo> Models { get; set; }
    }
}
