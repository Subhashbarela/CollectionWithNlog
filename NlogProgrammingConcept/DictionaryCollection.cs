using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProgrammingConcept
{
    public class DictionaryCollection
    {
       
            private readonly Nlog nlog = new Nlog();

            public void InsertIntoDictionary()
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();

                dict.Add(101, "Welcome");
                dict.Add(102, "To");
                dict.Add(103, "Bridgelabs");
                dict.Add(10, "Solution");
                nlog.LogDebug("Debug Successfully:....  ");
                foreach (KeyValuePair<int, string> items in dict)
                {
                    Console.WriteLine("{0} : {1} ", items.Key, items.Value);
                }
                nlog.LogInfo("value of [101] is : " + dict[101]);

                // The Add method throws an exception if the new key is
                // already in the dictionary.
                try
                {
                    dict.Add(105, "winword.exe");
                }
                catch (ArgumentException ex)
                {
                    nlog.LogWarn("Add New Value Taking New Key ");
                    nlog.LogError($"An element with Key = \"102\" already exists.\n\n\n  {ex}");
                }
            }
            public void DictionaryWithBothString()
            {
                Dictionary<string, string> Employee = new Dictionary<string, string>()
            {
               {"Emp_Id", "101"},
               { "Emp_Name", "Subhash"},
               { "Emp_Add", "Jalgaon"},
               {"Profesion","Devloper" },
                {"Emp_Roll","Trainee" }
            };
                nlog.LogDebug("Debug Successfully:....  ");
                foreach (KeyValuePair<string, string> ele2 in Employee)
                {
                    Console.WriteLine("{0} : {1}", ele2.Key, ele2.Value);
                }

                nlog.LogInfo($"Insert the City : {Employee["City"] = "Chopda"}");

                Console.WriteLine("After Inserting New value : ");
                foreach (KeyValuePair<string, string> ele2 in Employee)
                {
                    Console.WriteLine("{0} : {1}", ele2.Key, ele2.Value);
                }

                // ContainsKey can be used to test keys before inserting
                // them.
                Console.WriteLine("Print the Value Using Given Key :");
                string key = Console.ReadLine();
                if (Employee.ContainsKey(key))
                {
                    Employee.Add("ht", "hypertrm.exe");
                    nlog.LogInfo($"Key  give for Display the Value : = \"{key}\":{Employee[key]}");
                    nlog.LogDebug("Debug Successfully ....");
                }
                else
                {
                    nlog.LogError("Key is not present in Dictionary ..");
                    nlog.LogWarn("Check Key Value Before Print  Value :...");
                }
            }
        }
}
