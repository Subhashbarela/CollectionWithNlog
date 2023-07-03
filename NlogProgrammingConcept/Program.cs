using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProgrammingConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Nlog Program \n2: ArrayList \n3: Dictionay Collection");
            Console.WriteLine("Enter the choiice");
            int choice= int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        AddClass sum = new AddClass();
                        sum.Add(10, 20);
                        break;
                    } case 2:
                    {
                        ArrayListCollection al = new ArrayListCollection();
                        al.AddMethod();
                        break;
                    }
                case 3:
                    {
                        DictionaryCollection di= new DictionaryCollection();
                        di.InsertIntoDictionary();
                       // di.DictionaryWithBothString();
                        break;
                    }
            }
            
        }
    }
}
