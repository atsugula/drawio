namespace drawio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tablaVehiculos = new DataGridView();
            tablaAlquilados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnAgregarVehiculo = new Button();
            btnEliminarVehiculo = new Button();
            btnAgregarAlquiler = new Button();
            btnEliminarAlquiler = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaAlquilados).BeginInit();
            SuspendLayout();
            // 
            // tablaVehiculos
            // 
            tablaVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaVehiculos.Location = new Point(12, 51);
            tablaVehiculos.Name = "tablaVehiculos";
            tablaVehiculos.RowTemplate.Height = 25;
            tablaVehiculos.Size = new Size(751, 150);
            tablaVehiculos.TabIndex = 0;
            tablaVehiculos.CellClick += OnClickTablaVehiculo;
            // 
            // tablaAlquilados
            // 
            tablaAlquilados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaAlquilados.Location = new Point(12, 262);
            tablaAlquilados.Name = "tablaAlquilados";
            tablaAlquilados.RowTemplate.Height = 25;
            tablaAlquilados.Size = new Size(751, 150);
            tablaAlquilados.TabIndex = 1;
            tablaAlquilados.CellClick += OnClickTablaAlquiler;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 39);
            label1.TabIndex = 2;
            label1.Text = "Listado de vehiculos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 220);
            label2.Name = "label2";
            label2.Size = new Size(428, 39);
            label2.TabIndex = 3;
            label2.Text = "Listado de vehiculos alquilados";
            // 
            // btnAgregarVehiculo
            // 
            btnAgregarVehiculo.Location = new Point(791, 87);
            btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            btnAgregarVehiculo.Size = new Size(75, 23);
            btnAgregarVehiculo.TabIndex = 4;
            btnAgregarVehiculo.Text = "Agregar";
            btnAgregarVehiculo.UseVisualStyleBackColor = true;
            btnAgregarVehiculo.Click += btnAgregarVehiculo_Click;
            // 
            // btnEliminarVehiculo
            // 
            btnEliminarVehiculo.Enabled = false;
            btnEliminarVehiculo.Location = new Point(791, 165);
            btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            btnEliminarVehiculo.Size = new Size(75, 23);
            btnEliminarVehiculo.TabIndex = 5;
            btnEliminarVehiculo.Text = "Eliminar";
            btnEliminarVehiculo.UseVisualStyleBackColor = true;
            btnEliminarVehiculo.Click += btnEliminarVehiculo_Click;
            // 
            // btnAgregarAlquiler
            // 
            btnAgregarAlquiler.Enabled = false;
            btnAgregarAlquiler.Location = new Point(791, 127);
            btnAgregarAlquiler.Name = "btnAgregarAlquiler";
            btnAgregarAlquiler.Size = new Size(75, 23);
            btnAgregarAlquiler.TabIndex = 6;
            btnAgregarAlquiler.Text = "Alquilar";
            btnAgregarAlquiler.UseVisualStyleBackColor = true;
            btnAgregarAlquiler.Click += btnAgregarAlquiler_Click;
            // 
            // btnEliminarAlquiler
            // 
            btnEliminarAlquiler.Enabled = false;
            btnEliminarAlquiler.Location = new Point(791, 309);
            btnEliminarAlquiler.Name = "btnEliminarAlquiler";
            btnEliminarAlquiler.Size = new Size(75, 23);
            btnEliminarAlquiler.TabIndex = 7;
            btnEliminarAlquiler.Text = "Eliminar";
            btnEliminarAlquiler.UseVisualStyleBackColor = true;
            btnEliminarAlquiler.Click += btnEliminarAlquiler_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 430);
            Controls.Add(btnEliminarAlquiler);
            Controls.Add(btnAgregarAlquiler);
            Controls.Add(btnEliminarVehiculo);
            Controls.Add(btnAgregarVehiculo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tablaAlquilados);
            Controls.Add(tablaVehiculos);
            Name = "Form1";
            Text = "Lista de vehiculos";
            ((System.ComponentModel.ISupportInitialize)tablaVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaAlquilados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaVehiculos;
        private DataGridView tablaAlquilados;
        private Label label1;
        private Label label2;
        private Button btnAgregarVehiculo;
        private Button btnEliminarVehiculo;
        private Button btnAgregarAlquiler;
        private Button btnEliminarAlquiler;
    }
}