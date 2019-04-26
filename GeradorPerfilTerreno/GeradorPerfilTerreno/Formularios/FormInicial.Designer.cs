namespace GeradorPerfilTerreno.Formularios
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.btSelecionarPlanilha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btDesenharPerfil = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFatorAmplZ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSelecionarPlanilha
            // 
            this.btSelecionarPlanilha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSelecionarPlanilha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSelecionarPlanilha.FlatAppearance.BorderSize = 5;
            this.btSelecionarPlanilha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSelecionarPlanilha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelecionarPlanilha.Location = new System.Drawing.Point(185, 56);
            this.btSelecionarPlanilha.Name = "btSelecionarPlanilha";
            this.btSelecionarPlanilha.Size = new System.Drawing.Size(103, 23);
            this.btSelecionarPlanilha.TabIndex = 0;
            this.btSelecionarPlanilha.Text = "Selecionar";
            this.btSelecionarPlanilha.UseVisualStyleBackColor = true;
            this.btSelecionarPlanilha.Click += new System.EventHandler(this.btSelecionarPlanilha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "2. Selecione a planilha Excel:";
            // 
            // btDesenharPerfil
            // 
            this.btDesenharPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDesenharPerfil.Enabled = false;
            this.btDesenharPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btDesenharPerfil.FlatAppearance.BorderSize = 5;
            this.btDesenharPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDesenharPerfil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesenharPerfil.Location = new System.Drawing.Point(158, 124);
            this.btDesenharPerfil.Name = "btDesenharPerfil";
            this.btDesenharPerfil.Size = new System.Drawing.Size(86, 25);
            this.btDesenharPerfil.TabIndex = 2;
            this.btDesenharPerfil.Text = "Gerar perfil";
            this.btDesenharPerfil.UseVisualStyleBackColor = true;
            this.btDesenharPerfil.Click += new System.EventHandler(this.btDesenharPerfil_Click);
            // 
            // btSair
            // 
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btSair.FlatAppearance.BorderSize = 5;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(250, 124);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(38, 25);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "© - 2018";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "1. Fator de ampliação do eixo vertical:";
            // 
            // txtFatorAmplZ
            // 
            this.txtFatorAmplZ.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatorAmplZ.Location = new System.Drawing.Point(230, 12);
            this.txtFatorAmplZ.Name = "txtFatorAmplZ";
            this.txtFatorAmplZ.Size = new System.Drawing.Size(58, 21);
            this.txtFatorAmplZ.TabIndex = 6;
            this.txtFatorAmplZ.Text = "10";
            this.txtFatorAmplZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(302, 161);
            this.Controls.Add(this.txtFatorAmplZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btDesenharPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSelecionarPlanilha);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelecionarPlanilha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDesenharPerfil;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFatorAmplZ;
    }
}