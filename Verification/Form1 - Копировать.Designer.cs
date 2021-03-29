
namespace Verification
{
	partial class Form1
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
			System.Windows.Forms.Label label5;
			this.lOp = new System.Windows.Forms.Label();
			this.lRes = new System.Windows.Forms.Label();
			this.bAdd = new System.Windows.Forms.Button();
			this.bSub = new System.Windows.Forms.Button();
			this.bMul = new System.Windows.Forms.Button();
			this.bDiv = new System.Windows.Forms.Button();
			this.bPow = new System.Windows.Forms.Button();
			this.bMod = new System.Windows.Forms.Button();
			this.num1 = new System.Windows.Forms.NumericUpDown();
			this.num2 = new System.Windows.Forms.NumericUpDown();
			this.bClear = new System.Windows.Forms.Button();
			lNum1 = new System.Windows.Forms.Label();
			lNum2 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
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
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(12, 67);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(110, 13);
			label5.TabIndex = 6;
			label5.Text = "Выберите операцию";
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
			// bAdd
			// 
			this.bAdd.AutoSize = true;
			this.bAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bAdd.Location = new System.Drawing.Point(15, 83);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(23, 23);
			this.bAdd.TabIndex = 3;
			this.bAdd.Text = "+";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.Add);
			// 
			// bSub
			// 
			this.bSub.AutoSize = true;
			this.bSub.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bSub.Location = new System.Drawing.Point(53, 84);
			this.bSub.Name = "bSub";
			this.bSub.Size = new System.Drawing.Size(23, 23);
			this.bSub.TabIndex = 4;
			this.bSub.Text = "-";
			this.bSub.UseVisualStyleBackColor = true;
			this.bSub.Click += new System.EventHandler(this.Sub);
			// 
			// bMul
			// 
			this.bMul.AutoSize = true;
			this.bMul.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bMul.Location = new System.Drawing.Point(98, 84);
			this.bMul.Name = "bMul";
			this.bMul.Size = new System.Drawing.Size(23, 23);
			this.bMul.TabIndex = 5;
			this.bMul.Text = "*";
			this.bMul.UseVisualStyleBackColor = true;
			this.bMul.Click += new System.EventHandler(this.Mul);
			// 
			// bDiv
			// 
			this.bDiv.AutoSize = true;
			this.bDiv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bDiv.Location = new System.Drawing.Point(145, 84);
			this.bDiv.Name = "bDiv";
			this.bDiv.Size = new System.Drawing.Size(23, 23);
			this.bDiv.TabIndex = 6;
			this.bDiv.Text = "/";
			this.bDiv.UseVisualStyleBackColor = true;
			this.bDiv.Click += new System.EventHandler(this.Div);
			// 
			// bPow
			// 
			this.bPow.AutoSize = true;
			this.bPow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bPow.Location = new System.Drawing.Point(183, 84);
			this.bPow.Name = "bPow";
			this.bPow.Size = new System.Drawing.Size(38, 23);
			this.bPow.TabIndex = 7;
			this.bPow.Text = "Pow";
			this.bPow.UseVisualStyleBackColor = true;
			this.bPow.Click += new System.EventHandler(this.Pow);
			// 
			// bMod
			// 
			this.bMod.AutoSize = true;
			this.bMod.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bMod.Location = new System.Drawing.Point(236, 84);
			this.bMod.Name = "bMod";
			this.bMod.Size = new System.Drawing.Size(25, 23);
			this.bMod.TabIndex = 8;
			this.bMod.Text = "%";
			this.bMod.UseVisualStyleBackColor = true;
			this.bMod.Click += new System.EventHandler(this.Mod);
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
			this.bClear.Location = new System.Drawing.Point(15, 123);
			this.bClear.Name = "bClear";
			this.bClear.Size = new System.Drawing.Size(75, 23);
			this.bClear.TabIndex = 9;
			this.bClear.Text = "Очистить";
			this.bClear.UseVisualStyleBackColor = true;
			this.bClear.Click += new System.EventHandler(this.Clear);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 174);
			this.Controls.Add(this.bClear);
			this.Controls.Add(this.num2);
			this.Controls.Add(this.num1);
			this.Controls.Add(this.bMod);
			this.Controls.Add(this.bPow);
			this.Controls.Add(this.bDiv);
			this.Controls.Add(this.bMul);
			this.Controls.Add(this.bSub);
			this.Controls.Add(this.bAdd);
			this.Controls.Add(label5);
			this.Controls.Add(this.lRes);
			this.Controls.Add(this.lOp);
			this.Controls.Add(lNum2);
			this.Controls.Add(lNum1);
			this.Name = "Form1";
			this.Text = "Лабораторная работа";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lOp;
		private System.Windows.Forms.Label lRes;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bSub;
		private System.Windows.Forms.Button bMul;
		private System.Windows.Forms.Button bDiv;
		private System.Windows.Forms.Button bPow;
		private System.Windows.Forms.Button bMod;
		private System.Windows.Forms.NumericUpDown num1;
		private System.Windows.Forms.NumericUpDown num2;
		private System.Windows.Forms.Button bClear;
	}
}

