namespace OOP_Project_Concept2
{
    internal static class Program1
    {
        [STAThread]// This to tell the compiler that is the main entry point of the application to know from where to start executing the code.
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
