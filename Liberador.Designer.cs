namespace Teste_de_funcionalidades
{
    partial class Liberador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liberador));
            txtCnpj = new TextBox();
            label1 = new Label();
            btnSalvar = new Button();
            label2 = new Label();
            btnBaixar = new Button();
            SuspendLayout();
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(51, 31);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(147, 23);
            txtCnpj.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 36);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "CNPJ:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(63, 98);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(77, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar em:";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 102);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 3;
            label2.Text = "caminho selecionado";
            // 
            // btnBaixar
            // 
            btnBaixar.Location = new Point(204, 31);
            btnBaixar.Name = "btnBaixar";
            btnBaixar.Size = new Size(87, 23);
            btnBaixar.TabIndex = 4;
            btnBaixar.Text = "Baixar licença";
            btnBaixar.UseVisualStyleBackColor = true;
            btnBaixar.Click += btnBaixar_Click;
            // 
            // Liberador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 185);
            Controls.Add(btnBaixar);
            Controls.Add(label2);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(txtCnpj);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Liberador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Liberador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCnpj;
        private Label label1;
        private Button btnSalvar;
        private Label label2;
        private Button btnBaixar;
    }
}