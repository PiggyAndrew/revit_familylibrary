using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows;
using Prism.Ioc;
using DryIoc;
using Revit.Entity;
using System;
using Revit.Mvvm.Interface;
using Prism.Modularity;
using Tuna.Revit.Extension;

namespace Revit.Shared.Base
{
    public abstract class CommandBase : PrismBootstrapperBase, IExternalCommand
    {
        protected IDataContext DataContext => Container.Resolve<DataContext>(); 

        public ExternalCommandData CommandData { get; set; }

        public virtual Result Execute(string message, ElementSet elements)
        {
            try
            {
                this.Run();
                //TransactionResult transactionResult = CommandData.Application.ActiveUIDocument.Document.NewTransactionGroup(this.Run, "族库管理"
                //);
                //return transactionResult.TransactionStatus == TransactionStatus.Committed
                //    ? Result.Succeeded
                //    : Result.Cancelled;
                return Result.Succeeded;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + exception.InnerException?.Message);
                return Result.Cancelled;
            }
        }

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)//CMD程序主入口
        {
            try
            {
                CommandData = commandData;
                Execute(message, elements);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.InnerException?.Message);
                return Result.Cancelled;
            }

            return Result.Succeeded;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterTypes(containerRegistry);
            containerRegistry.RegisterInstance(CommandData);
            containerRegistry.RegisterSingleton<IDataContext, DataContext>();
            RegisterCommandTypes(containerRegistry);
        }

        protected abstract void RegisterCommandTypes(IContainerRegistry containerRegistry);
    }
}
