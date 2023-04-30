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
            this.openFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.TREE = new System.Windows.Forms.TreeView();
            this.TB_Trans_X = new System.Windows.Forms.TrackBar();
            this.T_X = new System.Windows.Forms.Label();
            this.TB_Trans_Y = new System.Windows.Forms.TrackBar();
            this.T_Y = new System.Windows.Forms.Label();
            this.T_Z = new System.Windows.Forms.Label();
            this.TB_Trans_Z = new System.Windows.Forms.TrackBar();
            this.CB_ROTATE = new System.Windows.Forms.CheckBox();
            this.CB_TRANSLATE = new System.Windows.Forms.CheckBox();
            this.CB_SCALE = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PCT_CANVAS.Location = new System.Drawing.Point(12, 82);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1022, 591);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.BackColor = System.Drawing.Color.Maroon;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXE.ForeColor = System.Drawing.Color.Silver;
            this.BTN_EXE.Location = new System.Drawing.Point(1228, 345);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(126, 33);
            this.BTN_EXE.TabIndex = 1;
            this.BTN_EXE.Text = "Animate";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 60;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(1073, 22);
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
            this.button1.Location = new System.Drawing.Point(1228, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TREE
            // 
            this.TREE.Location = new System.Drawing.Point(1219, 22);
            this.TREE.Name = "TREE";
            this.TREE.Size = new System.Drawing.Size(171, 193);
            this.TREE.TabIndex = 20;
            this.TREE.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_AfterSelect);
            // 
            // TB_Trans_X
            // 
            this.TB_Trans_X.Location = new System.Drawing.Point(12, 725);
            this.TB_Trans_X.Minimum = -10;
            this.TB_Trans_X.Name = "TB_Trans_X";
            this.TB_Trans_X.Size = new System.Drawing.Size(1037, 45);
            this.TB_Trans_X.TabIndex = 21;
            this.TB_Trans_X.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // T_X
            // 
            this.T_X.AutoSize = true;
            this.T_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_X.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.T_X.Location = new System.Drawing.Point(452, 697);
            this.T_X.Name = "T_X";
            this.T_X.Size = new System.Drawing.Size(167, 25);
            this.T_X.TabIndex = 22;
            this.T_X.Text = "Transformación X";
            // 
            // TB_Trans_Y
            // 
            this.TB_Trans_Y.Location = new System.Drawing.Point(1055, 82);
            this.TB_Trans_Y.Minimum = -10;
            this.TB_Trans_Y.Name = "TB_Trans_Y";
            this.TB_Trans_Y.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TB_Trans_Y.Size = new System.Drawing.Size(45, 605);
            this.TB_Trans_Y.TabIndex = 23;
            this.TB_Trans_Y.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // T_Y
            // 
            this.T_Y.AutoSize = true;
            this.T_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Y.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.T_Y.Location = new System.Drawing.Point(1106, 426);
            this.T_Y.Name = "T_Y";
            this.T_Y.Size = new System.Drawing.Size(166, 25);
            this.T_Y.TabIndex = 24;
            this.T_Y.Text = "Transformación Y";
            // 
            // T_Z
            // 
            this.T_Z.AutoSize = true;
            this.T_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Z.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.T_Z.Location = new System.Drawing.Point(429, 54);
            this.T_Z.Name = "T_Z";
            this.T_Z.Size = new System.Drawing.Size(165, 25);
            this.T_Z.TabIndex = 26;
            this.T_Z.Text = "Transformación Z";
            this.T_Z.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Trans_Z
            // 
            this.TB_Trans_Z.Location = new System.Drawing.Point(-3, 12);
            this.TB_Trans_Z.Minimum = -10;
            this.TB_Trans_Z.Name = "TB_Trans_Z";
            this.TB_Trans_Z.Size = new System.Drawing.Size(1037, 45);
            this.TB_Trans_Z.TabIndex = 25;
            this.TB_Trans_Z.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // CB_ROTATE
            // 
            this.CB_ROTATE.AutoSize = true;
            this.CB_ROTATE.ForeColor = System.Drawing.Color.White;
            this.CB_ROTATE.Location = new System.Drawing.Point(1228, 250);
            this.CB_ROTATE.Name = "CB_ROTATE";
            this.CB_ROTATE.Size = new System.Drawing.Size(58, 17);
            this.CB_ROTATE.TabIndex = 27;
            this.CB_ROTATE.Text = "Rotate";
            this.CB_ROTATE.UseVisualStyleBackColor = true;
            this.CB_ROTATE.CheckedChanged += new System.EventHandler(this.CB_ROTATE_CheckedChanged);
            // 
            // CB_TRANSLATE
            // 
            this.CB_TRANSLATE.AutoSize = true;
            this.CB_TRANSLATE.ForeColor = System.Drawing.Color.White;
            this.CB_TRANSLATE.Location = new System.Drawing.Point(1228, 273);
            this.CB_TRANSLATE.Name = "CB_TRANSLATE";
            this.CB_TRANSLATE.Size = new System.Drawing.Size(70, 17);
            this.CB_TRANSLATE.TabIndex = 28;
            this.CB_TRANSLATE.Text = "Translate";
            this.CB_TRANSLATE.UseVisualStyleBackColor = true;
            this.CB_TRANSLATE.CheckedChanged += new System.EventHandler(this.CB_TRANSLATE_CheckedChanged);
            // 
            // CB_SCALE
            // 
            this.CB_SCALE.AutoSize = true;
            this.CB_SCALE.ForeColor = System.Drawing.Color.White;
            this.CB_SCALE.Location = new System.Drawing.Point(1228, 296);
            this.CB_SCALE.Name = "CB_SCALE";
            this.CB_SCALE.Size = new System.Drawing.Size(53, 17);
            this.CB_SCALE.TabIndex = 29;
            this.CB_SCALE.Text = "Scale";
            this.CB_SCALE.UseVisualStyleBackColor = true;
            this.CB_SCALE.CheckedChanged += new System.EventHandler(this.CB_SCALE_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(493, 766);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tiempo";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 794);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1037, 45);
            this.trackBar1.TabIndex = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1402, 887);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.CB_SCALE);
            this.Controls.Add(this.CB_TRANSLATE);
            this.Controls.Add(this.CB_ROTATE);
            this.Controls.Add(this.T_Z);
            this.Controls.Add(this.TB_Trans_Z);
            this.Controls.Add(this.T_Y);
            this.Controls.Add(this.TB_Trans_Y);
            this.Controls.Add(this.T_X);
            this.Controls.Add(this.TB_Trans_X);
            this.Controls.Add(this.TREE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.BTN_EXE);
            this.Controls.Add(this.PCT_CANVAS);
            this.Name = "MAIN_FORM";
            this.Text = "DEMO";
            this.Load += new System.EventHandler(this.MAIN_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Trans_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView TREE;
        private System.Windows.Forms.TrackBar TB_Trans_X;
        private System.Windows.Forms.Label T_X;
        private System.Windows.Forms.TrackBar TB_Trans_Y;
        private System.Windows.Forms.Label T_Y;
        private System.Windows.Forms.Label T_Z;
        private System.Windows.Forms.TrackBar TB_Trans_Z;
        private System.Windows.Forms.CheckBox CB_ROTATE;
        private System.Windows.Forms.CheckBox CB_TRANSLATE;
        private System.Windows.Forms.CheckBox CB_SCALE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

