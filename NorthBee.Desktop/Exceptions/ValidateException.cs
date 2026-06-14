using System;

namespace NorthBee.Desktop.Exceptions
{
    // <summary>
    /// PKGH
    /// Ошибка валидации данных
    /// </summary>
    public class ValidateException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ValidateException"/>
        /// </summary>
        public ValidateException(string message) : base(message) { }
    }
}
