namespace LIVE_DEMO
{
    partial class MAIN_FORM
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.BTN_EXE = new System.Windows.Forms.Button();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.Translate = new System.Windows.Forms.Button();
            this.Rotate = new System.Windows.Forms.Button();
            this.Scale = new System.Windows.Forms.Button();
            this.rotationXUpDown = new System.Windows.Forms.NumericUpDown();
            this.translationX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.translationY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.translationZ = new System.Windows.Forms.TextBox();
            this.scalation = new System.Windows.Forms.TextBox();
            this.rotationYUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotationZUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationZUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCT_CANVAS.Location = new System.Drawing.Point(12, 91);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1003, 500);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.SizeChanged += new System.EventHandler(this.PCT_CANVAS_SizeChanged);
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.BackColor = System.Drawing.Color.Maroon;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXE.ForeColor = System.Drawing.Color.Silver;
            this.BTN_EXE.Location = new System.Drawing.Point(12, 12);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(126, 33);
            this.BTN_EXE.TabIndex = 1;
            this.BTN_EXE.Text = "EXE";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 60;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(144, 28);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(76, 23);
            this.Translate.TabIndex = 2;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(374, 28);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(75, 23);
            this.Rotate.TabIndex = 3;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // Scale
            // 
            this.Scale.Location = new System.Drawing.Point(612, 28);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(75, 23);
            this.Scale.TabIndex = 4;
            this.Scale.Text = "Scale";
            this.Scale.UseVisualStyleBackColor = true;
            this.Scale.Click += new System.EventHandler(this.Scale_Click);
            // 
            // rotationXUpDown
            // 
            this.rotationXUpDown.Location = new System.Drawing.Point(479, 12);
            this.rotationXUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationXUpDown.Name = "rotationXUpDown";
            this.rotationXUpDown.Size = new System.Drawing.Size(120, 20);
            this.rotationXUpDown.TabIndex = 5;
            // 
            // translationX
            // 
            this.translationX.Location = new System.Drawing.Point(255, 15);
            this.translationX.Name = "translationX";
            this.translationX.Size = new System.Drawing.Size(100, 20);
            this.translationX.TabIndex = 6;
            this.translationX.TextChanged += new System.EventHandler(this.translationX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(226, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(226, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y :";
            // 
            // translationY
            // 
            this.translationY.Location = new System.Drawing.Point(255, 41);
            this.translationY.Name = "translationY";
            this.translationY.Size = new System.Drawing.Size(100, 20);
            this.translationY.TabIndex = 8;
            this.translationY.TextChanged += new System.EventHandler(this.translationY_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(226, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Z :";
            // 
            // translationZ
            // 
            this.translationZ.Location = new System.Drawing.Point(255, 65);
            this.translationZ.Name = "translationZ";
            this.translationZ.Size = new System.Drawing.Size(100, 20);
            this.translationZ.TabIndex = 10;
            this.translationZ.TextChanged += new System.EventHandler(this.translationZ_TextChanged);
            // 
            // scalation
            // 
            this.scalation.Location = new System.Drawing.Point(693, 28);
            this.scalation.Name = "scalation";
            this.scalation.Size = new System.Drawing.Size(100, 20);
            this.scalation.TabIndex = 12;
            // 
            // rotationYUpDown
            // 
            this.rotationYUpDown.Location = new System.Drawing.Point(479, 41);
            this.rotationYUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationYUpDown.Name = "rotationYUpDown";
            this.rotationYUpDown.Size = new System.Drawing.Size(120, 20);
            this.rotationYUpDown.TabIndex = 13;
            // 
            // rotationZUpDown
            // 
            this.rotationZUpDown.Location = new System.Drawing.Point(479, 68);
            this.rotationZUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotationZUpDown.Name = "rotationZUpDown";
            this.rotationZUpDown.Size = new System.Drawing.Size(120, 20);
            this.rotationZUpDown.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(453, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Z :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(453, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(453, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "X :";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(810, 28);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 18;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos OBJ|*.obj";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(910, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1027, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rotationZUpDown);
            this.Controls.Add(this.rotationYUpDown);
            this.Controls.Add(this.scalation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.translationZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.translationY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translationX);
            this.Controls.Add(this.rotationXUpDown);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.BTN_EXE);
            this.Controls.Add(this.PCT_CANVAS);
            this.Name = "MAIN_FORM";
            this.Text = "DEMO";
            this.Load += new System.EventHandler(this.MAIN_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationZUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Button Scale;
        private System.Windows.Forms.NumericUpDown rotationXUpDown;
        private System.Windows.Forms.TextBox translationX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox translationY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox translationZ;
        private System.Windows.Forms.TextBox scalation;
        private System.Windows.Forms.NumericUpDown rotationYUpDown;
        private System.Windows.Forms.NumericUpDown rotationZUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

