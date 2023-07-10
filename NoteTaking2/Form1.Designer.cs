namespace NoteTaking2
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
			btnDelete = new Button();
			btnRead = new Button();
			btnSave = new Button();
			btnNew = new Button();
			dataGridView1 = new DataGridView();
			txtMessage = new TextBox();
			txtTitle = new TextBox();
			label2 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(579, 375);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(112, 23);
			btnDelete.TabIndex = 17;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnRead
			// 
			btnRead.Location = new Point(427, 375);
			btnRead.Name = "btnRead";
			btnRead.Size = new Size(112, 23);
			btnRead.TabIndex = 16;
			btnRead.Text = "Read";
			btnRead.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(276, 375);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(112, 23);
			btnSave.TabIndex = 15;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			// 
			// btnNew
			// 
			btnNew.Location = new Point(127, 375);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(112, 23);
			btnNew.TabIndex = 14;
			btnNew.Text = "New";
			btnNew.UseVisualStyleBackColor = true;
			btnNew.Click += btnNew_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(427, 56);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(312, 270);
			dataGridView1.TabIndex = 13;
			// 
			// txtMessage
			// 
			txtMessage.Location = new Point(127, 102);
			txtMessage.Multiline = true;
			txtMessage.Name = "txtMessage";
			txtMessage.Size = new Size(156, 224);
			txtMessage.TabIndex = 12;
			// 
			// txtTitle
			// 
			txtTitle.Location = new Point(127, 53);
			txtTitle.Name = "txtTitle";
			txtTitle.Size = new Size(156, 23);
			txtTitle.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(62, 105);
			label2.Name = "label2";
			label2.Size = new Size(53, 15);
			label2.TabIndex = 10;
			label2.Text = "Message";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(62, 56);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 9;
			label1.Text = "Title";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnDelete);
			Controls.Add(btnRead);
			Controls.Add(btnSave);
			Controls.Add(btnNew);
			Controls.Add(dataGridView1);
			Controls.Add(txtMessage);
			Controls.Add(txtTitle);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnDelete;
		private Button btnRead;
		private Button btnSave;
		private Button btnNew;
		private DataGridView dataGridView1;
		private TextBox txtMessage;
		private TextBox txtTitle;
		private Label label2;
		private Label label1;
	}
}