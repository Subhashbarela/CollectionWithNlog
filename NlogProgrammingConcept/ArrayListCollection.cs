using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProgrammingConcept
{
    internal class ArrayListCollection
    {
        Nlog log = new Nlog();
        public void AddMethod()
        {
            ArrayList al=new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            log.LogDebug("Debuge SuccessFully..!");
            int cont = 0;
          foreach(var list in  al)
            {
                log.LogInfo($"{cont}: "+list);
                cont++;
            }
            if (al.Contains(al[2]))
            {
                log.LogInfo("value of index 2 is : "+al[2]);
            }
            else
            {
                log.LogWarn("Please provid valid index/presented index");
            }
            if (al.Contains(al[2]))
            {
                 al.Remove(al[2]);
            }
            else
            {
                log.LogWarn("Please provid valid index/presented index");
            }           
        }
    }
}
