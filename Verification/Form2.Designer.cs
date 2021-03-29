
namespace Verification
{
	partial class Form2
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label lNum1;
			System.Windows.Forms.Label lNum2;
			this.lOp = new System.Windows.Forms.Label();
			this.lRes = new System.Windows.Forms.Label();
			this.num1 = new System.Windows.Forms.NumericUpDown();
			this.num2 = new System.Windows.Forms.NumericUpDown();
			this.bClear = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rSub = new System.Windows.Forms.RadioButton();
			this.rMul = new System.Windows.Forms.RadioButton();
			this.rMod = new System.Windows.Forms.RadioButton();
			this.rPow = new System.Windows.Forms.RadioButton();
			this.rDiv = new System.Windows.Forms.RadioButton();
			this.rAdd = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			lNum1 = new System.Windows.Forms.Label();
			lNum2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lNum1
			// 
			lNum1.AutoSize = true;
			lNum1.Location = new System.Drawing.Point(12, 21);
			lNum1.Name = "lNum1";
			lNum1.Size = new System.Drawing.Size(48, 13);
			lNum1.TabIndex = 2;
			lNum1.Text = "Число 1";
			// 
			// lNum2
			// 
			lNum2.AutoSize = true;
			lNum2.Location = new System.Drawing.Point(159, 20);
			lNum2.Name = "lNum2";
			lNum2.Size = new System.Drawing.Size(48, 13);
			lNum2.TabIndex = 3;
			lNum2.Text = "Число 2";
			// 
			// lOp
			// 
			this.lOp.AutoSize = true;
			this.lOp.Location = new System.Drawing.Point(132, 43);
			this.lOp.Name = "lOp";
			this.lOp.Size = new System.Drawing.Size(13, 13);
			this.lOp.TabIndex = 4;
			this.lOp.Text = "+";
			// 
			// lRes
			// 
			this.lRes.AutoSize = true;
			this.lRes.Location = new System.Drawing.Point(287, 42);
			this.lRes.Name = "lRes";
			this.lRes.Size = new System.Drawing.Size(13, 13);
			this.lRes.TabIndex = 5;
			this.lRes.Text = "=";
			// 
			// num1
			// 
			this.num1.Location = new System.Drawing.Point(15, 40);
			this.num1.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
			this.num1.Name = "num1";
			this.num1.Size = new System.Drawing.Size(100, 20);
			this.num1.TabIndex = 1;
			// 
			// num2
			// 
			this.num2.Location = new System.Drawing.Point(161, 40);
			this.num2.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
			this.num2.Name = "num2";
			this.num2.Size = new System.Drawing.Size(100, 20);
			this.num2.TabIndex = 2;
			// 
			// bClear
			// 
			this.bClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bClear.Location = new System.Drawing.Point(186, 77);
			this.bClear.Name = "bClear";
			this.bClear.Size = new System.Drawing.Size(75, 23);
			this.bClear.TabIndex = 9;
			this.bClear.Text = "Очистить";
			this.bClear.UseVisualStyleBackColor = true;
			this.bClear.Click += new System.EventHandler(this.Clear);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rSub);
			this.groupBox1.Controls.Add(this.rMul);
			this.groupBox1.Controls.Add(this.rMod);
			this.groupBox1.Controls.Add(this.rPow);
			this.groupBox1.Controls.Add(this.rDiv);
			this.groupBox1.Controls.Add(this.rAdd);
			this.groupBox1.Location = new System.Drawing.Point(15, 77);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(158, 159);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Выберите операцию";
			// 
			// rSub
			// 
			this.rSub.AutoSize = true;
			this.rSub.Location = new System.Drawing.Point(6, 40);
			this.rSub.Name = "rSub";
			this.rSub.Size = new System.Drawing.Size(80, 17);
			this.rSub.TabIndex = 5;
			this.rSub.Text = "Вычитание";
			this.rSub.UseVisualStyleBackColor = true;
			// 
			// rMul
			// 
			this.rMul.AutoSize = true;
			this.rMul.Location = new System.Drawing.Point(6, 63);
			this.rMul.Name = "rMul";
			this.rMul.Size = new System.Drawing.Size(85, 17);
			this.rMul.TabIndex = 4;
			this.rMul.Text = "Умножение";
			this.rMul.UseVisualStyleBackColor = true;
			// 
			// rMod
			// 
			this.rMod.AutoSize = true;
			this.rMod.Location = new System.Drawing.Point(6, 130);
			this.rMod.Name = "rMod";
			this.rMod.Size = new System.Drawing.Size(126, 17);
			this.rMod.TabIndex = 3;
			this.rMod.Text = "Остаток от деления";
			this.rMod.UseVisualStyleBackColor = true;
			// 
			// rPow
			// 
			this.rPow.AutoSize = true;
			this.rPow.Location = new System.Drawing.Point(6, 107);
			this.rPow.Name = "rPow";
			this.rPow.Size = new System.Drawing.Size(139, 17);
			this.rPow.TabIndex = 2;
			this.rPow.Text = "Возведение в степень";
			this.rPow.UseVisualStyleBackColor = true;
			// 
			// rDiv
			// 
			this.rDiv.AutoSize = true;
			this.rDiv.Location = new System.Drawing.Point(7, 86);
			this.rDiv.Name = "rDiv";
			this.rDiv.Size = new System.Drawing.Size(70, 17);
			this.rDiv.TabIndex = 1;
			this.rDiv.Text = "Деление";
			this.rDiv.UseVisualStyleBackColor = true;
			// 
			// rAdd
			// 
			this.rAdd.AutoSize = true;
			this.rAdd.Checked = true;
			this.rAdd.Location = new System.Drawing.Point(6, 19);
			this.rAdd.Name = "rAdd";
			this.rAdd.Size = new System.Drawing.Size(76, 17);
			this.rAdd.TabIndex = 0;
			this.rAdd.TabStop = true;
			this.rAdd.Text = "Сложение";
			this.rAdd.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(186, 114);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Вычислить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Solve);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 317);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.bClear);
			this.Controls.Add(this.num2);
			this.Controls.Add(this.num1);
			this.Controls.Add(this.lRes);
			this.Controls.Add(this.lOp);
			this.Controls.Add(lNum2);
			this.Controls.Add(lNum1);
			this.Name = "Form2";
			this.Text = "Лабораторная работа";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lOp;
		private System.Windows.Forms.Label lRes;
		private System.Windows.Forms.NumericUpDown num1;
		private System.Windows.Forms.NumericUpDown num2;
		private System.Windows.Forms.Button bClear;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rSub;
		private System.Windows.Forms.RadioButton rMul;
		private System.Windows.Forms.RadioButton rMod;
		private System.Windows.Forms.RadioButton rPow;
		private System.Windows.Forms.RadioButton rDiv;
		private System.Windows.Forms.RadioButton rAdd;
		private System.Windows.Forms.Button button1;
	}
}

