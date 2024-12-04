using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class Encapsulation1
    {
        private string _colour;
        public void SetColour(string colour)
        {
            _colour = colour;
        }
        public string GetColour()
        {
            return _colour;
        }
    }
}
