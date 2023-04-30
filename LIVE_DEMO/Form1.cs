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
        bool rotate;
        int modelIndex;
        int transform;
        bool animate;
        
        public MAIN_FORM()
        {
            InitializeComponent();
        }
                    
        private void BTN_EXE_Click(object sender, EventArgs e)
        {
            animate = !animate;
        }

        private void Init()
        {
            

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
            transform = 0;
            animate = false;
        }
        private String formatTranslation(String text)
        {
            return new string(text.Where(c => char.IsDigit(c) || c == '.' || c == '-').ToArray());
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
                    TreeNode node = new TreeNode(GetFileName(filePath));
                    node.Tag = 0;
                    modelIndex = 0;
                    TREE.Nodes.Add(node);
                }
                else
                {
                    TreeNode node = new TreeNode(GetFileName(filePath));
                    node.Tag = raster.AddModel(vertexes, triangles);
                    modelIndex = (int)node.Tag;
                    TREE.Nodes.Add(node);
                    
                    
                }
            }
        }

        public string GetFileName(string filePath)
        {
            int lastSlashIndex = filePath.LastIndexOf('\\');
            int lastBackslashIndex = filePath.LastIndexOf('/');

            int lastIndex = Math.Max(lastSlashIndex, lastBackslashIndex);

            if (lastIndex == -1)
            {
                return filePath;
            }
            else
            {
                return filePath.Substring(lastIndex + 1);
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
            rotate = !rotate;
        }

        private void TREE_AfterSelect(object sender, TreeViewEventArgs e)
        {
            modelIndex = (int)TREE.SelectedNode.Tag;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(raster != null) {
                Vertex t = new Vertex(TB_Trans_X.Value, TB_Trans_Y.Value, TB_Trans_Z.Value);
                switch (transform)
                {
                    case 1:
                        raster.Rotate(t, modelIndex);
                        break;
                    case 2:
                        raster.Translate(t, modelIndex);
                        break;
                    case 3:
                        float value = ((float)TB_Trans_X.Value) / 100;
                        raster.Scales(value, modelIndex);
                        Console.WriteLine("Escalado : " + value + " | "+TB_Trans_X.Value);
                        break;
                    default: 
                        break;
                }
            }
              
        }

        private void CB_ROTATE_CheckedChanged(object sender, EventArgs e)
        {
            
            CB_SCALE.Checked = false;
            CB_TRANSLATE.Checked = false;
            int maximum = 360;
            int minimum = 0;
            int value = 0;
            TB_Trans_X.Maximum = maximum;
            TB_Trans_Y.Maximum = maximum;
            TB_Trans_Z.Maximum = maximum;
            TB_Trans_X.Minimum = minimum;
            TB_Trans_Y.Minimum = minimum;
            TB_Trans_Z.Minimum = minimum;
            TB_Trans_X.Value = value;
            TB_Trans_Y.Value = value;
            TB_Trans_Z.Value = value;
            TB_Trans_Y.Visible = true;
            TB_Trans_Z.Visible = true;
            transform = 1;
            T_X.Text = "Rotación en X";
            T_Y.Text = "Rotación en Y";
            T_Z.Text = "Rotación en Z";

        }

        private void CB_TRANSLATE_CheckedChanged(object sender, EventArgs e)
        {
            CB_ROTATE.Checked = false;
            CB_SCALE.Checked = false;
            int maximum = 10;
            int minimum = -10;
            int value = 0;
            TB_Trans_X.Maximum = maximum;
            TB_Trans_Y.Maximum = maximum;
            TB_Trans_Z.Maximum = maximum;
            TB_Trans_X.Minimum = minimum;
            TB_Trans_Y.Minimum = minimum;
            TB_Trans_Z.Minimum = minimum;
            TB_Trans_X.Value = value;
            TB_Trans_Y.Value = value;
            TB_Trans_Z.Value = value;
            TB_Trans_Y.Visible = true;
            TB_Trans_Z.Visible = true;
            transform = 2;
            T_X.Text = "Traslación en X";
            T_Y.Text = "Traslación en Y";
            T_Z.Text = "Traslación en Z";
        }

        private void CB_SCALE_CheckedChanged(object sender, EventArgs e)
        {
            CB_ROTATE.Checked = false;
            TB_Trans_Y.Visible = false;
            TB_Trans_Z.Visible = false;
            CB_TRANSLATE.Checked = false;
            TB_Trans_X.Maximum = 200;
            TB_Trans_X.Minimum = 0;
            TB_Trans_X.Value = 100;
            transform = 3;
            T_X.Text = "Escalado ";
            T_Y.Text = "";
            T_Z.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            label1.Text = "Tiempo : " + ConvertirMilisegundosAString(trackBar1.Value * TIMER.Interval);
        }
        public static string ConvertirMilisegundosAString(long milisegundos)
        {
            int segundos = (int)(milisegundos / 1000); // Convierte a segundos
            
            segundos = segundos % 60; // Obtiene los segundos restantes
            int milisegRestantes = (int)(milisegundos % 1000); // Obtiene los milisegundos restantes

            string resultado =  segundos.ToString() + " segundos y " + milisegRestantes.ToString() + " milisegundos";

            return resultado;
        }
    }
}
