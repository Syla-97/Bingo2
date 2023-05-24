namespace Bingo2
{
    internal static class Program
    {
        /// <summary>
        /// Global
        /// </summary>
        internal static class Global
        {
            internal static readonly string exeDirPath = Path.GetDirectoryName(Application.ExecutablePath)!;                          // ���s�����Ƃ��̎��g�̃t�H���_�p�X���擾
            internal static string saveDataPath = "";
            internal static int code = -1;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new root());
        }
    }
}