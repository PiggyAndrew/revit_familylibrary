using Autodesk.Revit.UI;
using Revit.Application.Properties;
using Revit.Extension;
using Revit.Mvvm.Interface;

namespace Revit.Application.UI
{
    public class ApplicationUI : IApplication
    {

        //定义一个常量名称
        private const string _tab = "自定义功能";
        private readonly IUIProvider _uiProvider;
        public ApplicationUI(IUIProvider uiProvider)
        {
            _uiProvider = uiProvider;
        }
        public Result Initial()
        {
            //创建按钮
            _uiProvider.GetUIControlledApplication().CreateRibbonTab(_tab);
            //创建按钮面板
            RibbonPanel panel = _uiProvider.GetUIControlledApplication().CreateRibbonPanel(_tab, "协同");


            //panel.CreateButton<Commands.ProjectsCommand>((b) =>
            //{
            //    b.Text = "项目管理端";
            //    b.LargeImage = Properties.Resources.族库.ConvertToBitmapSource();
            //    b.ToolTip = "项目管理端";
            //});

            panel.CreateButton<Commands.Login>((b) =>
            {
                b.Text = "登录";
                b.LargeImage = Resources.RibbonIcon32.ConvertToBitmapSource();
                b.ToolTip = "登录界面";
            });
            return Result.Succeeded;
        }


    }
}
