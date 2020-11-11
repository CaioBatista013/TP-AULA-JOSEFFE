namespace WindowsFormsApp1
{
    partial class Painel
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
            this.btcadclientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btcadclientes
            // 
            this.btcadclientes.Location = new System.Drawing.Point(161, 58);
            this.btcadclientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcadclientes.Name = "btcadclientes";
            this.btcadclientes.Size = new System.Drawing.Size(287, 46);
            this.btcadclientes.TabIndex = 0;
            this.btcadclientes.Text = "Cadastrar Clientes";
            this.btcadclientes.UseVisualStyleBackColor = true;
            this.btcadclientes.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btcadclientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Painel";
            this.Text = "Painel de Cadastro";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btcadclientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}