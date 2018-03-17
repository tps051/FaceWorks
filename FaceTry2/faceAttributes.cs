using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceTry2
{
    class faceAttributes
    {
        public double age { get; set; }
        public string gender { get; set; }
        public double smile { get; set; }
        public HeadPose headPose { get; set; }
        public FacialHair facialHair { get; set; }
        public string glasses { get; set; }
        public Emotion emotion { get; set; }
        public Blur blur { get; set; }
        public Exposure exposure { get; set; }
        public Noise noise { get; set; }
        public MakeUp makeup { get; set; }
        //accessories [json] kak??
        public Occlusion occlusion { get; set; }
        public Hair hair { get; set; }
    }
}
