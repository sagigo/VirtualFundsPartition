using System;
using System.Windows.Forms;

namespace VirtualFundsPartition
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //(string, double)[] ps = { ("p1", 100), ("p2", 200.5), ("p3", 1000.05) };
            //Portfolio portfolio = new Portfolio(ps);
            //Console.WriteLine(portfolio.StringTable);
            //Console.WriteLine();
            //Console.WriteLine(portfolio.JsonStringRepresentation);

            //Portfolio portfolio1 = new Portfolio(portfolio.JsonStringRepresentation);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
