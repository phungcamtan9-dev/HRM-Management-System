using HyperionHR_meta.Scripts.Class.System;

namespace HyperionHR_meta.Scripts
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string fileName = "hrsystem.json"; // tên file lưu dữ liệu

            HRSystem system = HRSystem.Instance; //Singleton

            system.Load(fileName); //bom dữ liệu

            Application.Run(new LoginForm()); // chạy loginform
        }
    }
}