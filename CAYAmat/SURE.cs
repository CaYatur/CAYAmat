using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CAYAmat;

public class SURE : Form
{
	private int sure = 0;

	private Random x = new Random();

	private int e1;

	private int e2;

	private int cevap;

	private int sonuc;

	private int puan;

	private IContainer components = null;

	private Label label1;

	private Label labelpuan;

	private TextBox E1;

	private TextBox E2;

	private TextBox E3;

	private Label İŞLEM;

	private Label label4;

	private Label label5;

	private Button KONTROL;

	private Button baslat;

	private Button sorugetir;

	private Button TEKRAR;

	private Label ÇAĞAN;

	private Label label2;

	private Label label7;

	private Label label8;

	private DateTimePicker dateTimePicker1;

	private Label label6;

	private System.Windows.Forms.Timer timer1;

	private Label label3;

	private Label PUAN9;

	public SURE()
	{
		Thread thread = new Thread(SplashStart);
		thread.Start();
		Thread.Sleep(5000);
		InitializeComponent();
		thread.Abort();
	}

	public void SplashStart()
	{
		Application.Run(new Form2());
	}

	private void label8_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void baslat_Click(object sender, EventArgs e)
	{
		timer1.Enabled = true;
	}

	private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void bindingSource1_CurrentChanged(object sender, EventArgs e)
	{
	}

	private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		sure++;
		label3.Text = sure.ToString();
		if (sure == 200)
		{
			timer1.Enabled = false;
			sorugetir.Enabled = false;
			KONTROL.Enabled = false;
			baslat.Enabled = false;
		}
	}

	private void E2_TextChanged(object sender, EventArgs e)
	{
	}

	private void PUAN_Click(object sender, EventArgs e)
	{
	}

	private void E3_TextChanged(object sender, EventArgs e)
	{
	}

	private void KONTROL_Click(object sender, EventArgs e)
	{
		cevap = int.Parse(E3.Text);
		if (sonuc == cevap)
		{
			puan += 10;
		}
		else
		{
			puan -= 10;
		}
		PUAN9.Text = puan.ToString();
	}

	private void SÜRE_Click(object sender, EventArgs e)
	{
	}

	private void TEKRAR_Click(object sender, EventArgs e)
	{
		puan = 0;
		baslat.Enabled = true;
		sorugetir.Enabled = true;
		KONTROL.Enabled = true;
		sure = 0;
		PUAN9.Text = puan.ToString();
	}

	private void E1_TextChanged(object sender, EventArgs e)
	{
	}

	private void İŞLEM_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void sorugetir_Click(object sender, EventArgs e)
	{
		e1 = x.Next(1, 20);
		e2 = x.Next(1, 10);
		E1.Text = e1.ToString();
		E2.Text = e2.ToString();
		sonuc = e1 * e2;
		E3.Text = "";
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAYAmat.SURE));
		this.label1 = new System.Windows.Forms.Label();
		this.E1 = new System.Windows.Forms.TextBox();
		this.E2 = new System.Windows.Forms.TextBox();
		this.E3 = new System.Windows.Forms.TextBox();
		this.İŞLEM = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.KONTROL = new System.Windows.Forms.Button();
		this.baslat = new System.Windows.Forms.Button();
		this.sorugetir = new System.Windows.Forms.Button();
		this.TEKRAR = new System.Windows.Forms.Button();
		this.ÇAĞAN = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.label6 = new System.Windows.Forms.Label();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.label3 = new System.Windows.Forms.Label();
		this.PUAN9 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		resources.ApplyResources(this.label1, "label1");
		this.label1.Name = "label1";
		resources.ApplyResources(this.E1, "E1");
		this.E1.BackColor = System.Drawing.Color.Red;
		this.E1.Name = "E1";
		this.E1.TextChanged += new System.EventHandler(this.E1_TextChanged);
		resources.ApplyResources(this.E2, "E2");
		this.E2.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
		this.E2.Name = "E2";
		this.E2.TextChanged += new System.EventHandler(this.E2_TextChanged);
		resources.ApplyResources(this.E3, "E3");
		this.E3.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
		this.E3.ForeColor = System.Drawing.Color.Black;
		this.E3.Name = "E3";
		this.E3.TextChanged += new System.EventHandler(this.E3_TextChanged);
		resources.ApplyResources(this.İŞLEM, "İŞLEM");
		this.İŞLEM.Name = "İŞLEM";
		this.İŞLEM.Click += new System.EventHandler(this.İŞLEM_Click);
		resources.ApplyResources(this.label4, "label4");
		this.label4.Name = "label4";
		this.label4.Click += new System.EventHandler(this.label4_Click);
		resources.ApplyResources(this.label5, "label5");
		this.label5.Name = "label5";
		resources.ApplyResources(this.KONTROL, "KONTROL");
		this.KONTROL.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
		this.KONTROL.Name = "KONTROL";
		this.KONTROL.UseVisualStyleBackColor = false;
		this.KONTROL.Click += new System.EventHandler(this.KONTROL_Click);
		resources.ApplyResources(this.baslat, "baslat");
		this.baslat.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
		this.baslat.Name = "baslat";
		this.baslat.UseVisualStyleBackColor = false;
		this.baslat.Click += new System.EventHandler(this.baslat_Click);
		resources.ApplyResources(this.sorugetir, "sorugetir");
		this.sorugetir.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
		this.sorugetir.Name = "sorugetir";
		this.sorugetir.UseVisualStyleBackColor = false;
		this.sorugetir.Click += new System.EventHandler(this.sorugetir_Click);
		resources.ApplyResources(this.TEKRAR, "TEKRAR");
		this.TEKRAR.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
		this.TEKRAR.Name = "TEKRAR";
		this.TEKRAR.UseVisualStyleBackColor = false;
		this.TEKRAR.Click += new System.EventHandler(this.TEKRAR_Click);
		resources.ApplyResources(this.ÇAĞAN, "ÇAĞAN");
		this.ÇAĞAN.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.ÇAĞAN.Name = "ÇAĞAN";
		resources.ApplyResources(this.label2, "label2");
		this.label2.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.label2.Name = "label2";
		resources.ApplyResources(this.label7, "label7");
		this.label7.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.label7.Name = "label7";
		resources.ApplyResources(this.label8, "label8");
		this.label8.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
		this.label8.Name = "label8";
		resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
		this.dateTimePicker1.Name = "dateTimePicker1";
		resources.ApplyResources(this.label6, "label6");
		this.label6.Name = "label6";
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
		resources.ApplyResources(this.label3, "label3");
		this.label3.Name = "label3";
		resources.ApplyResources(this.PUAN9, "PUAN9");
		this.PUAN9.Name = "PUAN9";
		resources.ApplyResources(this, "$this");
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
		base.Controls.Add(this.PUAN9);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.dateTimePicker1);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.ÇAĞAN);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.TEKRAR);
		base.Controls.Add(this.sorugetir);
		base.Controls.Add(this.baslat);
		base.Controls.Add(this.KONTROL);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.İŞLEM);
		base.Controls.Add(this.E3);
		base.Controls.Add(this.E2);
		base.Controls.Add(this.E1);
		base.Controls.Add(this.label1);
		this.ForeColor = System.Drawing.Color.Red;
		base.Name = "SURE";
		base.Load += new System.EventHandler(this.Form1_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
