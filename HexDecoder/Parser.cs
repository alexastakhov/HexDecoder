using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDecoder
{
    /// <summary>
    /// Класс статического парсера.
    /// </summary>
    public static class Parser
    {
        /// <summary>
        /// 
        /// </summary>
        private static string CHARS = "0123456789abcdefABCDEF";

        /// <summary>
        /// 
        /// </summary>
        private static List<byte> bytes = new List<byte>();

        /// <summary>
        /// 
        /// </summary>
        private static List<string> bytesAsText = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        private static string outString = string.Empty;

        /// <summary>
        /// Метод декодирования данных в виде строки, 
        /// представляющей последовательность HEX-кодов.
        /// </summary>
        /// <param name="inputText">Декодируемый текст.</param>
        /// <returns>Результат декодирования.</returns>
        public static DecodeResult Decode(string inputText)
        {
            var separator = string.Empty;
            var clearedText = inputText.Replace("\n", "").Replace("\t", "").Replace(" ","").Replace(":", "").Replace("-", "");
            var tempByteAsString = string.Empty;

            for (int i = 0; i < clearedText.Length; i++)
            {
                ////if (clearedText[i].)

                if (tempByteAsString.Length < 2)
                {

                }
                else
                {

                }
            }

            return null;
        }

        /// <summary>
        /// Метод декодирования данных в виде последовательности байт.
        /// </summary>
        /// <param name="inputBytes">Декодируемые данные.</param>
        /// <returns>Результат декодирования.</returns>
        public static DecodeResult Decode(byte[] inputBytes)
        {
            throw new NotImplementedException();
        }
    }
}
