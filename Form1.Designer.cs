namespace Aguinaldo
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
            lbltitu = new Label();
            lblSal = new Label();
            btnAguinaldo = new Button();
            txtsalary = new TextBox();
            lbltex = new Label();
            group = new GroupBox();
            timeact = new DateTimePicker();
            timeini = new DateTimePicker();
            label1 = new Label();
            lbldias = new Label();
            lblresultado = new Label();
            txtfechai = new DateTimePicker();
            txtfechaact = new DateTimePicker();
            group.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitu
            // 
            lbltitu.AutoSize = true;
            lbltitu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitu.Location = new Point(219, 9);
            lbltitu.Name = "lbltitu";
            lbltitu.Size = new Size(156, 21);
            lbltitu.TabIndex = 0;
            lbltitu.Text = "Calcular Aguinaldo";
            // 
            // lblSal
            // 
            lblSal.AutoSize = true;
            lblSal.Location = new Point(54, 60);
            lblSal.Name = "lblSal";
            lblSal.Size = new Size(131, 15);
            lblSal.TabIndex = 1;
            lblSal.Text = "Ingrese Salario Mensual";
            lblSal.Click += lblSal_Click;
            // 
            // btnAguinaldo
            // 
            btnAguinaldo.BackColor = Color.FromArgb(255, 255, 128);
            btnAguinaldo.Location = new Point(44, 396);
            btnAguinaldo.Name = "btnAguinaldo";
            btnAguinaldo.Size = new Size(141, 34);
            btnAguinaldo.TabIndex = 3;
            btnAguinaldo.Text = "Calcular Aguinaldo";
            btnAguinaldo.UseVisualStyleBackColor = false;
            btnAguinaldo.Click += btnAguinaldo_Click;
            // 
            // txtsalary
            // 
            txtsalary.Location = new Point(207, 57);
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(158, 23);
            txtsalary.TabIndex = 5;
            // 
            // lbltex
            // 
            lbltex.AutoSize = true;
            lbltex.Location = new Point(86, 30);
            lbltex.Name = "lbltex";
            lbltex.Size = new Size(238, 15);
            lbltex.TabIndex = 10;
            lbltex.Text = "Seleccione si ha trabajado menos de un año";
            // 
            // group
            // 
            group.Controls.Add(timeact);
            group.Controls.Add(timeini);
            group.Controls.Add(label1);
            group.Controls.Add(lbldias);
            group.Controls.Add(lbltex);
            group.Location = new Point(12, 114);
            group.Name = "group";
            group.Size = new Size(551, 165);
            group.TabIndex = 12;
            group.TabStop = false;
            // 
            // timeact
            // 
            timeact.Location = new Point(324, 99);
            timeact.Name = "timeact";
            timeact.Size = new Size(212, 23);
            timeact.TabIndex = 15;
            // 
            // timeini
            // 
            timeini.Location = new Point(324, 70);
            timeini.Name = "timeini";
            timeini.Size = new Size(215, 23);
            timeini.TabIndex = 14;
            timeini.ValueChanged += timeini_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 104);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 13;
            label1.Text = "Ahora la fecha actual:";
            // 
            // lbldias
            // 
            lbldias.AutoSize = true;
            lbldias.Location = new Point(10, 72);
            lbldias.Name = "lbldias";
            lbldias.Size = new Size(311, 15);
            lbldias.TabIndex = 12;
            lbldias.Text = "Si ha trabajado menos de un año digite la fecha de inicio: ";
            lbldias.Click += lbldias_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(227, 406);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(109, 15);
            lblresultado.TabIndex = 13;
            lblresultado.Text = "Su aguinaldo es de:";
            lblresultado.Click += lblresultado_Click;
            // 
            // txtfechai
            // 
            txtfechai.Location = new Point(0, 0);
            txtfechai.Name = "txtfechai";
            txtfechai.Size = new Size(200, 23);
            txtfechai.TabIndex = 0;
            // 
            // txtfechaact
            // 
            txtfechaact.Location = new Point(0, 0);
            txtfechaact.Name = "txtfechaact";
            txtfechaact.Size = new Size(200, 23);
            txtfechaact.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(598, 506);
            Controls.Add(lblresultado);
            Controls.Add(group);
            Controls.Add(txtsalary);
            Controls.Add(btnAguinaldo);
            Controls.Add(lblSal);
            Controls.Add(lbltitu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            group.ResumeLayout(false);
            group.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitu;
        private Label lblSal;
        private Button button1;
      //  private TextBox txtfechai;
     //   private TextBox textBox2;
        private ComboBox comboBox1;
        private Button btnCalcular;
        private Button btnAguinaldo;
        private TextBox txtsalary;
        private Label lbltex;
        private GroupBox group;
        private Label lbldias;
        private Label label1;
       // private TextBox txtfechaact;
        private Label lblresultado;
        private DateTimePicker txtfechai;
        private DateTimePicker txtfechaact;
        private DateTimePicker timeact;
        private DateTimePicker timeini;
    }
}
