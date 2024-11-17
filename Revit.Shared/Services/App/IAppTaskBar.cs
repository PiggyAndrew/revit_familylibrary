
namespace Revit.Shared.Services.App
{
    public interface IAppTaskBar
    {
        void Initialization();

        void Dispose();

        //void ShowBalloonTip(string title, string message, BalloonIcon balloonIcon);
    }
}
