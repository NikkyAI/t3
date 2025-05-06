using T3.Core.Operator;
using T3.Core.Operator.Attributes;
using T3.Core.Operator.Slots;
using System.Runtime.InteropServices;

namespace Examples.lib.field.space{
    [Guid("af0d2dfb-c192-4376-b75f-279a3cd7f86f")]
    internal sealed class TwistSDFExample : Instance<TwistSDFExample>
    {

        [Output(Guid = "501663c8-0ad1-41ec-82f0-76e2ca50c429")]
        public readonly Slot<T3.Core.DataTypes.Texture2D> Texture = new Slot<T3.Core.DataTypes.Texture2D>();

    }
}

