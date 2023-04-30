using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIVE_DEMO
{
    public class Transformation
    {
        public Vertex translation;
        public Vertex angle;
        public float scale;
        public int time;

        public Transformation(Vertex translation, Vertex angle, float scale, int time)
        {
            this.translation = translation;
            this.angle = angle;
            this.scale = scale;
            this.time = time;
        }
    }
}
