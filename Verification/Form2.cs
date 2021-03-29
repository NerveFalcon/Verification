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
	public partial class Form2 : Form
	{
		readonly RadioButton[] radios;
		private double Num1 {
			get { return Convert.ToDouble(num1.Value); }
			set { num1.Value = Convert.ToDecimal(value); }
		}
		private double Num2
		{
			get { return Convert.ToDouble(num2.Value); }
			set { num2.Value = Convert.ToDecimal(value); }
		}

		public Form2()
		{
			InitializeComponent();
			radios = new[]
			{
				rAdd,
				rSub,
				rMul,
				rDiv,
				rPow,
				rMod
			};
		}

		private void Solve(object sender, EventArgs e)
		{
			string operation = "";
			for (int i = 0; i < radios.Length; i++)
			{
				if (radios[i].Checked)
				{
					switch (i)
					{
						case 0:
							Add();
							operation = "Addition";
							break;
						case 1:
							Sub();
							operation = "Subtraction";
							break;
						case 2:
							Mul();
							operation = "Multiplication";
							break;
						case 3:
							Div();
							operation = "Division";
							break;
						case 4:
							Pow();
							operation = "Power";
							break;
						case 5:
							Mod();
							operation = "Modulo";
							break;
						default:
							break;
					}
				}
			}
			var t = new Translate();
			t.label1.Text = operation;
			t.Show();
		}

		private void Add()
		{
			lOp.Text = "+";
			Result((Num1 + Num2).ToString());
		}

		private void Sub()
		{
			lOp.Text = "-";
			Result((Num1 - Num2).ToString());
		}

		private void Mul()
		{
			lOp.Text = "*";
			Result((Num1 * Num2).ToString());
		}

		private void Div()
		{
			lOp.Text = "/";
			Result((Num1 / Num2).ToString());
		}

		private void Mod()
		{
			lOp.Text = "%";
			Result((Num1 % Num2).ToString());
		}

		private void Pow()
		{
			lOp.Text = "Pow";
			Result(Math.Pow(Num1, Num2).ToString());
		}

		private void Clear(object sender, EventArgs e)
		{
			Num1 = Num2 = 0;
			Result("");
			lOp.Text = "+";
			rAdd.Checked = true;
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
