using System.Collections.Generic;

namespace Mf2_DotNet.Structure
{
    public interface IMf2Struct
    {
        IEnumerable<IMf2Struct> Items { get; set; }
        string Value { get; set; }
        IEnumerable<string> Rels { get; set; }
        IEnumerable<string> RelUrls { get; set; }
        void Accept(IMf2Visitor visitor);
    }
}