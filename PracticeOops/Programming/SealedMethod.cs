using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Programming
{
    //in sealed method inherited class.. we use sealed in methd with override so after that it is not inherited further
    public class SealedMethod
    {
        public virtual void sealedmethod()
        {
            Console.WriteLine("Sealed Method");
        }
    }
    public class SealedMethod1 : SealedMethod
    {
        public sealed override void sealedmethod()
        {
            Console.WriteLine("Sealed Method 1");
        }
    }
    
}
