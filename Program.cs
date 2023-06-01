namespace WinFormsHomeApp_2
{
    public class CrAnket
    {
        public CrAnket() { }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string AtaAdi { get; set; }
        public string Strana { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Cinsi { get; set; }
        public string  Birth { get; set; }

        public override string ToString()
        {
            return $"{ Surname } \n {Name } \n {AtaAdi } \n {Strana } \n { City} \n {Phone } \n{Birth}\n {Cinsi } \n ";
        }
    }
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
            Application.Run(new Calculator());
        }
    }
}