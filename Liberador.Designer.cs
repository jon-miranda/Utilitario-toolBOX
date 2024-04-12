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
            btnBaixar = new Button();
            button1 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(77, 51);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(147, 23);
            txtCnpj.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 55);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 1;
            label1.Text = "CNPJ:";
            // 
            // btnBaixar
            // 
            btnBaixar.BackColor = SystemColors.Highlight;
            btnBaixar.FlatAppearance.BorderSize = 0;
            btnBaixar.FlatStyle = FlatStyle.Flat;
            btnBaixar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaixar.ForeColor = SystemColors.ControlLightLight;
            btnBaixar.Location = new Point(72, 87);
            btnBaixar.Name = "btnBaixar";
            btnBaixar.Size = new Size(158, 40);
            btnBaixar.TabIndex = 4;
            btnBaixar.Text = "Baixar licença";
            btnBaixar.UseVisualStyleBackColor = false;
            btnBaixar.Click += btnBaixar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(72, 133);
            button1.Name = "button1";
            button1.Size = new Size(158, 40);
            button1.TabIndex = 5;
            button1.Text = "Inicia liberação";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Highlight;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(54, 8);
            label2.Name = "label2";
            label2.Size = new Size(203, 23);
            label2.TabIndex = 6;
            label2.Text = "LIBERADOR DE SENHA";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 39);
            panel1.TabIndex = 7;
            // 
            // Liberador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(303, 185);
            Controls.Add(button1);
            Controls.Add(btnBaixar);
            Controls.Add(label1);
            Controls.Add(txtCnpj);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Liberador";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCnpj;
        private Label label1;
        private Button btnBaixar;
        private Button button1;
        private Label label2;
        private Panel panel1;
    }
}