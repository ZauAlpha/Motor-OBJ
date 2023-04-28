using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LIVE_DEMO
{
    public partial class MAIN_FORM : Form
    {
        Rasterization raster;
        Random random;
        public MAIN_FORM()
        {
            InitializeComponent();
        }
                    
        private void BTN_EXE_Click(object sender, EventArgs e)
        {
            raster.Scales(0.5f);
        }

        private void Init()
        {
            

        }


        private void PCT_CANVAS_SizeChanged(object sender, EventArgs e)
        {
            if(raster != null)
                raster.Resize(PCT_CANVAS.Size);
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            if (raster == null)
                return;
            raster.Render();
            PCT_CANVAS.Invalidate();

        }

        private void MAIN_FORM_Load(object sender, EventArgs e)
        {
            Init();
            random = new Random();
        }

      

        private void Translate_Click(object sender, EventArgs e)
        {
            if (raster == null)
                return;
            if (translationY.Text.Length == 0)
                translationY.Text = "0";
            if (translationX.Text.Length == 0)
                translationX.Text = "0";
            if (translationZ.Text.Length == 0)
                translationZ.Text = "0";
            float x = float.Parse(translationX.Text);
            float y = float.Parse(translationY.Text);
            float z = float.Parse(translationZ.Text);
            raster.Translate(new Vertex(x, y, z));
            
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            if (raster == null)
                return;
            float scale = float.Parse(scalation.Text);
            raster.Scales(scale);
            
        }
        private String formatTranslation(String text)
        {
            return new string(text.Where(c => char.IsDigit(c) || c == '.' || c == '-').ToArray());
        }

        private void translationX_TextChanged(object sender, EventArgs e)
        {
            translationX.Text=formatTranslation(translationX.Text);
        }

        private void translationY_TextChanged(object sender, EventArgs e)
        {
            translationY.Text=formatTranslation(translationY.Text);
        }

        private void translationZ_TextChanged(object sender, EventArgs e)
        {
            translationZ.Text=formatTranslation(translationZ.Text);
        }

        private void Rotate_Click(object sender, EventArgs e)
        {
            if (raster == null)
                return;
            float x = (float)rotationXUpDown.Value;
            float y = (float)rotationYUpDown.Value;
            float z = (float)rotationZUpDown.Value;

            raster.Rotate(new Vertex(x, y, z));
            

        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                string filePath = openFileDialog1.FileName;
                List<Vertex> vertexes = new List<Vertex>();
                List<Triangle> triangles = new List<Triangle>();
                StreamReader streamReader = new StreamReader(filePath);
                //String[] lines = streamReader.ReadToEnd().Split('\n');
                using (streamReader) {
                    string line;
                    while((line = streamReader.ReadLine()) != null)
                    {
                        List<int> indexes = new List<int>();
                        if (line.StartsWith("v "))
                        {
                            string[] tokens = line.Split(' ');
                            float x = float.Parse(tokens[1]);
                            float y = float.Parse(tokens[2]);
                            float z = float.Parse(tokens[3]);
                            Vertex ver = new Vertex(x, y, z);
                            vertexes.Add(ver);
                            
                        }
                        else if (line.StartsWith("f "))
                        {
                            
                            string[] aux = line.Split(' ');
                            for(int i=1; i<aux.Length; i++)
                            {
                                indexes.Add(int.Parse(aux[i].Split('/')[0])-1);
                            }
                            Triangle triangle = new Triangle(indexes[0], indexes[1], indexes[2],GetRandomColor());
                            
                            triangles.Add(triangle);
                            
                        }
                    }
                }
                if(raster == null)
                {
                    raster = new Rasterization(PCT_CANVAS.Size, vertexes, triangles);
                    PCT_CANVAS.Image = raster.Canvas;
                }
                else
                {
                    raster.AddModel(vertexes, triangles);
                }
            }
        }
        
        
            

            public Color GetRandomColor()
            {
            
                 int randomNumber = random.Next(0, 8);

                switch (randomNumber)
                {
                    case 0:
                        return Color.Red;
                    case 1:
                        return Color.Green;
                    case 2:
                        return Color.Blue;
                    case 3:
                        return Color.Yellow;
                    case 4:
                        return Color.Magenta;
                    case 5:
                        return Color.Orange;
                    case 6:
                        return Color.Black;
                    case 7:
                        return Color.Brown;
                    default:
                        throw new InvalidOperationException("Unexpected random number.");
                }
            }
        
        public static void PrintArray(string[] array)
        {
            Console.WriteLine();
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write(" ]");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raster.ShowZBuffer();
        }
    }
}
