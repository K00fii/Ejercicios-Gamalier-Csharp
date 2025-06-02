using System.Windows.Forms;

namespace Ejercicio_4__Interfaz_Grafica_
{
    partial class RegistroDeCalificaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDeCalificaciones));
            this.linea1 = new System.Windows.Forms.Button();
            this.linea2 = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn_Femenino = new System.Windows.Forms.RadioButton();
            this.rbtn_Masculino = new System.Windows.Forms.RadioButton();
            this.cmb_Area = new System.Windows.Forms.ComboBox();
            this.cmb_Seccion = new System.Windows.Forms.ComboBox();
            this.cmb_Curso = new System.Windows.Forms.ComboBox();
            this.txt_Nota3 = new System.Windows.Forms.TextBox();
            this.txt_Nota4 = new System.Windows.Forms.TextBox();
            this.txt_Nota2 = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Nota1 = new System.Windows.Forms.TextBox();
            this.lbl_Nota3 = new System.Windows.Forms.Label();
            this.lbl_Nota4 = new System.Windows.Forms.Label();
            this.lbl_Nota2 = new System.Windows.Forms.Label();
            this.lbl_StatusR = new System.Windows.Forms.Label();
            this.lbl_Nota1 = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.lbl_Seccion = new System.Windows.Forms.Label();
            this.lbl_NombreText = new System.Windows.Forms.Label();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Promedio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // linea1
            // 
            this.linea1.BackColor = System.Drawing.Color.BlueViolet;
            this.linea1.FlatAppearance.BorderSize = 0;
            this.linea1.Location = new System.Drawing.Point(-8, 50);
            this.linea1.Name = "linea1";
            this.linea1.Size = new System.Drawing.Size(531, 5);
            this.linea1.TabIndex = 1;
            this.linea1.UseVisualStyleBackColor = true;
            this.linea1.Click += new System.EventHandler(this.linea1_Click);
            // 
            // linea2
            // 
            this.linea2.BackColor = System.Drawing.Color.BlueViolet;
            this.linea2.FlatAppearance.BorderSize = 0;
            this.linea2.Location = new System.Drawing.Point(-8, 376);
            this.linea2.Name = "linea2";
            this.linea2.Size = new System.Drawing.Size(531, 5);
            this.linea2.TabIndex = 1;
            this.linea2.UseVisualStyleBackColor = true;
            this.linea2.Click += new System.EventHandler(this.linea1_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(22, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(253, 19);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "REGISTRO DE CALIFICACIONES";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 55);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 331);
            this.panel2.TabIndex = 9;
            // 
            // rbtn_Femenino
            // 
            this.rbtn_Femenino.AutoSize = true;
            this.rbtn_Femenino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn_Femenino.ForeColor = System.Drawing.Color.White;
            this.rbtn_Femenino.Location = new System.Drawing.Point(170, 196);
            this.rbtn_Femenino.Name = "rbtn_Femenino";
            this.rbtn_Femenino.Size = new System.Drawing.Size(31, 17);
            this.rbtn_Femenino.TabIndex = 31;
            this.rbtn_Femenino.TabStop = true;
            this.rbtn_Femenino.Text = "F";
            this.rbtn_Femenino.UseVisualStyleBackColor = false;
            // 
            // rbtn_Masculino
            // 
            this.rbtn_Masculino.AutoSize = true;
            this.rbtn_Masculino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbtn_Masculino.ForeColor = System.Drawing.Color.White;
            this.rbtn_Masculino.Location = new System.Drawing.Point(112, 196);
            this.rbtn_Masculino.Name = "rbtn_Masculino";
            this.rbtn_Masculino.Size = new System.Drawing.Size(34, 17);
            this.rbtn_Masculino.TabIndex = 30;
            this.rbtn_Masculino.TabStop = true;
            this.rbtn_Masculino.Text = "M";
            this.rbtn_Masculino.UseVisualStyleBackColor = false;
            // 
            // cmb_Area
            // 
            this.cmb_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Area.FormattingEnabled = true;
            this.cmb_Area.Items.AddRange(new object[] {
            "Enfermería",
            "Contabilidad",
            "Gastronomía",
            "Informática",
            "Electricidad"});
            this.cmb_Area.Location = new System.Drawing.Point(112, 151);
            this.cmb_Area.Name = "cmb_Area";
            this.cmb_Area.Size = new System.Drawing.Size(148, 21);
            this.cmb_Area.TabIndex = 29;
            // 
            // cmb_Seccion
            // 
            this.cmb_Seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Seccion.FormattingEnabled = true;
            this.cmb_Seccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmb_Seccion.Location = new System.Drawing.Point(112, 124);
            this.cmb_Seccion.Name = "cmb_Seccion";
            this.cmb_Seccion.Size = new System.Drawing.Size(148, 21);
            this.cmb_Seccion.TabIndex = 28;
            // 
            // cmb_Curso
            // 
            this.cmb_Curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Curso.FormattingEnabled = true;
            this.cmb_Curso.Items.AddRange(new object[] {
            "1ER GRADO",
            "2DO GRADO",
            "3ER GRADO",
            "4TO GRADO",
            "5TO GRADO",
            "6TO GRADO"});
            this.cmb_Curso.Location = new System.Drawing.Point(112, 98);
            this.cmb_Curso.Name = "cmb_Curso";
            this.cmb_Curso.Size = new System.Drawing.Size(148, 21);
            this.cmb_Curso.TabIndex = 27;
            // 
            // txt_Nota3
            // 
            this.txt_Nota3.Location = new System.Drawing.Point(112, 276);
            this.txt_Nota3.Name = "txt_Nota3";
            this.txt_Nota3.Size = new System.Drawing.Size(42, 20);
            this.txt_Nota3.TabIndex = 25;
            // 
            // txt_Nota4
            // 
            this.txt_Nota4.Location = new System.Drawing.Point(112, 302);
            this.txt_Nota4.Name = "txt_Nota4";
            this.txt_Nota4.Size = new System.Drawing.Size(42, 20);
            this.txt_Nota4.TabIndex = 24;
            // 
            // txt_Nota2
            // 
            this.txt_Nota2.Location = new System.Drawing.Point(112, 249);
            this.txt_Nota2.Name = "txt_Nota2";
            this.txt_Nota2.Size = new System.Drawing.Size(42, 20);
            this.txt_Nota2.TabIndex = 23;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(112, 72);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(148, 20);
            this.txt_Nombre.TabIndex = 22;
            // 
            // txt_Nota1
            // 
            this.txt_Nota1.Location = new System.Drawing.Point(112, 222);
            this.txt_Nota1.Name = "txt_Nota1";
            this.txt_Nota1.Size = new System.Drawing.Size(42, 20);
            this.txt_Nota1.TabIndex = 26;
            // 
            // lbl_Nota3
            // 
            this.lbl_Nota3.AutoSize = true;
            this.lbl_Nota3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Nota3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nota3.ForeColor = System.Drawing.Color.White;
            this.lbl_Nota3.Location = new System.Drawing.Point(26, 276);
            this.lbl_Nota3.Name = "lbl_Nota3";
            this.lbl_Nota3.Size = new System.Drawing.Size(60, 17);
            this.lbl_Nota3.TabIndex = 21;
            this.lbl_Nota3.Text = "‣ Nota 3:";
            // 
            // lbl_Nota4
            // 
            this.lbl_Nota4.AutoSize = true;
            this.lbl_Nota4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Nota4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nota4.ForeColor = System.Drawing.Color.White;
            this.lbl_Nota4.Location = new System.Drawing.Point(26, 302);
            this.lbl_Nota4.Name = "lbl_Nota4";
            this.lbl_Nota4.Size = new System.Drawing.Size(60, 17);
            this.lbl_Nota4.TabIndex = 20;
            this.lbl_Nota4.Text = "‣ Nota 4:";
            // 
            // lbl_Nota2
            // 
            this.lbl_Nota2.AutoSize = true;
            this.lbl_Nota2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Nota2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nota2.ForeColor = System.Drawing.Color.White;
            this.lbl_Nota2.Location = new System.Drawing.Point(26, 249);
            this.lbl_Nota2.Name = "lbl_Nota2";
            this.lbl_Nota2.Size = new System.Drawing.Size(60, 17);
            this.lbl_Nota2.TabIndex = 19;
            this.lbl_Nota2.Text = "‣ Nota 2:";
            // 
            // lbl_StatusR
            // 
            this.lbl_StatusR.AutoSize = true;
            this.lbl_StatusR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_StatusR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusR.ForeColor = System.Drawing.Color.White;
            this.lbl_StatusR.Location = new System.Drawing.Point(120, 360);
            this.lbl_StatusR.Name = "lbl_StatusR";
            this.lbl_StatusR.Size = new System.Drawing.Size(16, 17);
            this.lbl_StatusR.TabIndex = 18;
            this.lbl_StatusR.Text = "  ";
            // 
            // lbl_Nota1
            // 
            this.lbl_Nota1.AutoSize = true;
            this.lbl_Nota1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Nota1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nota1.ForeColor = System.Drawing.Color.White;
            this.lbl_Nota1.Location = new System.Drawing.Point(26, 222);
            this.lbl_Nota1.Name = "lbl_Nota1";
            this.lbl_Nota1.Size = new System.Drawing.Size(60, 17);
            this.lbl_Nota1.TabIndex = 17;
            this.lbl_Nota1.Text = "‣ Nota 1:";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Sexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexo.ForeColor = System.Drawing.Color.White;
            this.lbl_Sexo.Location = new System.Drawing.Point(26, 196);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(48, 17);
            this.lbl_Sexo.TabIndex = 16;
            this.lbl_Sexo.Text = "• Sexo:";
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Area.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Area.ForeColor = System.Drawing.Color.White;
            this.lbl_Area.Location = new System.Drawing.Point(26, 151);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(47, 17);
            this.lbl_Area.TabIndex = 15;
            this.lbl_Area.Text = "• Area:";
            // 
            // lbl_Seccion
            // 
            this.lbl_Seccion.AutoSize = true;
            this.lbl_Seccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Seccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Seccion.ForeColor = System.Drawing.Color.White;
            this.lbl_Seccion.Location = new System.Drawing.Point(26, 125);
            this.lbl_Seccion.Name = "lbl_Seccion";
            this.lbl_Seccion.Size = new System.Drawing.Size(64, 17);
            this.lbl_Seccion.TabIndex = 14;
            this.lbl_Seccion.Text = "• Sección:";
            // 
            // lbl_NombreText
            // 
            this.lbl_NombreText.AutoSize = true;
            this.lbl_NombreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_NombreText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreText.ForeColor = System.Drawing.Color.White;
            this.lbl_NombreText.Location = new System.Drawing.Point(26, 72);
            this.lbl_NombreText.Name = "lbl_NombreText";
            this.lbl_NombreText.Size = new System.Drawing.Size(69, 17);
            this.lbl_NombreText.TabIndex = 13;
            this.lbl_NombreText.Text = "• Nombre:";
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Curso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Curso.ForeColor = System.Drawing.Color.White;
            this.lbl_Curso.Location = new System.Drawing.Point(26, 98);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(54, 17);
            this.lbl_Curso.TabIndex = 12;
            this.lbl_Curso.Text = "• Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "• STATUS:";
            // 
            // lbl_Promedio
            // 
            this.lbl_Promedio.AutoSize = true;
            this.lbl_Promedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Promedio.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Promedio.ForeColor = System.Drawing.Color.White;
            this.lbl_Promedio.Location = new System.Drawing.Point(27, 341);
            this.lbl_Promedio.Name = "lbl_Promedio";
            this.lbl_Promedio.Size = new System.Drawing.Size(115, 19);
            this.lbl_Promedio.TabIndex = 10;
            this.lbl_Promedio.Text = "• PROMEDIO: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btn_Salir);
            this.panel3.Controls.Add(this.btn_Calcular);
            this.panel3.Controls.Add(this.btn_Limpiar);
            this.panel3.Location = new System.Drawing.Point(1, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 68);
            this.panel3.TabIndex = 32;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Red;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(192, 23);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Calcular.Location = new System.Drawing.Point(100, 23);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(86, 23);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Limpiar.Location = new System.Drawing.Point(19, 23);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 9;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // RegistroDeCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rbtn_Femenino);
            this.Controls.Add(this.rbtn_Masculino);
            this.Controls.Add(this.cmb_Area);
            this.Controls.Add(this.cmb_Seccion);
            this.Controls.Add(this.cmb_Curso);
            this.Controls.Add(this.txt_Nota3);
            this.Controls.Add(this.txt_Nota4);
            this.Controls.Add(this.txt_Nota2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Nota1);
            this.Controls.Add(this.lbl_Nota3);
            this.Controls.Add(this.lbl_Nota4);
            this.Controls.Add(this.lbl_Nota2);
            this.Controls.Add(this.lbl_StatusR);
            this.Controls.Add(this.lbl_Nota1);
            this.Controls.Add(this.lbl_Sexo);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.lbl_Seccion);
            this.Controls.Add(this.lbl_NombreText);
            this.Controls.Add(this.lbl_Curso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Promedio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linea2);
            this.Controls.Add(this.linea1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistroDeCalificaciones";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RegistroDeCalificaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button linea1;
        private System.Windows.Forms.Button linea2;
        private Label Titulo;
        private Panel panel1;
        private Panel panel2;
        private RadioButton rbtn_Femenino;
        private RadioButton rbtn_Masculino;
        private ComboBox cmb_Area;
        private ComboBox cmb_Seccion;
        private ComboBox cmb_Curso;
        private TextBox txt_Nota3;
        private TextBox txt_Nota4;
        private TextBox txt_Nota2;
        private TextBox txt_Nombre;
        private TextBox txt_Nota1;
        private Label lbl_Nota3;
        private Label lbl_Nota4;
        private Label lbl_Nota2;
        private Label lbl_StatusR;
        private Label lbl_Nota1;
        private Label lbl_Sexo;
        private Label lbl_Area;
        private Label lbl_Seccion;
        private Label lbl_NombreText;
        private Label lbl_Curso;
        private Label label1;
        private Label lbl_Promedio;
        private Panel panel3;
        private Button btn_Salir;
        private Button btn_Calcular;
        private Button btn_Limpiar;
    }
}

