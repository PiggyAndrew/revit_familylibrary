using System.Collections.Generic;
using Abp.Auditing;

namespace Revit.Shared.Entity.Auths
{
    public interface IExpiredAndDeletedAuditLogBackupService
    {
        bool CanBackup();

        void Backup(List<AuditLog> auditLogs);
    }
}