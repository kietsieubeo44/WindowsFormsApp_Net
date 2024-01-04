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
    public partial class Form1 : Form
    {
        formmenu1 menu1;
        formmenu2 menu2;

        formbtn1 btn1;
        formbtn2 btn2;
        formbtn3 btn3;
     
        public Form1()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                ContainerMenu.Height += 10;
                if (ContainerMenu.Height >= 165)
                {

                    timerMenu.Stop();
                    menuExpand = true;

                }
            }
            else
            {
                ContainerMenu.Height -= 10;
                if (ContainerMenu.Height <= 52)
                {
                    timerMenu.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click_1(object sender, EventArgs e)
        {
            timerMenu.Start();
        }


        bool sidebarExpand = true;

        private void sidebarTran_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 8;
                if (sidebar.Width <= 52)
                {
                    sidebarExpand = false;
                    sidebarTran.Stop();
                    pnl1.Width = sidebar.Width;
                    pnl3.Width = sidebar.Width;
                    pnl4.Width = sidebar.Width;

                    ContainerMenu.Width = sidebar.Width;

                }
            }
            else
            {
                sidebar.Width += 8;
                if (sidebar.Width >= 275)
                {
                    sidebarExpand = true;
                    sidebarTran.Stop();


                    pnl1.Width = sidebar.Width;
                    pnl3.Width = sidebar.Width;
                    pnl4.Width = sidebar.Width;

                    ContainerMenu.Width = sidebar.Width;

                }
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            sidebarTran.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        // 
        private void button4_Click(object sender, EventArgs e)
        {
            if (btn1 == null)
            {
                btn1 = new formbtn1();
                btn1.FormClosed += Btn1_FormClosed;
                btn1.MdiParent = this;
                btn1.Show();
            }
            else
            {
                btn1.Activate();
            }
        }

        private void Btn1_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn1 = null;
        }



        private void btnMenu1_Click(object sender, EventArgs e)
        {
            if (menu1 == null)
            {
                menu1 = new formmenu1();
                menu1.FormClosed += menu1_FormClosed;
                menu1.MdiParent = this;
                menu1.Dock = DockStyle.Fill;
                menu1.Show();
            }
            else
            {
                menu1.Activate();
            }
        }
        private void menu1_FormClosed(object sender, FormClosedEventArgs e)
        {

            btn1 = null;
        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }
    }
}
