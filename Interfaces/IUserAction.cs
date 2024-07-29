namespace FillInApp.Interfaces
{
    /// <summary>
    /// Действие пользователя
    /// </summary>
    public interface IUserAction
    {
        /// <summary>
        /// Выполнение действия пользователя
        /// </summary>
        void Execute(IOfficeWrapper wrapper);
    }
}
