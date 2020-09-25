namespace LineMax
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
			this.boxFileSearch = new System.Windows.Forms.TextBox();
			this.buttonReview = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.listResult = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// boxFileSearch
			// 
			this.boxFileSearch.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.boxFileSearch.Location = new System.Drawing.Point(25, 36);
			this.boxFileSearch.Multiline = true;
			this.boxFileSearch.Name = "boxFileSearch";
			this.boxFileSearch.Size = new System.Drawing.Size(231, 34);
			this.boxFileSearch.TabIndex = 0;
			this.boxFileSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonReview
			// 
			this.buttonReview.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonReview.Location = new System.Drawing.Point(294, 36);
			this.buttonReview.Name = "buttonReview";
			this.buttonReview.Size = new System.Drawing.Size(76, 33);
			this.buttonReview.TabIndex = 1;
			this.buttonReview.Text = "Review";
			this.buttonReview.UseVisualStyleBackColor = true;
			this.buttonReview.Click += new System.EventHandler(this.Review_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(25, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(345, 42);
			this.button1.TabIndex = 2;
			this.button1.Text = "Find line";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.DataProcessing_Click);
			// 
			// listResult
			// 
			this.listResult.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listResult.Location = new System.Drawing.Point(25, 163);
			this.listResult.Name = "listResult";
			this.listResult.Size = new System.Drawing.Size(345, 311);
			this.listResult.TabIndex = 3;
			this.listResult.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 505);
			this.Controls.Add(this.listResult);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonReview);
			this.Controls.Add(this.boxFileSearch);
			this.Name = "Form1";
			this.Text = "Read from file.";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox boxFileSearch;
		private System.Windows.Forms.Button buttonReview;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox listResult;
	}
}

