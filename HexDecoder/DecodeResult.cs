using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexDecoder
{
    /// <summary>
    /// Класс результата декодирования.
    /// </summary>
    public class DecodeResult
    {
        /// <summary>
        /// Представление в виде последовательности байт.
        /// </summary>
        private byte[] bytes;

        /// <summary>
        /// Представление в виде строки.
        /// </summary>
        private string outString;

        /// <summary>
        /// Последовательность байт в виде текста.
        /// </summary>
        private List<string> bytesAsText;

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="outString"></param>
        /// <param name="bytesAsText"></param>
        public DecodeResult(byte[] bytes, string outString, List<string> bytesAsText)
        {

        }
    }
}
