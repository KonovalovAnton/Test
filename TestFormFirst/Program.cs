using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestFormFirst
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            ModelProvider modelProvider = new ModelProvider();
            ControllerProvider controllerProvider = new ControllerProvider(modelProvider);

            Application.Run(new Form1(modelProvider, controllerProvider));
        }
    }
}
