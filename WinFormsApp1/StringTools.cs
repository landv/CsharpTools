using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class StringTools
    {


        /// <summary>
        /// 十六进制数据转换为字符串，支持指定编码
        /// </summary>
        /// <param name="hexString">十六进制字符串</param>
        /// <param name="encoding">编码方式（UTF8 或 ASCII）</param>
        /// <returns>转换后的字符串</returns>
        /// <exception cref="ArgumentException"></exception>
        ///  例子
        /// string hex = "48 65 6C 6C 6F";
        /// Console.WriteLine(DecodeHexString(hex, Encoding.UTF8));
        /// Console.WriteLine(DecodeHexString(hex, Encoding.ASCII));
        public string DecodeHexString(string hexString, Encoding encoding)
        {
            hexString = hexString.Replace(" ", "");
            hexString = hexString.Replace(",", "");
            hexString = hexString.Replace("，", "");
            hexString = hexString.Replace("；", "");
            hexString = hexString.Replace(".", "");
            try
            {
                if (hexString.Length % 2 != 0)
                {
                    //throw new ArgumentException("十六进制字符串长度必须为偶数");
                    return null;
                }

                byte[] bytes = new byte[hexString.Length / 2];
                for (int i = 0; i < hexString.Length; i += 2)
                {
                    string byteValue = hexString.Substring(i, 2);
                    bytes[i / 2] = Convert.ToByte(byteValue, 16);
                }
                return encoding.GetString(bytes);
            }
            catch (Exception)
            {

                //throw;
                return null;
            }
        }

        /// <summary>
        /// 字符串转换为十六进制数据，支持指定编码
        /// </summary>
        /// <param name="input">输入字符串</param>
        /// <param name="encoding">编码方式（UTF8 或 ASCII）</param>
        /// <returns>十六进制字符串</returns>
        /// string str = "Hello";
        /// Console.WriteLine(EncodeToHexString(str, Encoding.UTF8));
        /// Console.WriteLine(EncodeToHexString(str, Encoding.ASCII));
        public string EncodeToHexString(string input, Encoding encoding)
        {
            byte[] bytes = encoding.GetBytes(input);
            StringBuilder hexString = new StringBuilder();

            foreach (byte b in bytes)
            {
                hexString.Append(b.ToString("X2"));
                hexString.Append(" ");
            }

            return hexString.ToString().TrimEnd();
        }
    }
}
