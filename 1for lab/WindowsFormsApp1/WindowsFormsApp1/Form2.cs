using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form2 : Form
	{
		

		



		int count = 0; 
		int max = 10; 
		int res; 
		Questions[] q1;

		class Questions 
		{
			private string qustion;

			public string Qustion
			{
				get { return qustion; }
				set { qustion = value; }
			}
			private string answer1;

			public string Answer1
			{
				get { return answer1; }
				set { answer1 = value; }
			}
			private string answer2;

			public string Answer2
			{
				get { return answer2; }
				set { answer2 = value; }
			}
			private string answer3;

			public string Answer3
			{
				get { return answer3; }
				set { answer3 = value; }
			}
			private string answer4;

			public string Answer4
			{
				get { return answer4; }
				set { answer4 = value; }
			}
			private string res;
			public string Res
			{
				get { return res; }
				set { res = value; }
			}

			public Questions(string _question, string a, string b, string c, string d, string r)
			{
				this.qustion = _question;
				this.answer1 = a;
				this.answer2 = b;
				this.answer3 = c;
				this.answer4 = d;
				this.res = r;
			}
		}
		public Form2()
		{
			InitializeComponent();

			Questions[] q = {


				new Questions("1.Who is the villain who killed Gwen Stacy, Spider-man's first Love?", "a.Green Goblin", "b.Doctor Octopus", "c.Vulture", "d.Hobgoblin", "a"),
			    new Questions("2.Who was the first Herald of Galactus to be encountered by the inhabitants of the planet Earth??", "a.Gabriel the Air-Walker", "b.Fire Lord", "c.Terrax the tamer", "d.Silver Surfer", "d"),
				new Questions("3.One of the most popular characters in the Marvel universe is the mutant known as Wolverine. In what comic did Wolverine make his first full appearance?", "a.X-men days of future past", "b.X-men apoclypse", "c.Winter solider", "d.X-men 2", "a"),
				new Questions("4.Who was the founder and creator of the superhero group The Uncanny X-Men?", "a.Project X", "b.Professor X", "c.Cyclops", "d.Magneto", "d"),
				new Questions("5.In recent days, the character of Iron-Man has become more popular than ever. In what comic (Title only) did he make his first appearance, and what color was his armor?", "a.Avengers", "b.Iron man 2", "c.Hulk", "d.Gurdians of the galaxy", "a"),
				new Questions("6.This Character was exposed to a massive dose of gamma radiation, and became a sometimes superhuman powerhouse. Who is this green behemoth?", "a.Deadpool", "b.Hulk", "c.Loki", "d.Doctor strange", "b"),
				new Questions("7.In what somewhat obscure comic did the character of Saber-tooth make his first appearance?", "a.The Eternals", "b.Tales to Astonish", "c.Captain Marvel", "d.Iron Fist", "d"),
				new Questions("8.One of Iron Man's greatest and oldest foes is the Mandarin. From where did he get his power?", "a.Amulet","b.Necklace", "c.Rings", "d.Crown", "c"),
				new Questions("9.How did the Fantastic Four obtain their powers?", "a.From Space", "b.Immortal", "c.Wake up from dead", "d.It was a gift", "a"),
				new Questions("10.What is the name of the team  Starlord is in?", "a.Gurdians of the Galaxy", "b.Avengers", "c.Thor", "d.IronMan", "a")




			};
			q1 = q;
			
			label1.Text = q[0].Qustion;
			
			radioButton1.Text = q[0].Answer1;
			radioButton2.Text = q[0].Answer2;
			radioButton3.Text = q[0].Answer3;
			radioButton4.Text = q[0].Answer4;
		}



		

		private void button2_Click_1(object sender, EventArgs e)
		{
			if (count < max) 
			{
				
				if (radioButton1.Checked == true)
				{
					if (q1[count].Res == "a")
					{ res++; } 
				}
				if (radioButton2.Checked == true)
				{
					if (q1[count].Res == "b")
					{ res++; }
				}
				if (radioButton3.Checked == true)
				{
					if (q1[count].Res == "c")
					{ res++; }
				}
				if (radioButton4.Checked == true)
				{
					if (q1[count].Res == "d")
					{ res++; }
				}
				count++;
				if (count < max)
				{
					label1.Text = q1[count].Qustion;
					radioButton1.Text = q1[count].Answer1;
					radioButton2.Text = q1[count].Answer2;
					radioButton3.Text = q1[count].Answer3;
					radioButton4.Text = q1[count].Answer4;
				}
				else
				{
					button1.Enabled = false;
					label2.Text = "Correct answers: " + Convert.ToString(res);
				}

			}
	
		}



		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f1 = new Form1();
			f1.Show();
		}


	}
}

