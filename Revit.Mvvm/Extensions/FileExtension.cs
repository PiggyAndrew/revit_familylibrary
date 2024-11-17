using System;
using System.Windows.Forms;

namespace Revit.Mvvm.Extensions
{
    public static class FileExtension
    {
        public static OpenFileDialog SelectFile(Action<OpenFileDialog> dialogConfig = null)
        {
            //获取文档路径
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有文件 (*.*)|*.*";
            openFileDialog.Title = "选择一个文件";
            if (dialogConfig != null)
            {
                dialogConfig.Invoke(openFileDialog);
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog;
            }
            return null;
        }


    }
}
