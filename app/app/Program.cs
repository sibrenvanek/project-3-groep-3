using System;
using System.Windows.Forms;



namespace app
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault();

            using (var game = new Game1())
                game.Run();
            //Application.Run(new Form1());
        }
    }
#endif
}
