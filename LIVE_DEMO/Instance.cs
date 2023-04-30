using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIVE_DEMO
{
    public class Instance
    {
        public Model model;
        public List<Transformation> transformations;
        public Vertex position;
        public Mtx orientation;
        public float scale;
        public Mtx transform;
        public Vertex translation;
        public Vertex angle;

        public Instance(Model model, Vertex position, Mtx orientation = null, float scale = 1.0f)
        {
            this.model          = model;
            this.position       = position;
            this.orientation    = orientation ?? Mtx.Identity;
            this.scale          = scale;
            this.translation = new Vertex(0, 0, 0);
            this.transform = Mtx.MakeTranslationMatrix(this.position)* this.orientation * Mtx.MakeScalingMatrix(this.scale);
            this.angle= new Vertex(0, 0, 0);
            this.transformations = new List<Transformation>();
        }
        public void SaveTransformations(int time)
        {
            transformations.Add(new Transformation(translation,angle,scale,time));
        }
        public Transformation FindTransformation(int time)
        {
            for(int i = 0; i < transformations.Count; i++)
            {
                if (transformations[i].time == time)
                    return transformations[i];
            }
            return null;
        }
    }
}
