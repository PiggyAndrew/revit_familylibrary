using System;
using System.Threading.Tasks;

namespace Revit.Shared.Extensions.Threading
{
    public class AsyncRunner
    {
        public static void Run(Task task, Action<Task> failCallback = null)
        {
            if (failCallback == null)
                task.ContinueWith((task1, o) => { }, TaskContinuationOptions.OnlyOnFaulted);
            else
                task.ContinueWith(failCallback, TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}