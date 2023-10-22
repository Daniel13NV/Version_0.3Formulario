namespace Version_0._3Formulario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbNombre = new TextBox();
            tbApellidos = new TextBox();
            tbEdad = new TextBox();
            tbEstatura = new TextBox();
            tbTelefono = new TextBox();
            groupBox1 = new GroupBox();
            rbMujer = new RadioButton();
            rbHombre = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 67);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 116);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 167);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 208);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Estatura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 254);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(309, 65);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 5;
            // 
            // tbApellidos
            // 
            tbApellidos.Location = new Point(309, 116);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(100, 23);
            tbApellidos.TabIndex = 6;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(309, 167);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(100, 23);
            tbEdad.TabIndex = 7;
            // 
            // tbEstatura
            // 
            tbEstatura.Location = new Point(309, 200);
            tbEstatura.Name = "tbEstatura";
            tbEstatura.Size = new Size(100, 23);
            tbEstatura.TabIndex = 8;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(309, 246);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(100, 23);
            tbTelefono.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMujer);
            groupBox1.Controls.Add(rbHombre);
            groupBox1.Location = new Point(249, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genero";
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.Location = new Point(26, 56);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(56, 19);
            rbMujer.TabIndex = 1;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.Location = new Point(26, 31);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(69, 19);
            rbHombre.TabIndex = 0;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(550, 100);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(550, 159);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(tbTelefono);
            Controls.Add(tbEstatura);
            Controls.Add(tbEdad);
            Controls.Add(tbApellidos);
            Controls.Add(tbNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNombre;
        private TextBox tbApellidos;
        private TextBox tbEdad;
        private TextBox tbEstatura;
        private TextBox tbTelefono;
        private GroupBox groupBox1;
        private RadioButton rbMujer;
        private RadioButton rbHombre;
        private Button button1;
        private Button button2;
    }
}