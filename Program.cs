namespace Kutuphane
{

   

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //KullaniciBilgileri kullanici=new KullaniciBilgileri();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new  FrmGiris());
        // https://stackoverflow.com/questions/46112835/execute-stored-procedure-with-parameters-postgresql
        }
    }
}