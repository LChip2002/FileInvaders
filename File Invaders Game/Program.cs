namespace File_Invaders_Game
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var xoxo = Directory.GetCurrentDirectory();

            Player player = new Player() 
            { 
                StartPosition = FormStartPosition.Manual, 
                Location = new Point(1500,1100), 
                Size = new Size(250,250)

            };

            Application.Run(player);
        }
    }
}