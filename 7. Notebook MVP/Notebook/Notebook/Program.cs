using Notebook;

namespace Notebook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Form1 form = new Form1();
                IModel model = new Model();
                NotebookPresenter presenter = new NotebookPresenter(model, form);
                Application.Run(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
    }
}

