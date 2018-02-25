using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CAYAmat;

public class Form2 : Form
{
	private IContainer components = null;

	private ProgressBar progressBar1;

	private Timer timer1;

	private Label label1;

	public Form2()
	{
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		progressBar1.Increment(1);
		if (progressBar1.Value == 100)
		{
			timer1.Stop();
		}
	}

	private void progressBar1_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAYAmat.Form2));
		this.progressBar1 = new System.Windows.Forms.ProgressBar();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.progressBar1.Location = new System.Drawing.Point(211, 393);
		this.progressBar1.Name = "progressBar1";
		this.progressBar1.Size = new System.Drawing.Size(428, 23);
		this.progressBar1.TabIndex = 0;
		this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
		this.timer1.Enabled = true;
		this.timer1.Interval = 32;
		this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
		this.label1.AutoSize = true;
		this.label1.BackColor = System.Drawing.Color.Black;
		this.label1.Font = new System.Drawing.Font("Calibri", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
		this.label1.ForeColor = System.Drawing.Color.Snow;
		this.label1.Location = new System.Drawing.Point(367, 419);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(115, 24);
		this.label1.TabIndex = 1;
		this.label1.Text = "Yükleniyor....";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		base.ClientSize = new System.Drawing.Size(847, 499);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.progressBar1);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Form2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Form2";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
