namespace ProtoMine.View
{
    partial class Cadastro
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
            this.txtnomeUsu = new System.Windows.Forms.TextBox();
            this.checkRole = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbConf = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnomeUsu
            // 
            this.txtnomeUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.txtnomeUsu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnomeUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeUsu.ForeColor = System.Drawing.Color.Snow;
            this.txtnomeUsu.Location = new System.Drawing.Point(30, 41);
            this.txtnomeUsu.Name = "txtnomeUsu";
            this.txtnomeUsu.Size = new System.Drawing.Size(330, 19);
            this.txtnomeUsu.TabIndex = 1;
            this.txtnomeUsu.Text = "Nome de Usuário";
            this.txtnomeUsu.Enter += new System.EventHandler(this.NomeEnter);
            this.txtnomeUsu.Leave += new System.EventHandler(this.NomeLeave);
            // 
            // checkRole
            // 
            this.checkRole.AutoSize = true;
            this.checkRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.checkRole.ForeColor = System.Drawing.Color.Snow;
            this.checkRole.Location = new System.Drawing.Point(500, 91);
            this.checkRole.Name = "checkRole";
            this.checkRole.Size = new System.Drawing.Size(131, 24);
            this.checkRole.TabIndex = 5;
            this.checkRole.Text = "Conta Admin";
            this.checkRole.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.lbLogin);
            this.groupBox1.Controls.Add(this.lbpass);
            this.groupBox1.Controls.Add(this.lbConf);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.checkRole);
            this.groupBox1.Controls.Add(this.txtlogin);
            this.groupBox1.Controls.Add(this.txtConfSenha);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtnomeUsu);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 192);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Usuário";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLogin.Location = new System.Drawing.Point(814, 44);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(16, 20);
            this.lbLogin.TabIndex = 109;
            this.lbLogin.Text = "*";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbpass.Location = new System.Drawing.Point(344, 91);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(16, 20);
            this.lbpass.TabIndex = 108;
            this.lbpass.Text = "*";
            // 
            // lbConf
            // 
            this.lbConf.AutoSize = true;
            this.lbConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbConf.Location = new System.Drawing.Point(344, 138);
            this.lbConf.Name = "lbConf";
            this.lbConf.Size = new System.Drawing.Size(16, 20);
            this.lbConf.TabIndex = 107;
            this.lbConf.Text = "*";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNome.Location = new System.Drawing.Point(344, 40);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(16, 20);
            this.lbNome.TabIndex = 105;
            this.lbNome.Text = "*";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(4)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrar.Location = new System.Drawing.Point(499, 138);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(331, 40);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtlogin.ForeColor = System.Drawing.Color.Snow;
            this.txtlogin.Location = new System.Drawing.Point(500, 42);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(330, 19);
            this.txtlogin.TabIndex = 4;
            this.txtlogin.Text = "Login";
            this.txtlogin.Enter += new System.EventHandler(this.EnterLogin);
            this.txtlogin.Leave += new System.EventHandler(this.LeaveLogin);
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtConfSenha.ForeColor = System.Drawing.Color.Snow;
            this.txtConfSenha.Location = new System.Drawing.Point(30, 145);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(330, 19);
            this.txtConfSenha.TabIndex = 3;
            this.txtConfSenha.Text = "Confirme a senha";
            this.txtConfSenha.Enter += new System.EventHandler(this.EnterConfSenha);
            this.txtConfSenha.Leave += new System.EventHandler(this.LeaveConfSenha);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtSenha.ForeColor = System.Drawing.Color.Snow;
            this.txtSenha.Location = new System.Drawing.Point(30, 92);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(330, 19);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.SenhaEnter);
            this.txtSenha.Leave += new System.EventHandler(this.SenhaLeave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 25);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(850, 164);
            this.shapeContainer1.TabIndex = 98;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineShape5.Enabled = false;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 496;
            this.lineShape5.X2 = 825;
            this.lineShape5.Y1 = 39;
            this.lineShape5.Y2 = 39;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 27;
            this.lineShape3.X2 = 356;
            this.lineShape3.Y1 = 142;
            this.lineShape3.Y2 = 142;
            // 
            // lineShape2
            // 
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 27;
            this.lineShape2.X2 = 356;
            this.lineShape2.Y1 = 89;
            this.lineShape2.Y2 = 89;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 27;
            this.lineShape1.X2 = 356;
            this.lineShape1.Y1 = 38;
            this.lineShape1.Y2 = 38;
            // 
            // tabela
            // 
            this.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(4)))));
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(12, 237);
            this.tabela.MultiSelect = false;
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.Size = new System.Drawing.Size(856, 344);
            this.tabela.TabIndex = 9;
            this.tabela.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletarDados);
            this.tabela.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.getDados);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4});
            this.shapeContainer2.Size = new System.Drawing.Size(880, 620);
            this.shapeContainer2.TabIndex = 100;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(3)))));
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 1;
            this.lineShape4.X2 = 1;
            this.lineShape4.Y1 = 0;
            this.lineShape4.Y2 = 620;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(4)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtualizar.Location = new System.Drawing.Point(498, 138);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(331, 40);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.Atualizar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(4)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(787, 80);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "X";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.CancelarAtualizar);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(880, 620);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtnomeUsu;
        private System.Windows.Forms.CheckBox checkRole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tabela;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtSenha;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtConfSenha;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.TextBox txtlogin;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbConf;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}