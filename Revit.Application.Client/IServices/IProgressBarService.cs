namespace Revit.Service.IServices
{
    public interface IProgressBarService//进度条处理接口
    {
        void Start(int max);
        void Stop();
    }
}
