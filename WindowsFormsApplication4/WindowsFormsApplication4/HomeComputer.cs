using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class HomeComputer:Computer
    {
        public string Drive;

        public HomeComputer(string box, string DDR, string memory, string motherboard, string processor, string videocard, string type, string drive):base(box,DDR,memory,motherboard,processor,videocard,type)
        {
            this.Drive = drive;
        }
    }
}
