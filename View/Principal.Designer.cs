namespace ProtoMine.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PanelTopo = new System.Windows.Forms.Panel();
            this.lbNome = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelInferiorXp = new System.Windows.Forms.Panel();
            this.panSupXp = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBurg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foto = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panelBurg = new System.Windows.Forms.Panel();
            this.PanelTopo.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelInferiorXp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBurg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBurg.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTopo
            // 
            this.PanelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(3)))));
            this.PanelTopo.Controls.Add(this.iconBurg);
            this.PanelTopo.Controls.Add(this.panelInferiorXp);
            this.PanelTopo.Controls.Add(this.lbNome);
            this.PanelTopo.Controls.Add(this.shapeContainer1);
            this.PanelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopo.Location = new System.Drawing.Point(0, 0);
            this.PanelTopo.Name = "PanelTopo";
            this.PanelTopo.Size = new System.Drawing.Size(1280, 100);
            this.PanelTopo.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Snow;
            this.lbNome.Location = new System.Drawing.Point(116, 20);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(77, 23);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Usuário";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.foto});
            this.shapeContainer1.Size = new System.Drawing.Size(1280, 100);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.panelEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 100);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(400, 620);
            this.panelEsquerdo.TabIndex = 1;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.panelPrincipal.Controls.Add(this.panelBurg);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.label2);
            this.panelPrincipal.Location = new System.Drawing.Point(400, 100);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(880, 500);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelInferiorXp
            // 
            this.panelInferiorXp.BackColor = System.Drawing.SystemColors.Control;
            this.panelInferiorXp.Controls.Add(this.panSupXp);
            this.panelInferiorXp.Location = new System.Drawing.Point(120, 46);
            this.panelInferiorXp.Name = "panelInferiorXp";
            this.panelInferiorXp.Size = new System.Drawing.Size(200, 30);
            this.panelInferiorXp.TabIndex = 3;
            // 
            // panSupXp
            // 
            this.panSupXp.BackColor = System.Drawing.Color.LimeGreen;
            this.panSupXp.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSupXp.Location = new System.Drawing.Point(0, 0);
            this.panSupXp.Name = "panSupXp";
            this.panSupXp.Size = new System.Drawing.Size(10, 30);
            this.panSupXp.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dx assim até se necessário mexer nela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "fica mais fácil de configurar a principal se precisar";
            // 
            // iconBurg
            // 
            this.iconBurg.Image = global::ProtoMine.Properties.Resources.lines_menu_burger_icon_123889;
            this.iconBurg.Location = new System.Drawing.Point(1208, 26);
            this.iconBurg.Name = "iconBurg";
            this.iconBurg.Size = new System.Drawing.Size(50, 50);
            this.iconBurg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBurg.TabIndex = 4;
            this.iconBurg.TabStop = false;
            this.iconBurg.Click += new System.EventHandler(this.mostarMenu);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProtoMine.Properties.Resources.ic_cancel_97589;
            this.pictureBox1.Location = new System.Drawing.Point(115, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnClickSair);
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.Color.White;
            this.foto.BackgroundImage = global::ProtoMine.Properties.Resources.jones;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.foto.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.foto.BorderColor = System.Drawing.Color.Snow;
            this.foto.BorderWidth = 4;
            this.foto.Location = new System.Drawing.Point(20, 13);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(75, 75);
            // 
            // panelBurg
            // 
            this.panelBurg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(3)))));
            this.panelBurg.Controls.Add(this.pictureBox1);
            this.panelBurg.Location = new System.Drawing.Point(616, 0);
            this.panelBurg.Name = "panelBurg";
            this.panelBurg.Size = new System.Drawing.Size(264, 293);
            this.panelBurg.TabIndex = 3;
            this.panelBurg.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.PanelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.PanelTopo.ResumeLayout(false);
            this.PanelTopo.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelInferiorXp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBurg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBurg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopo;
        private System.Windows.Forms.Panel panelEsquerdo;
        private System.Windows.Forms.Panel panelPrincipal;
        private Microsoft.VisualBasic.PowerPacks.OvalShape foto;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel panelInferiorXp;
        private System.Windows.Forms.Panel panSupXp;
        private System.Windows.Forms.PictureBox iconBurg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBurg;
    }
}