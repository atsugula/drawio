namespace drawio
{
    partial class FormAlquiler
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
            fechaInicio = new DateTimePicker();
            btnEnviar = new Button();
            label1 = new Label();
            label2 = new Label();
            fechaFin = new DateTimePicker();
            label3 = new Label();
            txtPlaca = new TextBox();
            label4 = new Label();
            txtCliente = new TextBox();
            SuspendLayout();
            // 
            // fechaInicio
            // 
            fechaInicio.Location = new Point(144, 88);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(230, 23);
            fechaInicio.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Location = new Point(108, 146);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(188, 40);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Guardar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 82);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 2;
            label1.Text = "Fecha inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 111);
            label2.Name = "label2";
            label2.Size = new Size(102, 29);
            label2.TabIndex = 3;
            label2.Text = "Fecha fin";
            // 
            // fechaFin
            // 
            fechaFin.Location = new Point(144, 117);
            fechaFin.Name = "fechaFin";
            fechaFin.Size = new Size(230, 23);
            fechaFin.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(157, 29);
            label3.TabIndex = 5;
            label3.Text = "Placa Vehiculo";
            // 
            // txtPlaca
            // 
            txtPlaca.Enabled = false;
            txtPlaca.Location = new Point(166, 15);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(158, 23);
            txtPlaca.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 53);
            label4.Name = "label4";
            label4.Size = new Size(82, 29);
            label4.TabIndex = 7;
            label4.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(166, 53);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(158, 23);
            txtCliente.TabIndex = 8;
            // 
            // FormAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 194);
            Controls.Add(txtCliente);
            Controls.Add(label4);
            Controls.Add(txtPlaca);
            Controls.Add(label3);
            Controls.Add(fechaFin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Controls.Add(fechaInicio);
            Name = "FormAlquiler";
            Text = "Agregar alquiler de vehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fechaInicio;
        private Button btnEnviar;
        private Label label1;
        private Label label2;
        private DateTimePicker fechaFin;
        private Label label3;
        private TextBox txtPlaca;
        private Label label4;
        private TextBox txtCliente;
    }
}