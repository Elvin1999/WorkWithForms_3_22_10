using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithForms
{
    public partial class Form1 : Form
    {
        public EventHandler<EventArgs> Handler { get; set; }
        public Form1()
        {
            InitializeComponent();
            Handler = new EventHandler<EventArgs>(SetTextEvent);
            //Send data from Parent To Child
            //1. By Constructor
            //2. By Property
            //3. By ShowDialog override method
        }
        Form2 Form2=new Form2();
        public void SetTextEvent(object sender, EventArgs e)
        {
            textBox1.Text = Form2.Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //From Child
            Form2.Handler=Handler;
            Form2.Show();


            //this.Hide();
            //Form2 form2=new Form2();
            //if (form2.ShowDialog() == DialogResult.Cancel)
            //{
            //    this.Show();
            //}


            // By Constructor
            //var data = textBox1.Text;
            //Form2 form2 = new Form2(data);
            //form2.ShowDialog();


            //By Property
            //var data = textBox1.Text;
            //Form2 form2=new Form2();
            //form2.Data = data;
            //form2.ShowDialog();


            //By ShowDialog
            //var data = textBox1.Text;
            //Form2 form2 = new Form2();
            //form2.ShowDialog(data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = nameTxtb.Text,
                Surname = surnameTxtb.Text,
                Age = int.Parse(maskedTextBox1.Text)
            };

            Form2 form2 = new Form2();
            form2.UserData = user;
            form2.Show();
        }
    }
}
