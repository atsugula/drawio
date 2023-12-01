namespace drawio
{
    partial class FormEntregar
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
            btnEntregar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPlaca = new TextBox();
            txtKilometros = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnEntregar
            // 
            btnEntregar.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntregar.Location = new Point(79, 125);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(120, 42);
            btnEntregar.TabIndex = 0;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 84);
            label1.Name = "label1";
            label1.Size = new Size(67, 29);
            label1.TabIndex = 1;
            label1.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 55);
            label2.Name = "label2";
            label2.Size = new Size(151, 29);
            label2.TabIndex = 2;
            label2.Text = "km recorridos";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(158, 87);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(100, 23);
            txtPlaca.TabIndex = 3;
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(158, 55);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(100, 23);
            txtKilometros.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 9);
            label3.Name = "label3";
            label3.Size = new Size(172, 29);
            label3.TabIndex = 5;
            label3.Text = "Tarifa base 1000";
            // 
            // FormEntregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 178);
            Controls.Add(label3);
            Controls.Add(txtKilometros);
            Controls.Add(txtPlaca);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntregar);
            Name = "FormEntregar";
            Text = "Entregar vehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntregar;
        private Label label1;
        private Label label2;
        private TextBox txtPlaca;
        private TextBox txtKilometros;
        private Label label3;
    }
}