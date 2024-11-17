using System.Collections.ObjectModel;
using Revit.Application.ViewModels;
using Revit.Application.ViewModels.FamilyViewModels;
using Revit.Shared.Entity.Family;
using Revit.Categories;
using Revit.Families;
using Revit.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Abp.Application.Services.Dto;
using Revit.Shared;
using CategoryListModel = Revit.Application.Models.Category.CategoryListModel;

namespace Revit.Service.Services
{
    public static class CategoryExtensions
    {
        internal static ObservableCollection<object> GenerateTree(this List<CategoryListModel> categories, long? parentId = null)
        {
            var masters = categories
                .Where(x => x.ParentId == parentId).ToList();

            var childs = categories
                .Where(x => x.ParentId != parentId).ToList();

            foreach (CategoryListModel dpt in masters)
                dpt.Children = GenerateTree(childs, dpt.Id);

            return new ObservableCollection<object>(masters);
        }

        internal static IEnumerable<long> GetNodeCategoriesIds(this CategoryListModel category)
        {

            // 初始化结果列表
            var result = new List<long>();

            // 递归函数
            void Recurse(CategoryListModel node)
            {
                // 将当前分类的ID添加到结果列表中
                result.Add(node.Id);
                // 遍历当前分类的所有子分类
                foreach (var child in node.Children)
                {
                    Recurse(child as CategoryListModel);
                }
            }

            // 开始递归
            Recurse(category);

            return result;

        }


        public static List<CategoryListModel> FlattenTree(this CategoryListModel node)
        {
            List<CategoryListModel> flatList = new List<CategoryListModel>();
            FlattenTreeHelper(node, flatList);
            return flatList;
        }

        private static void FlattenTreeHelper(CategoryListModel node, List<CategoryListModel> flatList)
        {
            flatList.Add(node);
            foreach (var child in node.Children)
            {
                FlattenTreeHelper(child as CategoryListModel, flatList);
            }
        }

    }


}
