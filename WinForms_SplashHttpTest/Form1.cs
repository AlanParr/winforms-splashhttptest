using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;

namespace WinForms_SplashHttpTest
{
    public partial class Form1 : Form
    {
        private SplashNancyHost _host;
        private SplashController _controller;

        public Form1()
        {
            InitializeComponent();
            _controller = SplashController.CreateInstance(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _host = new SplashNancyHost();
            textBox1.Text = $"Post to {_host.Url}/hide to hide splash." + Environment.NewLine;
            textBox1.Text += $"Post to {_host.Url}/show to show splash.";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _host.Start();
            _controller.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _host.Stop();
        }
    }
}
