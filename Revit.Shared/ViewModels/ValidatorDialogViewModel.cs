using CommunityToolkit.Mvvm.ComponentModel;
using FluentValidation.Results;
using Prism.Ioc;
using Revit.Shared.Services.App;
using Revit.Shared.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.ViewModels
{
        public partial class ValidatorDialogViewModel:ObservableValidator
        {
            public ValidatorDialogViewModel()
            {
                mapper = SharedModule.Instance.Container.Resolve<IAppMapper>();
                validator = SharedModule.Instance.Container.Resolve<IGlobalValidator>();
            }

            public ValidatorDialogViewModel(IAppMapper appMapper, IGlobalValidator globalValidator)
            {
                mapper = appMapper;
                validator = globalValidator;
            }

            private bool isBusy;
            private readonly IAppMapper mapper;
            private readonly IGlobalValidator validator;

            public bool IsNotBusy => !IsBusy;

            public bool IsBusy
            {
                get => isBusy;
                set
                {
                    isBusy = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsNotBusy));
                }
            }

            public virtual async Task SetBusyAsync(Func<Task> func, string loadingMessage = null)
            {
                IsBusy = true;
                try
                {
                    await func();
                }
                finally
                {
                    IsBusy = false;
                }
            }

            /// <summary>
            /// 实体映射方法
            /// </summary>
            /// <typeparam name="T">最终类型</typeparam>
            /// <param name="model">映射实体</param>
            /// <returns></returns>
            public T Map<T>(object model) => mapper.Map<T>(model);
        }
}
