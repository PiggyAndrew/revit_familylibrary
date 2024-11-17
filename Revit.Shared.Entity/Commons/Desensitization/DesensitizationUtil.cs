using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Commons.Desensitization
{
    /// <summary>
    /// 脱敏器
    /// </summary>
    public static class DesensitizationUtil
    {
        /// <summary>
        /// 将传入的字符串中间部分字符替换成特殊字符
        /// </summary>
        /// <param name="value">需要替换的字符串</param>
        /// <param name="startLen">前保留长度，默认4</param>
        /// <param name="replaceLen">要替换的长度，默认4</param>
        /// <param name="replaceChar">特殊字符，默认为*</param>
        /// <returns>替换后的结果</returns>
        public static string ReplaceWithSpecialChar(this string value, int startLen = 4, int replaceLen = 4, char replaceChar = '*')
        {
            //替换长度不可为0 
            if (replaceLen == 0)
            {
                replaceLen = 4;
            }

            //前保留的长度不可大于字内容的长度
            if (value.Length < startLen)
            {
                if (value.Length > replaceLen)
                {
                    startLen = value.Length - replaceLen;
                }
            }

            //内容的长度不可小于 前保留+替换的长度
            if (value.Length < startLen + replaceLen)
            {
                replaceLen = value.Length - startLen;
            }

            string startStr = value.Substring(0, startLen);
            string endStr = value.Substring(startLen + replaceLen);
            string specialStr = new string(replaceChar, replaceLen);

            return startStr + specialStr + endStr;
        }
    }
}
