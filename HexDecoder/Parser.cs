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
        private static List<byte> bytes = new List<byte>();
        private static List<string> bytesAsText = new List<string>();
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
            var clearedText = inputText.Replace("\n", "").Replace("\t", "").Replace(" ","");
            var tempByteAsString = string.Empty;

            for (int i = 0; i < clearedText.Length; i++)
            {
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
