using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson2_02._03._2024
{
    public partial class MainForm : Form
    {
        private bool drag = false;
        private Point startPoint;
        AdministratorForm administratorForm = new AdministratorForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitApp_MouseEnter(object sender, EventArgs e)
        {
            ExitApp.BackColor = Color.Red;
        }

        private void ExitApp_MouseLeave(object sender, EventArgs e)
        {
            ExitApp.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void MinimizeApp_MouseEnter(object sender, EventArgs e)
        {
            MinimizeApp.BackColor = Color.RoyalBlue;
        }

        private void MinimizeApp_MouseLeave(object sender, EventArgs e)
        {
            MinimizeApp.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void OpenAdminstForm_Click(object sender, EventArgs e)
        {
            administratorForm.ShowDialog();
        }
    }
}
