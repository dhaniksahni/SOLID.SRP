using SOLID.SRP.FirstRefactor;
using SOLID.SRP.SecondRefactorCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLID.SRP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var presenter = new ProductPresenter();
            Application.Run((Form)presenter.View);
            //Application.Run(new FirstRefactorForm());
        }
    }
}
