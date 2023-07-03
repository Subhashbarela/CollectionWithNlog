using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProgrammingConcept
{
    public class AddClass
    {
        Nlog nlog=new Nlog();
        public void Add(int numOne,int numTwo)
        {
            nlog.LogDebug("Debuge Successfully...!");
            if(numOne == 0 && numTwo == 0)
            {
                nlog.LogWarn("Please insert value");
                nlog.LogError("both value are zero");
            }
            else
            {
                nlog.LogInfo("Addition of two number is : " + (numOne + numTwo));
            }
        }
    }
}
