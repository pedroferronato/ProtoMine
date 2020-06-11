namespace ProtoMine.View
{
    partial class Loja
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
            this.panelVendedor = new System.Windows.Forms.Panel();
            this.panelb3 = new System.Windows.Forms.Panel();
            this.panelb2 = new System.Windows.Forms.Panel();
            this.panelb1 = new System.Windows.Forms.Panel();
            this.panelp3 = new System.Windows.Forms.Panel();
            this.panelp2 = new System.Windows.Forms.Panel();
            this.panelp1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelVendedor
            // 
            this.panelVendedor.BackColor = System.Drawing.Color.Transparent;
            this.panelVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelVendedor.Location = new System.Drawing.Point(94, 167);
            this.panelVendedor.Name = "panelVendedor";
            this.panelVendedor.Size = new System.Drawing.Size(200, 222);
            this.panelVendedor.TabIndex = 0;
            this.panelVendedor.Click += new System.EventHandler(this.AbrirPedidos);
            // 
            // panelb3
            // 
            this.panelb3.BackColor = System.Drawing.Color.Transparent;
            this.panelb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelb3.Location = new System.Drawing.Point(333, 85);
            this.panelb3.Name = "panelb3";
            this.panelb3.Size = new System.Drawing.Size(98, 94);
            this.panelb3.TabIndex = 1;
            // 
            // panelb2
            // 
            this.panelb2.BackColor = System.Drawing.Color.Transparent;
            this.panelb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelb2.Location = new System.Drawing.Point(333, 185);
            this.panelb2.Name = "panelb2";
            this.panelb2.Size = new System.Drawing.Size(101, 93);
            this.panelb2.TabIndex = 2;
            // 
            // panelb1
            // 
            this.panelb1.BackColor = System.Drawing.Color.Transparent;
            this.panelb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelb1.Location = new System.Drawing.Point(339, 284);
            this.panelb1.Name = "panelb1";
            this.panelb1.Size = new System.Drawing.Size(95, 89);
            this.panelb1.TabIndex = 3;
            // 
            // panelp3
            // 
            this.panelp3.BackColor = System.Drawing.Color.Transparent;
            this.panelp3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelp3.Location = new System.Drawing.Point(571, 85);
            this.panelp3.Name = "panelp3";
            this.panelp3.Size = new System.Drawing.Size(92, 94);
            this.panelp3.TabIndex = 4;
            // 
            // panelp2
            // 
            this.panelp2.BackColor = System.Drawing.Color.Transparent;
            this.panelp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelp2.Location = new System.Drawing.Point(571, 185);
            this.panelp2.Name = "panelp2";
            this.panelp2.Size = new System.Drawing.Size(92, 93);
            this.panelp2.TabIndex = 5;
            // 
            // panelp1
            // 
            this.panelp1.BackColor = System.Drawing.Color.Transparent;
            this.panelp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelp1.Location = new System.Drawing.Point(571, 284);
            this.panelp1.Name = "panelp1";
            this.panelp1.Size = new System.Drawing.Size(92, 89);
            this.panelp1.TabIndex = 6;
            // 
            // Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProtoMine.Properties.Resources.Loja;
            this.ClientSize = new System.Drawing.Size(880, 620);
            this.Controls.Add(this.panelp1);
            this.Controls.Add(this.panelp2);
            this.Controls.Add(this.panelp3);
            this.Controls.Add(this.panelb1);
            this.Controls.Add(this.panelb2);
            this.Controls.Add(this.panelb3);
            this.Controls.Add(this.panelVendedor);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loja";
            this.Text = "Loja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVendedor;
        private System.Windows.Forms.Panel panelb3;
        private System.Windows.Forms.Panel panelb2;
        private System.Windows.Forms.Panel panelb1;
        private System.Windows.Forms.Panel panelp3;
        private System.Windows.Forms.Panel panelp2;
        private System.Windows.Forms.Panel panelp1;
    }
}