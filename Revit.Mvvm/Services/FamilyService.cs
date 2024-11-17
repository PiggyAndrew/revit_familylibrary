using Revit.Service.IServices;
using Autodesk.Revit.DB;
using System.Windows.Forms;
using Tuna.Revit.Extension;
using Revit.Shared.Entity.Family;
using Revit.Families;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.IO;
using Abp.Application.Services.Dto;
using Revit.Shared.Extensions.Threading;
using Revit.Mvvm.Interface;
using Revit.Shared.Base;
using Revit.Mvvm.Extensions;
using Castle.MicroKernel.Registration;

namespace Revit.Mvvm.Services
{
    public interface IFamilyService
    {
        /// <summary>
        /// 放置族
        /// </summary>
        /// <param name="familyDto"></param>
        /// <returns></returns>
        bool PromptForFamilyInstancePlacement(FamilyDto familyDto);

        /// <summary>
        /// 载入族
        /// </summary>
        /// <param name="filePath"></param>
        Task<bool> LoadFamily(byte[] filePath);
    }

    public class FamilyService : RevitViewModelBase, IFamilyService
    {
        public FamilyService(IDataContext dataContext) : base(dataContext)
        {
        }

        /// <summary>
        /// 放置族
        /// </summary>
        /// <param name="familyDto"></param>
        /// <returns></returns>
        public bool PromptForFamilyInstancePlacement(FamilyDto familyDto)
        {
            var familyName = Path.GetFileNameWithoutExtension(familyDto.Name);
            //查验本项目中是否存在同名族，询问是否直接放置或者依旧载入
            Family family = _document.GetElements<Family>().FirstOrDefault(x => x.Name == familyName) as Family;
            if (family == null) return false;
            var selectResult = MessageBox.Show("存在同名称族，选择是：使用已有族放置，选择否：依旧重新载入", "提示", MessageBoxButtons.YesNo);
            if (selectResult != DialogResult.Yes) return false;
            try
            {
                _uiDocument.PromptForFamilyInstancePlacement(family.GetFamilySymbols().FirstOrDefault());
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 载入族
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="filePath"></param>
        public async Task<bool> LoadFamily(byte[] bytes)
        {
            Family family = null;
            string filePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.rfa");
            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await fileStream.WriteAsync(bytes, 0, bytes.Length);
            }

            if (!File.Exists(filePath)) return false;
            _document.NewTransaction(() =>
            {
                //如果文档内存在相同的族会传输失败
                var loadResult = _document.LoadFamily(filePath, new FamilyPromptOverLoadOption(), out family);
                if (!loadResult)
                {
                    family = _document.GetElements<Family>()
                        .FirstOrDefault(x => x.Name == Path.GetFileNameWithoutExtension(filePath)) as Family;
                }
            });
            if (family == null) return false;
            try
            {
                _uiDocument.PromptForFamilyInstancePlacement(family.GetFamilySymbols().FirstOrDefault());
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }


}
