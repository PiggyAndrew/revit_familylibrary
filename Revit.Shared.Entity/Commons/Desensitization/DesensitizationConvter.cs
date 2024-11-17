using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Commons.Desensitization
{
    /// <summary>
    /// 脱敏转化器
    /// </summary>
    public class DesensitizationConvter : JsonConverter
    {
        //关闭反序列化
        public override bool CanRead => false;
        //开启自定义序列化
        public override bool CanWrite => true;
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        /// <summary>
        /// 前保留长度
        /// </summary>
        private readonly int StartLen;

        /// <summary>
        /// 脱敏长度
        /// </summary>
        private readonly int ReplaceLen;

        /// <summary>
        /// 替换的特殊字符
        /// </summary>
        private readonly char ReplaceChar;

        /// <summary>
        /// 默认前保留长度4，脱敏长度4，特殊字符为*
        /// </summary>
        public DesensitizationConvter()
        {
            StartLen = 4;
            ReplaceLen = 4;
            ReplaceChar = '*';
        }

        /// <summary>
        /// 根据传入的长度进行脱敏
        /// </summary>
        /// <param name="startLen">前保留长度</param>
        /// <param name="replaceLen">脱敏长度</param>
        public DesensitizationConvter(int startLen, int replaceLen) : this()
        {
            StartLen = startLen;
            ReplaceLen = replaceLen;
        }

        /// <summary>
        /// 根据传入的长度及特殊字符进行脱敏
        /// </summary>
        /// <param name="startLen">前保留长度</param>
        /// <param name="replaceLen">脱敏长度</param>
        /// <param name="replaceChar">替换的特殊字符</param>
        public DesensitizationConvter(int startLen, int replaceLen, char replaceChar) : this(startLen, replaceLen)
        {
            ReplaceChar = replaceChar;
        }

        /// <summary>
        /// 读取Json
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新Json
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                writer.WriteValue(value.ToString().ReplaceWithSpecialChar(StartLen, ReplaceLen, ReplaceChar));
            }
        }
    }
}
