namespace ProtoMine.View
{
    partial class Item
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lbNivel = new System.Windows.Forms.Label();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(100, 110);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.ovalShape1.BorderWidth = 2;
            this.ovalShape1.FillColor = System.Drawing.SystemColors.Control;
            this.ovalShape1.FillGradientColor = System.Drawing.Color.Transparent;
            this.ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape1.Location = new System.Drawing.Point(59, 70);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(38, 38);
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.BackColor = System.Drawing.Color.Transparent;
            this.lbNivel.Font = new System.Drawing.Font("Lucida Console", 14.25F);
            this.lbNivel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNivel.Location = new System.Drawing.Point(3, 86);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(53, 19);
            this.lbNivel.TabIndex = 2;
            this.lbNivel.Text = "Nv 1";
            // 
            // imagem
            // 
            this.imagem.Image = global::ProtoMine.Properties.Resources.minerio;
            this.imagem.Location = new System.Drawing.Point(0, 0);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(100, 80);
            this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagem.TabIndex = 0;
            this.imagem.TabStop = false;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Location = new System.Drawing.Point(66, 85);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(26, 18);
            this.lbQuantidade.TabIndex = 0;
            this.lbQuantidade.Text = "100";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(100, 110);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item";
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Label lbQuantidade;
    }
}