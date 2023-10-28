namespace Barley_break_WPF
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
                GamePresenter presenter = new GamePresenter(model, form);
                Application.Run(form);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
    }
}