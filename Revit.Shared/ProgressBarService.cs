using Revit.Service.Contants;
using Revit.Service.IServices;

namespace Tamplate.Revit.Mep.Services
{
    public class ProgressBarService : IProgressBarService//进度条处理（实体层）
    {
        private ProgressBarDialog _progressBarDialog;
        public void Start(int max)
        {
            _progressBarDialog = new ProgressBarDialog();
            _progressBarDialog.DataContext = new ProgressBarViewModel();
            _progressBarDialog.Show();
            Messenger.Default.Send<int>(max,ServiceTokens.ProgressBarDialog_Max);
        }

        public void Stop()
        {
            Messenger.Default.Unregister(_progressBarDialog);
            Messenger.Default.Unregister(_progressBarDialog.DataContext);
            _progressBarDialog.Close();
        }
    }
}
