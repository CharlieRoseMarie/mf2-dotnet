using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mf2_DotNet.Structure
{
    public interface IMf2Struct
    {
        [JsonProperty(PropertyName = "items")] IEnumerable<IMf2Struct> Items { get; set; }

        string Value { get; set; }

        [JsonProperty(PropertyName = "rels")] ISet<string> Rels { get; set; }

        [JsonProperty(PropertyName = "rel-urls")]
        ISet<string> RelUrls { get; set; }

        void Accept(IMf2Visitor visitor);
    }
}