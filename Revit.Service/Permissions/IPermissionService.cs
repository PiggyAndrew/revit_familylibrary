using Revit.Entity.Commons;
using Revit.Entity.Permissions;
using Revit.Shared.Entity.Permissions;

namespace Revit.Service.Permissions
{
    public interface IPermissionService
    {
        /// <summary>
        /// 更新权限信息
        /// </summary>
        /// <param name="R_Permission"></param>
        /// <returns></returns>
        R_Permission Add(R_Permission R_Permission);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        bool Delete(long id);

        // <summary>
        /// 获取权限信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        R_Permission? Get(long id);

        /// <summary>
        /// 获取权限列表
        /// </summary>
        /// <returns></returns>
        List<PermissionDto> GetAll();

        /// <summary>
        /// 更新权限信息
        /// </summary>
        /// <param name="R_Permission"></param>
        /// <returns></returns>
        bool Update(R_Permission R_Permission);
    }
}