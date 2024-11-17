using Autodesk.Revit.DB.Events;
using Revit.Mvvm.Interface;
using Revit.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Application.UI
{
    internal class ApplicationEvent : IEventManager
    {
        private readonly IUIProvider _uiProvider;
        public ApplicationEvent(IUIProvider uiProvider)
        {
            _uiProvider = uiProvider;
        }

        public void Subscribe()//订阅事件
        {
            _uiProvider.GetApplication().DocumentOpened += ApplicationEvent_DocumentOpened;//通过COntrolApplication的事件处理器添加事件
            _uiProvider.GetApplication().DocumentClosed += ApplicationEvent_DocumentClosed;
            _uiProvider.GetApplication().DocumentCreated += ApplicationEvent_DocumentCreated;
        }
        public void Unsubscribe()
        {
            _uiProvider.GetApplication().DocumentOpened -= ApplicationEvent_DocumentOpened;
            _uiProvider.GetApplication().DocumentClosed -= ApplicationEvent_DocumentClosed;
            _uiProvider.GetApplication().DocumentCreated -= ApplicationEvent_DocumentCreated;
        }

        private void ApplicationEvent_DocumentCreated(object sender, DocumentCreatedEventArgs e)//实现事件
        {
        }

        private void ApplicationEvent_DocumentClosed(object sender, DocumentClosedEventArgs e)
        {
        }

        private void ApplicationEvent_DocumentOpened(object sender, DocumentOpenedEventArgs e)
        {
        }


    }
}
