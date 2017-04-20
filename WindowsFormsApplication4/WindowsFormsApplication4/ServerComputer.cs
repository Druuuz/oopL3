using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class ServerComputer:Computer
    {
        public string SecondStorage;

        public ServerComputer(string box, string DDR, string memory, string motherboard, string processor, string videocard, string type, string storage):base(box,DDR,memory,motherboard,processor,videocard,type)
        {
            this.SecondStorage = storage;
        }
    }
}
