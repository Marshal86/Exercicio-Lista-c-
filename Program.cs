using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exlist
{
    class Program
    {
        static void Main(string[] args)
        { 

           
            
            
            Console.WriteLine("How many employees will be registered");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> ListaEmp = new List<Funcionario>();

            for (int i = 0; i<n; i++)
            {
                Console.Write("Emplyoee #{0}", i);
                Console.WriteLine("Id : ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Nome : ");
                string nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Salario : ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                ListaEmp.Add(new Funcionario(id, nome, salario));

              
            }

            Console.Write("Enter the employee id that will have salary increase :");
            int achaID = int.Parse(Console.ReadLine());

            Funcionario func = ListaEmp.Find(x=> x.Id == achaID);

            if (func != null)
            {
                Console.Write("Enter the percentage: ");
                double porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.Salario(porcento);
            } else
            {
                Console.WriteLine("This Id does not exist");
            }
       


            foreach (Funcionario obj in ListaEmp)
            {
                Console.WriteLine(obj);
            } 


        }
    }
}
