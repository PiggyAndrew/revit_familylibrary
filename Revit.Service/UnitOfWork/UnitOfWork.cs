using Microsoft.EntityFrameworkCore.Storage;
using Revit.EntityFrameworkCore;

namespace Revit.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private readonly ApplicationDbContext _dbContext;

        /// <summary>
        /// 事务
        /// </summary>
        private IDbContextTransaction? _dbContextTransaction = null;

        /// <summary>
        /// 是否提交
        /// </summary>
        private bool _isCommit = false;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 开始事务
        /// </summary>
        public void BeginTransaction()
        {
            _dbContextTransaction = _dbContext.Database.BeginTransaction();
        }

        /// <summary>
        /// 提交事务
        /// </summary>
        public void Commit()
        {
            if (_dbContextTransaction != null)
            {
                _dbContextTransaction.Commit();
            }
            _isCommit = true;
        }

        /// <summary>
        /// 事务回滚
        /// </summary>
        public void Dispose()
        {
            if (_dbContextTransaction != null && !_isCommit)
            {
                _dbContextTransaction.Rollback();
            }
        }
    }
}
