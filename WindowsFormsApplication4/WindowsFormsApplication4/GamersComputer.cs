using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class GamersComputer:Computer
    {
        public string secondVideocard;

        public GamersComputer(string box, string DDR, string memory, string motherboard, string processor, string videocard, string type, string svideo):base(box,DDR,memory,motherboard,processor,videocard,type)
        {
            secondVideocard = svideo;
        }
    }
}
