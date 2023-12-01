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
            SuspendLayout();
            // 
            // fechaInicio
            // 
            fechaInicio.Location = new Point(151, 63);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(233, 23);
            fechaInicio.TabIndex = 0;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Location = new Point(192, 142);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(143, 40);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Guardar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 57);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 2;
            label1.Text = "Fecha inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 100);
            label2.Name = "label2";
            label2.Size = new Size(102, 29);
            label2.TabIndex = 3;
            label2.Text = "Fecha fin";
            // 
            // fechaFin
            // 
            fechaFin.Location = new Point(151, 106);
            fechaFin.Name = "fechaFin";
            fechaFin.Size = new Size(233, 23);
            fechaFin.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 9);
            label3.Name = "label3";
            label3.Size = new Size(157, 29);
            label3.TabIndex = 5;
            label3.Text = "Placa Vehiculo";
            // 
            // txtPlaca
            // 
            txtPlaca.Enabled = false;
            txtPlaca.Location = new Point(192, 15);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(158, 23);
            txtPlaca.TabIndex = 6;
            // 
            // FormAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 226);
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
    }
}