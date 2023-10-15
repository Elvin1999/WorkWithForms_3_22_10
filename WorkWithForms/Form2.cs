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
    public partial class Form2 : Form
    {
        public Form2(string data)
        {
            InitializeComponent();
            label1.Text = data;
        }
        public string Data { get; set; }

        //public string Data
        //{
        //    get
        //    {
        //        return label1?.Text;
        //    }
        //    set
        //    {
        //        label1.Text = value;
        //    }
        //}


        public User UserData
        {
            set { label1.Text = $"{value.Name} {value.Surname} {value.Age}"; }
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Data;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //label1.Text = Data;
        }

        public DialogResult ShowDialog(string data)
        {
            label1.Text = data;
            return ShowDialog();
        }
        public EventHandler<EventArgs> Handler { get; set; }
        private void sendBtn_Click(object sender, EventArgs e)
        {
            Data = dataTxtb.Text;
            Handler.Invoke(sender, e);
        }

        private void dataTxtb_TextChanged(object sender, EventArgs e)
        {
            Data = dataTxtb.Text;
            Handler.Invoke(sender, e);
        }
    }
}
