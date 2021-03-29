using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verification
{
	public partial class Form1 : Form
	{
		private double Num1 {
			get { return Convert.ToDouble(num1.Value); }
			set { num1.Value = Convert.ToDecimal(value); }
		}
		private double Num2
		{
			get { return Convert.ToDouble(num2.Value); }
			set { num2.Value = Convert.ToDecimal(value); }
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Add(object sender, EventArgs e)
		{
			lOp.Text = "+";
			Result((Num1 + Num2).ToString());
		}

		private void Sub(object sender, EventArgs e)
		{
			lOp.Text = "-";
			Result((Num1 - Num2).ToString());
		}

		private void Mul(object sender, EventArgs e)
		{
			lOp.Text = "*";
			Result((Num1 * Num2).ToString());
		}

		private void Div(object sender, EventArgs e)
		{
			lOp.Text = "/";
			Result((Num1 / Num2).ToString());
		}

		private void Mod(object sender, EventArgs e)
		{
			lOp.Text = "%";
			Result((Num1 % Num2).ToString());
		}

		private void Pow(object sender, EventArgs e)
		{
			lOp.Text = "Pow";
			Result(Math.Pow(Num1, Num2).ToString());
		}

		private void Clear(object sender, EventArgs e)
		{
			Num1 = Num2 = 0;
			Result("");
			lOp.Text = "+";
		}

		private void Result(string output)
		{
			lRes.Text = "= " + output;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
