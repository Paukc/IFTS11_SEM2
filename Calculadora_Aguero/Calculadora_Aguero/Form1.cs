using BibliotecaOperaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Aguero
{
    public partial class Calculadora : Form
    {

        private char operacion;
        private double operando1 = 0, operando2 = 0, resultado = 0;

        private Boolean newOperando = true;

        private Stack<char> pila = new Stack<char>();
        private Stack<string> textHistorial = new Stack<string>();

        public Calculadora()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (this.operando1 == '0')
            {
                txtResult.Text = "";
                txtResult.Text += boton.Text;
                this.newOperando = true;
            }
            else if (txtResult.Text.Length > 1 && txtResult.Text.Length - 1 == ',')
            {
                txtResult.Text += boton.Text;
                this.operando1 = Convert.ToDouble(txtResult.Text);
                this.newOperando = true;
            }
            else if (this.newOperando || txtResult.Text.Equals("0"))
            {
                txtResult.Text = "";
                txtResult.Text += boton.Text;
                this.newOperando = false;
            }
            else
            {
                txtResult.Text += boton.Text;
            }
  
        }

        private void agregarOperador(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            operacion = Convert.ToChar(boton.Text);

            txtResult.Text = "0";
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0" ;
            this.operacion = '<';
            this.operando1 = 0;
            this.resultado = 0;
            this.newOperando = true;
            textHistorial.Clear();
            txtResult.Focus();

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            this.newOperando = true;
            pila.Push('C');
            //textHistorial.Append<char>'';
            txtResult.Focus();

        }

        private void Percentage_Click(object sender, EventArgs e)
        {

        }

        private void Igual_Click(object sender, EventArgs e)
        {
            this.operando1 = Convert.ToDouble(txtResult.Text);
            this.operando2 = Convert.ToDouble(txtResult.Text);

            if (this.operacion == '+')
            {
                txtResult.Text = "";
                this.resultado = Operaciones.Suma(this.operando1, this.operando2);
                txtResult.Text = this.resultado.ToString();
                this.operando1 = this.resultado;
                this.operacion = '<';
            }
            else if (this.operacion == '-')
            {
                txtResult.Text = "";
                this.resultado = Operaciones.Resta(this.operando1, this.operando2);
                txtResult.Text = this.resultado.ToString();
                this.operando1 = this.resultado;
                this.operacion = '<';
            }
            else if (this.operacion == '/')
            {
                txtResult.Text = "";
                if (txtResult.Text == "No se puede dividir por cero")
                {
                    this.operando1 = 0;
                    this.operando2 = 0;
                    this.resultado = 0;
                    this.operacion = '<';
                }
                else
                {
                    txtResult.Text = Operaciones.Division(this.operando1, this.operando2);
                    this.resultado = Convert.ToDouble(txtResult.Text);
                    this.operando1 = this.resultado;
                    this.operacion = '<';
                }
                
            }
            else if (this.operacion == '*')
            {
                txtResult.Text = "";
                this.resultado = Operaciones.Multiplicacion(this.operando1, this.operando2);
                txtResult.Text = this.resultado.ToString();
                this.operando1 = this.resultado;
                this.operacion = '<';
            }
            else if (this.operacion == '%')
            {
                txtResult.Text = "";
                this.resultado = Operaciones.Percentage(this.operando1, this.operando2);
                txtResult.Text = this.resultado.ToString();
                this.operando1 = this.resultado;
                this.operacion = '<';
            }


        }


        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void historial_Txt(object sender, EventArgs e)
        {
            textHistorial.Push(this.operando1.ToString());
            textHistorial.Push(this.operacion.ToString());
            textHistorial.Push(this.newOperando.ToString());
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtResult.Text = "0";
            }
        }

        private void SignCh_Click(object sender, EventArgs e)
        {
            this.operando1 = Convert.ToDouble(txtResult.Text);
            this.operando1 *= -1;
            txtResult.Text = this.operando1.ToString();
            this.operando1 = Convert.ToDouble(txtResult.Text);
        }

        private void txtHistorial_TextChanged(object sender, EventArgs e)
        {
            historial.Text = textHistorial.ToString();

        }

        private void Cero_Click(object sender, EventArgs e)
        {

        }

        private void Coma_Click(object sender, EventArgs e)
        { 
            if (! txtResult.Text.Contains("."))
            {
                txtResult.Text += ",";
            }

        }

    }
}
