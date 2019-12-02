using System;
using System.Collections.Generic;

namespace Mf2_DotNet.Structure
{
    [Serializable]
    public class HStruct : IMf2Struct
    {
        public IEnumerable<IMf2Struct> Items { get; set; } = new List<IMf2Struct>();
        public string Value { get; set; }
        public IEnumerable<string> Rels { get; set; } = new List<string>();
        public IEnumerable<string> RelUrls { get; set; }
        public void Accept(IMf2Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}