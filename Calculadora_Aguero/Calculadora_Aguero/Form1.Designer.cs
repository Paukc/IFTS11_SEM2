
namespace Calculadora_Aguero
{
    partial class Calculadora
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
            this.Limpiar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Divisor = new System.Windows.Forms.Button();
            this.Multiplicador = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Coma = new System.Windows.Forms.Button();
            this.txtDisplay = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SignCh = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Button();
            this.Siete = new System.Windows.Forms.Button();
            this.Ocho = new System.Windows.Forms.Button();
            this.Nueve = new System.Windows.Forms.Button();
            this.Cuatro = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Uno = new System.Windows.Forms.Button();
            this.Dos = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Cero = new System.Windows.Forms.Button();
            this.historial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Limpiar.Location = new System.Drawing.Point(312, 328);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(184, 44);
            this.Limpiar.TabIndex = 1;
            this.Limpiar.Text = "C";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.Location = new System.Drawing.Point(90, 121);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(61, 44);
            this.Borrar.TabIndex = 2;
            this.Borrar.Text = "CE";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Divisor
            // 
            this.Divisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisor.Location = new System.Drawing.Point(224, 121);
            this.Divisor.Name = "Divisor";
            this.Divisor.Size = new System.Drawing.Size(61, 44);
            this.Divisor.TabIndex = 3;
            this.Divisor.Text = "/";
            this.Divisor.UseVisualStyleBackColor = true;
            this.Divisor.Click += new System.EventHandler(this.agregarOperador);
            // 
            // Multiplicador
            // 
            this.Multiplicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicador.Location = new System.Drawing.Point(224, 171);
            this.Multiplicador.Name = "Multiplicador";
            this.Multiplicador.Size = new System.Drawing.Size(61, 44);
            this.Multiplicador.TabIndex = 4;
            this.Multiplicador.Text = "*";
            this.Multiplicador.UseVisualStyleBackColor = true;
            this.Multiplicador.Click += new System.EventHandler(this.agregarOperador);
            // 
            // Resta
            // 
            this.Resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.Location = new System.Drawing.Point(224, 221);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(61, 44);
            this.Resta.TabIndex = 8;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.agregarOperador);
            // 
            // Suma
            // 
            this.Suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(224, 271);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(61, 44);
            this.Suma.TabIndex = 12;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.agregarOperador);
            // 
            // Igual
            // 
            this.Igual.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(224, 328);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(61, 44);
            this.Igual.TabIndex = 16;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = false;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Coma
            // 
            this.Coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coma.Location = new System.Drawing.Point(157, 328);
            this.Coma.Name = "Coma";
            this.Coma.Size = new System.Drawing.Size(61, 44);
            this.Coma.TabIndex = 18;
            this.Coma.Text = ",";
            this.Coma.UseVisualStyleBackColor = true;
            this.Coma.Click += new System.EventHandler(this.Coma_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(23, 59);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(262, 43);
            this.txtResult.TabIndex = 19;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // SignCh
            // 
            this.SignCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignCh.Location = new System.Drawing.Point(23, 328);
            this.SignCh.Name = "SignCh";
            this.SignCh.Size = new System.Drawing.Size(61, 44);
            this.SignCh.TabIndex = 21;
            this.SignCh.Text = "+ / -";
            this.SignCh.UseVisualStyleBackColor = true;
            this.SignCh.Click += new System.EventHandler(this.SignCh_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(157, 121);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(61, 44);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "<-";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Percentage
            // 
            this.Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage.Location = new System.Drawing.Point(23, 121);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(61, 44);
            this.Percentage.TabIndex = 24;
            this.Percentage.Text = "%";
            this.Percentage.UseVisualStyleBackColor = true;
            this.Percentage.Click += new System.EventHandler(this.agregarOperador);
            // 
            // Siete
            // 
            this.Siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siete.Location = new System.Drawing.Point(23, 171);
            this.Siete.Name = "Siete";
            this.Siete.Size = new System.Drawing.Size(61, 44);
            this.Siete.TabIndex = 25;
            this.Siete.Text = "7";
            this.Siete.UseVisualStyleBackColor = true;
            this.Siete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Ocho
            // 
            this.Ocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ocho.Location = new System.Drawing.Point(90, 171);
            this.Ocho.Name = "Ocho";
            this.Ocho.Size = new System.Drawing.Size(61, 44);
            this.Ocho.TabIndex = 26;
            this.Ocho.Text = "8";
            this.Ocho.UseVisualStyleBackColor = true;
            this.Ocho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Nueve
            // 
            this.Nueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nueve.Location = new System.Drawing.Point(157, 171);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(61, 44);
            this.Nueve.TabIndex = 27;
            this.Nueve.Text = "9";
            this.Nueve.UseVisualStyleBackColor = true;
            this.Nueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Cuatro
            // 
            this.Cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuatro.Location = new System.Drawing.Point(23, 221);
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Size = new System.Drawing.Size(61, 44);
            this.Cuatro.TabIndex = 28;
            this.Cuatro.Text = "4";
            this.Cuatro.UseVisualStyleBackColor = true;
            this.Cuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Cinco
            // 
            this.Cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinco.Location = new System.Drawing.Point(90, 221);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(61, 44);
            this.Cinco.TabIndex = 29;
            this.Cinco.Text = "5";
            this.Cinco.UseVisualStyleBackColor = true;
            this.Cinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Seis
            // 
            this.Seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seis.Location = new System.Drawing.Point(157, 221);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(61, 44);
            this.Seis.TabIndex = 30;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = true;
            this.Seis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Uno
            // 
            this.Uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uno.Location = new System.Drawing.Point(23, 271);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(61, 44);
            this.Uno.TabIndex = 31;
            this.Uno.Text = "1";
            this.Uno.UseVisualStyleBackColor = true;
            this.Uno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Dos
            // 
            this.Dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dos.Location = new System.Drawing.Point(90, 271);
            this.Dos.Name = "Dos";
            this.Dos.Size = new System.Drawing.Size(61, 44);
            this.Dos.TabIndex = 32;
            this.Dos.Text = "2";
            this.Dos.UseVisualStyleBackColor = true;
            this.Dos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Tres
            // 
            this.Tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tres.Location = new System.Drawing.Point(157, 271);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(61, 44);
            this.Tres.TabIndex = 33;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = true;
            this.Tres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Cero
            // 
            this.Cero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cero.Location = new System.Drawing.Point(90, 328);
            this.Cero.Name = "Cero";
            this.Cero.Size = new System.Drawing.Size(61, 44);
            this.Cero.TabIndex = 34;
            this.Cero.Text = "0";
            this.Cero.UseVisualStyleBackColor = true;
            this.Cero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // historial
            // 
            this.historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial.Location = new System.Drawing.Point(312, 122);
            this.historial.Multiline = true;
            this.historial.Name = "historial";
            this.historial.ReadOnly = true;
            this.historial.Size = new System.Drawing.Size(208, 193);
            this.historial.TabIndex = 35;
            this.historial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.historial.TextChanged += new System.EventHandler(this.txtHistorial_TextChanged);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 397);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.Cero);
            this.Controls.Add(this.Tres);
            this.Controls.Add(this.Dos);
            this.Controls.Add(this.Uno);
            this.Controls.Add(this.Seis);
            this.Controls.Add(this.Cinco);
            this.Controls.Add(this.Cuatro);
            this.Controls.Add(this.Nueve);
            this.Controls.Add(this.Ocho);
            this.Controls.Add(this.Siete);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.SignCh);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Coma);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Multiplicador);
            this.Controls.Add(this.Divisor);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Limpiar);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Divisor;
        private System.Windows.Forms.Button Multiplicador;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Coma;
        private System.ComponentModel.BackgroundWorker txtDisplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button SignCh;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Percentage;
        private System.Windows.Forms.Button Siete;
        private System.Windows.Forms.Button Ocho;
        private System.Windows.Forms.Button Nueve;
        private System.Windows.Forms.Button Cuatro;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.Button Dos;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Cero;
        private System.Windows.Forms.TextBox historial;
    }
}

