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
            this.iconBurg = new System.Windows.Forms.PictureBox();
            this.panelInferiorXp = new System.Windows.Forms.Panel();
            this.panSupXp = new System.Windows.Forms.Panel();
            this.lbNome = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.foto = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelBurg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.btnMinerar = new System.Windows.Forms.Button();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.PanelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBurg)).BeginInit();
            this.panelInferiorXp.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelBurg.SuspendLayout();
            this.pnAdmin.SuspendLayout();
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
            // iconBurg
            // 
            this.iconBurg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBurg.Image = global::ProtoMine.Properties.Resources.lines_menu_burger_icon_123889;
            this.iconBurg.Location = new System.Drawing.Point(1210, 30);
            this.iconBurg.Name = "iconBurg";
            this.iconBurg.Size = new System.Drawing.Size(40, 40);
            this.iconBurg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBurg.TabIndex = 4;
            this.iconBurg.TabStop = false;
            this.iconBurg.Click += new System.EventHandler(this.mostarMenu);
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
            this.panelPrincipal.Controls.Add(this.pnAdmin);
            this.panelPrincipal.Controls.Add(this.panelBurg);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.label2);
            this.panelPrincipal.Location = new System.Drawing.Point(400, 100);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(880, 500);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelBurg
            // 
            this.panelBurg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(3)))));
            this.panelBurg.Controls.Add(this.btnMinerar);
            this.panelBurg.Controls.Add(this.btnLoja);
            this.panelBurg.Controls.Add(this.btnDesconectar);
            this.panelBurg.Controls.Add(this.btnFechar);
            this.panelBurg.Controls.Add(this.shapeContainer2);
            this.panelBurg.Location = new System.Drawing.Point(620, 0);
            this.panelBurg.Name = "panelBurg";
            this.panelBurg.Size = new System.Drawing.Size(260, 242);
            this.panelBurg.TabIndex = 3;
            this.panelBurg.Visible = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dx assim até se necessário mexer nela";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(260, 242);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 260;
            this.lineShape1.Y1 = 60;
            this.lineShape1.Y2 = 60;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 260;
            this.lineShape2.Y1 = 1;
            this.lineShape2.Y2 = 1;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 0;
            this.lineShape3.X2 = 260;
            this.lineShape3.Y1 = 120;
            this.lineShape3.Y2 = 120;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape4.Enabled = false;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 0;
            this.lineShape4.X2 = 260;
            this.lineShape4.Y1 = 180;
            this.lineShape4.Y2 = 180;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 0;
            this.lineShape5.X2 = 260;
            this.lineShape5.Y1 = 241;
            this.lineShape5.Y2 = 241;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.Location = new System.Drawing.Point(1, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(257, 57);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFechar.Location = new System.Drawing.Point(1, 182);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(257, 57);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.FecharAplicacao);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDesconectar.Location = new System.Drawing.Point(1, 122);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(257, 57);
            this.btnDesconectar.TabIndex = 5;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // btnLoja
            // 
            this.btnLoja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoja.FlatAppearance.BorderSize = 0;
            this.btnLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoja.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoja.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoja.Location = new System.Drawing.Point(1, 62);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(257, 57);
            this.btnLoja.TabIndex = 6;
            this.btnLoja.Text = "Loja";
            this.btnLoja.UseVisualStyleBackColor = true;
            // 
            // btnMinerar
            // 
            this.btnMinerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinerar.FlatAppearance.BorderSize = 0;
            this.btnMinerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinerar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinerar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinerar.Location = new System.Drawing.Point(1, 2);
            this.btnMinerar.Name = "btnMinerar";
            this.btnMinerar.Size = new System.Drawing.Size(257, 57);
            this.btnMinerar.TabIndex = 7;
            this.btnMinerar.Text = "Minerar";
            this.btnMinerar.UseVisualStyleBackColor = true;
            // 
            // pnAdmin
            // 
            this.pnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(3)))));
            this.pnAdmin.Controls.Add(this.btnAdmin);
            this.pnAdmin.Location = new System.Drawing.Point(620, 242);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(260, 61);
            this.pnAdmin.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.iconBurg)).EndInit();
            this.panelInferiorXp.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panelBurg.ResumeLayout(false);
            this.pnAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopo;
        private System.Windows.Forms.Panel panelEsquerdo;
        private System.Windows.Forms.Panel panelPrincipal;
        private Microsoft.VisualBasic.PowerPacks.OvalShape foto;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel panelInferiorXp;
        private System.Windows.Forms.Panel panSupXp;
        private System.Windows.Forms.PictureBox iconBurg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBurg;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnMinerar;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnAdmin;
    }
}