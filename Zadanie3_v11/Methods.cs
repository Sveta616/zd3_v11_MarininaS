using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3_v11
{
    public class Methods
    {
        private int currentIndex;
        List<Airoplane> airoplanes;
        private Dictionary<string, PassangerAiroplane> pas = new Dictionary<string, PassangerAiroplane>();
        public Methods()
        {
            airoplanes = new List<Airoplane>();
            pas = new Dictionary<string, PassangerAiroplane>();
        }
      
     


    }
}
