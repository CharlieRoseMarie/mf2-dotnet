using Mf2_DotNet.Structure;

namespace Mf2_DotNet
{
    public interface IMf2Visitor
    {
        void Visit(IMf2Struct element);
    }
}