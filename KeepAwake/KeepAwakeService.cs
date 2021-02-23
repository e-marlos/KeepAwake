using System.Runtime.InteropServices;

namespace KeepAwake
{
    public static class KeepAwakeService
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);

        public static void KeepAwake()
        {
            SetThreadExecutionState(ExecutionState.DisplayRequired | ExecutionState.Continuous |
                                    ExecutionState.AwayModeRequired | ExecutionState.EsSystemRequired);
        }
    }
}