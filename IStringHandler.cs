namespace TestTask
{
    /// <summary>
    /// Обработчик строк
    /// </summary>
    public interface IStringHandler
    {
        /// <summary>
        /// Обработать указанную строку
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        bool Check(string message);
    }
}
