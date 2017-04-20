using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class MultimediaComputer:Computer
    {
        public string soundcard;

        public MultimediaComputer(string box, string DDR, string memory, string motherboard, string processor, string videocard, string type, string sound):base(box,DDR,memory,motherboard,processor,videocard,type)
        {
            this.soundcard = sound;
        }
    }

}
