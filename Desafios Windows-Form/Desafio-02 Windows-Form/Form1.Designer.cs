namespace _02_Desafio_GUI
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
            label4 = new Label();
            panel4 = new Panel();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            cboArea = new ComboBox();
            cboSeccion = new ComboBox();
            cboCurso = new ComboBox();
            txtNombreEstudiante = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblCursoo = new Label();
            lblNombre = new Label();
            txtPromedio = new TextBox();
            txtNota4 = new TextBox();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            lblNotas = new Label();
            btnCalcular = new Button();
            txtNota1 = new TextBox();
            lblPromedio = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            txtStatus = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Mongolian Baiti", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(288, 26);
            label4.Name = "label4";
            label4.Size = new Size(294, 30);
            label4.TabIndex = 22;
            label4.Text = "Estado Del Estudiante";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Controls.Add(label4);
            panel4.Location = new Point(217, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(817, 84);
            panel4.TabIndex = 42;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.BackColor = Color.Transparent;
            rdbFemenino.ForeColor = SystemColors.ActiveCaptionText;
            rdbFemenino.Location = new Point(208, 245);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 36;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = false;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.BackColor = Color.Transparent;
            rdbMasculino.ForeColor = Color.Black;
            rdbMasculino.Location = new Point(336, 245);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 35;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = false;
            // 
            // cboArea
            // 
            cboArea.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Enfermeria", "Contabilidad", "Gastronomia", "Informatica", "Electrecidad" });
            cboArea.Location = new Point(67, 234);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(268, 29);
            cboArea.TabIndex = 33;
            // 
            // cboSeccion
            // 
            cboSeccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cboSeccion.FormattingEnabled = true;
            cboSeccion.Items.AddRange(new object[] { "A-1", "A-2", "A-3", "A-4", "B", "C-1", "C-2", "D-1", "D-2", "E" });
            cboSeccion.Location = new Point(380, 234);
            cboSeccion.Name = "cboSeccion";
            cboSeccion.Size = new Size(268, 29);
            cboSeccion.TabIndex = 32;
            // 
            // cboCurso
            // 
            cboCurso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cboCurso.FormattingEnabled = true;
            cboCurso.Items.AddRange(new object[] { "4to", "5to", "6to" });
            cboCurso.Location = new Point(380, 150);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(268, 29);
            cboCurso.TabIndex = 31;
            // 
            // txtNombreEstudiante
            // 
            txtNombreEstudiante.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNombreEstudiante.Location = new Point(67, 150);
            txtNombreEstudiante.Name = "txtNombreEstudiante";
            txtNombreEstudiante.Size = new Size(268, 29);
            txtNombreEstudiante.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 110);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 29;
            label3.Text = "Area:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(344, 106);
            label2.Name = "label2";
            label2.Size = new Size(97, 22);
            label2.TabIndex = 28;
            label2.Text = "Seccion: ";
            // 
            // lblCursoo
            // 
            lblCursoo.AutoSize = true;
            lblCursoo.BackColor = Color.Transparent;
            lblCursoo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCursoo.ForeColor = SystemColors.ActiveCaptionText;
            lblCursoo.Location = new Point(344, 27);
            lblCursoo.Name = "lblCursoo";
            lblCursoo.Size = new Size(79, 22);
            lblCursoo.TabIndex = 27;
            lblCursoo.Text = "Curso: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(31, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 24);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre: ";
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(43, 190);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(234, 23);
            txtPromedio.TabIndex = 54;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(174, 128);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(103, 23);
            txtNota4.TabIndex = 53;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(43, 128);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(103, 23);
            txtNota3.TabIndex = 52;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(174, 71);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(102, 23);
            txtNota2.TabIndex = 51;
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.BackColor = Color.Transparent;
            lblNotas.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotas.ForeColor = Color.Black;
            lblNotas.Location = new Point(27, 12);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(74, 27);
            lblNotas.TabIndex = 44;
            lblNotas.Text = "Notas";
            // 
            // btnCalcular
            // 
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 100, 90);
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 100, 90);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(96, 230);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(124, 32);
            btnCalcular.TabIndex = 43;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(43, 71);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(103, 23);
            txtNota1.TabIndex = 50;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.BackColor = Color.Transparent;
            lblPromedio.Font = new Font("Segoe UI", 10F);
            lblPromedio.ForeColor = Color.Black;
            lblPromedio.Location = new Point(43, 168);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(75, 19);
            lblPromedio.TabIndex = 49;
            lblPromedio.Text = "Promedio: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(174, 106);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 48;
            label10.Text = "Nota 4: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(43, 106);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 47;
            label9.Text = "Nota 3: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(43, 49);
            label8.Name = "label8";
            label8.Size = new Size(62, 19);
            label8.TabIndex = 46;
            label8.Text = "Nota 1:  ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(174, 49);
            label7.Name = "label7";
            label7.Size = new Size(58, 19);
            label7.TabIndex = 45;
            label7.Text = "Nota 2: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnLimpiar);
            panel3.Location = new Point(350, 435);
            panel3.Name = "panel3";
            panel3.Size = new Size(559, 137);
            panel3.TabIndex = 41;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 9F);
            txtStatus.Location = new Point(129, 71);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(207, 23);
            txtStatus.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(129, 39);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 40;
            label1.Text = "Status: ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 100, 90);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 100, 90);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(352, 71);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(77, 26);
            btnLimpiar.TabIndex = 39;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(txtPromedio);
            panel1.Controls.Add(txtNota4);
            panel1.Controls.Add(txtNota3);
            panel1.Controls.Add(txtNota2);
            panel1.Controls.Add(lblNotas);
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(txtNota1);
            panel1.Controls.Add(lblPromedio);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(843, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 282);
            panel1.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(277, 207);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 56;
            label5.Text = "Sexo:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(rdbMasculino);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(rdbFemenino);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblCursoo);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(36, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 303);
            panel2.TabIndex = 57;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1095, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 58;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1182, 614);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(cboArea);
            Controls.Add(panel3);
            Controls.Add(cboSeccion);
            Controls.Add(cboCurso);
            Controls.Add(txtNombreEstudiante);
            Controls.Add(panel2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Panel panel4;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private ComboBox cboArea;
        private ComboBox cboSeccion;
        private ComboBox cboCurso;
        private TextBox txtNombreEstudiante;
        private Label label3;
        private Label label2;
        private Label lblCursoo;
        private Label lblNombre;
        private TextBox txtPromedio;
        private TextBox txtNota4;
        private TextBox txtNota3;
        private TextBox txtNota2;
        private Label lblNotas;
        private Button btnCalcular;
        private TextBox txtNota1;
        private Label lblPromedio;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel3;
        private TextBox txtStatus;
        private Label label1;
        private Button btnLimpiar;
        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private Button button1;
    }
}
