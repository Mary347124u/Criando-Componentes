/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 28/04/2021
 * Time: 15:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CriandoComponentes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		Label lab1 = new Label();
		Label lab2 = new Label();
		Label lab3 = new Label();
		TextBox txt1 = new TextBox();
		TextBox txt2 = new TextBox();
		Button bt1 = new Button();
		TextBox txt3 = new TextBox();
		void Button1Click(object sender, EventArgs e)
		{
			txt1.Parent=this;
			txt1.BackColor = Color.HotPink;
			txt1.Left = 320;
			txt1.Top=100;
			
			lab1.Parent=this;
			lab1.BackColor = Color.White;
			lab1.Left = 170;
			lab1.Top=100;
			lab1.Text="Primeiro número";
			
			txt2.Parent=this;
			txt2.BackColor = Color.HotPink;
			txt2.Left = 320;
			txt2.Top=150;
			
			lab2.Parent=this;
			lab2.BackColor = Color.White;
			lab2.Left = 170;
			lab2.Top=150;
			lab2.Text="Segundo número";
			
			bt1.Parent=this;
			bt1.Left = 320;
			bt1.Top = 200;
			bt1.Width +=25;
			bt1.Text="soma";
			bt1.Click+=Bt1Click;
			
			txt3.Parent=this;
			txt3.BackColor = Color.HotPink;
			txt3.Left = 320;
			txt3.Top=250;
			
			lab3.Parent=this;
			lab3.BackColor = Color.White;
			lab3.Left = 170;
			lab3.Top=250;
			lab3.Text="Resultado";
			 
		}
		void Bt1Click(object sender, EventArgs e)
		{
			int n1 = int.Parse(txt1.Text);
			int n2 = int.Parse(txt2.Text);
			int s =n1 + n2;
			txt3.Text = s.ToString();
			
		}
		
	}
}
