namespace drawio
{
    partial class FormVehiculo
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
            txtTipo = new TextBox();
            label1 = new Label();
            txtModelo = new TextBox();
            txtAno = new TextBox();
            txtPlaca = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(125, 29);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(167, 23);
            txtTipo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 29);
            label1.TabIndex = 1;
            label1.Text = "Tipo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(125, 68);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(167, 23);
            txtModelo.TabIndex = 5;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(125, 148);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(167, 23);
            txtAno.TabIndex = 6;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(125, 109);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(167, 23);
            txtPlaca.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 62);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 8;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 103);
            label3.Name = "label3";
            label3.Size = new Size(67, 29);
            label3.TabIndex = 9;
            label3.Text = "Placa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 142);
            label4.Name = "label4";
            label4.Size = new Size(50, 29);
            label4.TabIndex = 10;
            label4.Text = "Año";
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Location = new Point(15, 190);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(287, 40);
            btnEnviar.TabIndex = 11;
            btnEnviar.Text = "Registar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 247);
            Controls.Add(btnEnviar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPlaca);
            Controls.Add(txtAno);
            Controls.Add(txtModelo);
            Controls.Add(label1);
            Controls.Add(txtTipo);
            Name = "FormVehiculo";
            Text = "Registrar vehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTipo;
        private Label label1;
        private TextBox txtModelo;
        private TextBox txtAno;
        private TextBox txtPlaca;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEnviar;
    }
}