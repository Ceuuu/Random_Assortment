using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VVC8
{
    class Firma
    {
        private string ime;
        private int rabotnici;
        private int budget;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public int Rabotnici
        {
            get { return rabotnici; }
            set { rabotnici = value; }
        }

        public int Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public Firma() {

        }

        public Firma(string name, int employees, int budget)
        {
            this.ime = name;
            this.rabotnici = employees;
            this.budget = budget;
        }



        public void showinfo()
        {
            Console.WriteLine(ime);
            Console.WriteLine(rabotnici);
            Console.WriteLine(budget);
        }

        public void newProject()
        {
            Console.WriteLine("How many employees for the new project?: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("How much budget to be set for the project?: ");
            int b = int.Parse(Console.ReadLine());

            this.rabotnici -= e;
            this.budget -= b;
        }

        public void renameFirma()
        {
            Console.Write("Enter the new name of the firm: ");
            string nF = Console.ReadLine();
            this.ime = nF;
        }
    }
    internal class Firm
    {
        static void Main(string[] args)
        {
            Firma obj1 = new Firma();
            obj1.Ime = "Test_firma";
            obj1.Rabotnici = 100;
            obj1.Budget = 10000;

            Firma obj2 = new Firma("Mercedes", 3000, 5000000);

            obj1.showinfo();
            Console.Write("\n");
            obj1.newProject();
            obj1.showinfo();
            Console.Write("\n");
            obj1.renameFirma();
            obj1.showinfo();
        }
    }

}
