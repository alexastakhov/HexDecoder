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
        /// Хранит значение <see cref="Bytes"/>
        /// </summary>
        private List<byte> bytes;

        /// <summary>
        /// Хранит значение <see cref="OutString"/>
        /// </summary>
        private string outString;

        /// <summary>
        /// Хранит значение <see cref="BytesAsText"/>
        /// </summary>
        private List<string> bytesAsText;

        /// <summary>
        /// Хранит значение <see cref="Errors"/>
        /// </summary>
        private List<string> errors;

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="bytes">Представление в виде последовательности байт.</param>
        /// <param name="outString">Представление в виде строки.</param>
        /// <param name="bytesAsText">Последовательность байт в виде текста.</param>
        /// <param name="errors">Ошибки декодирования.</param>
        public DecodeResult(List<byte> bytes, string outString, List<string> bytesAsText, List<string> errors)
        {
            this.bytes = bytes;
            this.outString = outString;
            this.bytesAsText = bytesAsText;
            this.errors = errors;
        }

        /// <summary>
        /// Представление в виде последовательности байт.
        /// </summary>
        public List<byte> Bytes
        {
            get
            {
                return this.bytes;
            }
        }

        /// <summary>
        /// Представление в виде строки.
        /// </summary>
        public string OutString
        {
            get
            {
                return this.outString;
            }
        }

        /// <summary>
        /// Последовательность байт в виде текста.
        /// </summary>
        public List<string> BytesAsText
        {
            get
            {
                return this.bytesAsText;
            }
        }

        /// <summary>
        /// Ошибки декодирования.
        /// </summary>
        public List<string> Errors
        {
            get
            {
                return this.errors;
            }
        }
    }
}
