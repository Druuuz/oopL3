using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]

    public class Computer
    {
        public string videocard;
        public string processor;
        public string DDR;
        public string memory;
        public string motherboard;
        public string box;
        public string type;
        public string add;

        public Computer(string box, string DDR, string memory, string motherboard, string processor, string videocard,string type)
        {
            this.videocard = videocard;
            this.processor = processor;
            this.DDR = DDR;
            this.memory = memory;
            this.motherboard = motherboard;
            this.box = box;
            this.type = type;
            
        }
    }
}
