using System.Collections.Generic;

namespace Mf2_DotNet.Structure
{
    public class Mf2Struct : IMf2Struct
    {
        public IEnumerable<IMf2Struct> Items { get; set; } = new List<IMf2Struct>();
        public string Value { get; set; }
        public ISet<string> Rels { get; set; } = new HashSet<string>();
        public ISet<string> RelUrls { get; set; } = new HashSet<string>();

        public void Accept(IMf2Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}