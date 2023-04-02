using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Builder1.Builder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Builder1
{
    public partial class Form1 : Form
    {
        private BreadDirector director;
        private BreadBuilder builder;
        public Form1()
        {
            InitializeComponent();
            director = new BreadDirector();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            builder = new SourdoughBreadBuilder();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            builder = new WhiteBreadBuilder();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            builder = new WheatBreadBuilder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ingredient = textBox1.Text;
            builder.AddIngredient(ingredient);
            listBox1.Items.Add(ingredient);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bread bread = director.MakeBread(builder);
            
            MessageBox.Show($"Ваш {bread.FlourType} хліб з {string.Join(", ", bread.Ingredients)} готовий!");
            /*RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show($"Ваш {radioButton.Text} хліб з {string.Join(", ", bread.Ingredients)} готовий!");
            }*/
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            builder = new SourdoughBreadBuilder();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            builder = new WhiteBreadBuilder();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            builder = new WheatBreadBuilder();
        }
    }
}
