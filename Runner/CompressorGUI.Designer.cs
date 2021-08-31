﻿
namespace Runner
{
	partial class CompressorGUI
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 260);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(210, 61);
			this.button1.TabIndex = 0;
			this.button1.Text = "Encode";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.compress_button);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(257, 261);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(281, 61);
			this.button2.TabIndex = 1;
			this.button2.Text = "Display Compressed Image";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Display_button);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 191);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(776, 40);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(573, 261);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(215, 60);
			this.button3.TabIndex = 3;
			this.button3.Text = "Decompress Image";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.decompress_click);
			// 
			// CompressorGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "CompressorGUI";
			this.Text = "DCI Compressor (Displayable Compressed Image)";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button3;
	}
}

