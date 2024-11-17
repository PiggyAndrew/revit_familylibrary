using Autodesk.Revit.UI;
using CommunityToolkit.Mvvm.Input;
using RestSharp;
using Revit.Entity.Interfaces;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace Revit.Application.ViewModels
{
    public class TestViewModel : ViewModelBase
    {

        public TestViewModel()
        {
            IExternalEventHandler externalEventHandler = new ExternalEventHandler();
            externalEvent = ExternalEvent.Create(externalEventHandler);
        }

        private AsyncRelayCommand _testCommand;
        private ExternalEvent externalEvent;

        public AsyncRelayCommand TestCommand { get => _testCommand ?? new AsyncRelayCommand(Test); }

        private async Task Test()
        {
            var client = new RestClient();
            var request = new RestRequest( Method.POST);
            client.BaseUrl =new Uri(@$"http://localhost:5177/api/Projects");
            request.AddHeader("Host", "localhost:5177");
            request.AddParameter("creatorId", "123");
            request.AddParameter("projectName", "123");
            request.AddParameter("projectAddress", "123");
            request.AddParameter("introduction", "123");
            var response = await client.ExecuteAsync(request);


            MessageBox.Show(response.Content.ToString()+response.ErrorMessage);
        }
    }

    public class ExternalEventHandler : IExternalEventHandler
    {
        public void Execute(UIApplication app)
        {
            MessageBox.Show("response.ErrorMessage");
            var client = new RestClient("http://localhost:5177/api");
            var body = @"{
" + "\n" +
            @"  ""pageIndex"": 1,
" + "\n" +
            @"  ""pageSize"": 5,
" + "\n" +
            @"  ""searchMessage"": """",
" + "\n" +
            @"  ""userId"": 1
" + "\n" +
            @"}";
            var request = new RestRequest("Projects").AddJsonBody(body);
            var response = client.Get(request);
            MessageBox.Show(response.ErrorMessage);
        }

        public string GetName()
        {
            return "EventCommand";
        }
    }
}
