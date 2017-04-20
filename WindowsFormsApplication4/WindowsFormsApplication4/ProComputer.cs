using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class ProComputer:Computer
    {
        public string secondDDR_Video;

        public ProComputer(string box, string DDR, string memory, string motherboard, string processor, string videocard, string type, string sDDR_video):base(box,DDR,memory,motherboard,processor,videocard,type)
        {
            this.secondDDR_Video = sDDR_video;
        }
    }
}
