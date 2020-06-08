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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.labNome = new System.Windows.Forms.Label();
            this.labQuant = new System.Windows.Forms.Label();
            this.picImgItem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labPeso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labNome
            // 
            this.labNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labNome.BackColor = System.Drawing.SystemColors.Control;
            this.labNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNome.Location = new System.Drawing.Point(10, 9);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(90, 19);
            this.labNome.TabIndex = 1;
            this.labNome.Text = "Ferro";
            this.labNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labQuant
            // 
            this.labQuant.AutoSize = true;
            this.labQuant.BackColor = System.Drawing.Color.White;
            this.labQuant.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuant.Location = new System.Drawing.Point(65, 105);
            this.labQuant.Name = "labQuant";
            this.labQuant.Size = new System.Drawing.Size(36, 19);
            this.labQuant.TabIndex = 2;
            this.labQuant.Text = "999";
            // 
            // picImgItem
            // 
            this.picImgItem.BackColor = System.Drawing.Color.Transparent;
            this.picImgItem.Image = ((System.Drawing.Image)(resources.GetObject("picImgItem.Image")));
            this.picImgItem.Location = new System.Drawing.Point(10, 11);
            this.picImgItem.Name = "picImgItem";
            this.picImgItem.Size = new System.Drawing.Size(90, 80);
            this.picImgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImgItem.TabIndex = 3;
            this.picImgItem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labPeso
            // 
            this.labPeso.AutoSize = true;
            this.labPeso.BackColor = System.Drawing.Color.White;
            this.labPeso.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPeso.Location = new System.Drawing.Point(9, 105);
            this.labPeso.Name = "labPeso";
            this.labPeso.Size = new System.Drawing.Size(28, 18);
            this.labPeso.TabIndex = 4;
            this.labPeso.Text = "0.5";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(110, 130);
            this.Controls.Add(this.labPeso);
            this.Controls.Add(this.labNome);
            this.Controls.Add(this.picImgItem);
            this.Controls.Add(this.labQuant);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item";
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.picImgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labQuant;
        private System.Windows.Forms.PictureBox picImgItem;
        private System.Windows.Forms.Label labPeso;
    }
}