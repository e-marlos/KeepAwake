using System;

namespace KeepAwake
{
    [Flags]
    public enum ExecutionState : uint
    {
        AwayModeRequired = 0x00000040,
        Continuous = 0x80000000,
        DisplayRequired = 0x00000002,
        EsSystemRequired = 0x00000001
    }
}