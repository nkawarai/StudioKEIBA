
namespace StudioKEIBA.HorseProfilerApp
{
    static internal class Message
    {
        static internal void ShowInformationMessage(IWin32Window? owner, string message)
        {
            MessageBox.Show(owner, message, "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static internal void ShowWarningMessage(IWin32Window? owner, string message)
        {
            MessageBox.Show(owner, message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static internal void ShowErrorMessage(IWin32Window? owner, string message)
        {
            MessageBox.Show(owner, message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}