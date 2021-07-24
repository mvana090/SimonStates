namespace simongame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbtl = new System.Windows.Forms.PictureBox();
            this.pbbr = new System.Windows.Forms.PictureBox();
            this.pbbl = new System.Windows.Forms.PictureBox();
            this.pbtr = new System.Windows.Forms.PictureBox();
            this.bstart = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.pbClick = new System.Windows.Forms.PictureBox();
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.lclicks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClick)).BeginInit();
            this.SuspendLayout();
            // 
            // pbtl
            // 
            this.pbtl.BackColor = System.Drawing.Color.Gold;
            this.pbtl.Location = new System.Drawing.Point(31, 26);
            this.pbtl.Name = "pbtl";
            this.pbtl.Size = new System.Drawing.Size(199, 171);
            this.pbtl.TabIndex = 0;
            this.pbtl.TabStop = false;
            this.pbtl.Click += new System.EventHandler(this.pbtl_Click);
            // 
            // pbbr
            // 
            this.pbbr.BackColor = System.Drawing.Color.YellowGreen;
            this.pbbr.Location = new System.Drawing.Point(263, 228);
            this.pbbr.Name = "pbbr";
            this.pbbr.Size = new System.Drawing.Size(199, 171);
            this.pbbr.TabIndex = 1;
            this.pbbr.TabStop = false;
            this.pbbr.Click += new System.EventHandler(this.pbbr_Click);
            // 
            // pbbl
            // 
            this.pbbl.BackColor = System.Drawing.Color.DarkRed;
            this.pbbl.Location = new System.Drawing.Point(31, 228);
            this.pbbl.Name = "pbbl";
            this.pbbl.Size = new System.Drawing.Size(199, 171);
            this.pbbl.TabIndex = 2;
            this.pbbl.TabStop = false;
            this.pbbl.Click += new System.EventHandler(this.pbbl_Click);
            // 
            // pbtr
            // 
            this.pbtr.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbtr.Location = new System.Drawing.Point(263, 26);
            this.pbtr.Name = "pbtr";
            this.pbtr.Size = new System.Drawing.Size(199, 171);
            this.pbtr.TabIndex = 3;
            this.pbtr.TabStop = false;
            this.pbtr.Click += new System.EventHandler(this.pbtr_Click);
            // 
            // bstart
            // 
            this.bstart.Location = new System.Drawing.Point(13, 4);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(75, 23);
            this.bstart.TabIndex = 4;
            this.bstart.Text = "Start";
            this.bstart.UseVisualStyleBackColor = true;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // pbClick
            // 
            this.pbClick.BackColor = System.Drawing.Color.White;
            this.pbClick.Location = new System.Drawing.Point(440, 428);
            this.pbClick.Name = "pbClick";
            this.pbClick.Size = new System.Drawing.Size(199, 171);
            this.pbClick.TabIndex = 5;
            this.pbClick.TabStop = false;
            this.pbClick.Visible = false;
            // 
            // t2
            // 
            this.t2.Interval = 200;
            this.t2.Tick += new System.EventHandler(this.t2_Tick);
            // 
            // lclicks
            // 
            this.lclicks.AutoSize = true;
            this.lclicks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lclicks.Location = new System.Drawing.Point(236, 206);
            this.lclicks.Name = "lclicks";
            this.lclicks.Size = new System.Drawing.Size(13, 13);
            this.lclicks.TabIndex = 6;
            this.lclicks.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.lclicks);
            this.Controls.Add(this.pbClick);
            this.Controls.Add(this.bstart);
            this.Controls.Add(this.pbtr);
            this.Controls.Add(this.pbbl);
            this.Controls.Add(this.pbbr);
            this.Controls.Add(this.pbtl);
            this.Name = "Form1";
            this.Text = "Simon - Press Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbtl;
        private System.Windows.Forms.PictureBox pbbr;
        private System.Windows.Forms.PictureBox pbbl;
        private System.Windows.Forms.PictureBox pbtr;
        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.PictureBox pbClick;
        private System.Windows.Forms.Timer t2;
        private System.Windows.Forms.Label lclicks;
    }
}

