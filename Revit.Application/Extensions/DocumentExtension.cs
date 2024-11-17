using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Extension
{
    public static class DocumentExtension
    {
        public static void NewTransaction(this Document document, string NameOfTransaction, Action action)
        {
            using (Transaction tr = new Transaction(document, NameOfTransaction))
            {
                tr.Start();
                action?.Invoke();
                tr.Commit();
            }
        }

        public static TransactionStatus NewTransactionGroup(this Document document, string Name, Func<bool> func)
        {
            TransactionStatus transactionStatus = TransactionStatus.Uninitialized;//先让事务状态赋值为失败        
            using (TransactionGroup transactionGroup = new TransactionGroup(document, Name))
            {
                transactionGroup.Start();
                try
                {
                    if (func.Invoke()) //判断窗口是否返回值并开启窗口
                    {
                        transactionStatus = transactionGroup.Assimilate();
                    }
                    else
                    {
                        transactionStatus = transactionGroup.RollBack();
                    }
                }
                catch (Exception)
                {
                    transactionStatus = transactionGroup.RollBack();
                }
            }
            return transactionStatus;
        }
        public static TransactionStatus NewTransactionGroup(this Document document, string Name, Action action)
        {
            TransactionStatus transactionStatus = TransactionStatus.Committed;//先让事务状态赋值为失败        
            using (TransactionGroup transactionGroup = new TransactionGroup(document, Name))
            {
                transactionGroup.Start();
                action.Invoke();
                transactionStatus = transactionGroup.Commit();
            }
            return transactionStatus;
        }


    }
}
