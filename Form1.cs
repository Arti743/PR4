using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        
        void openchild(Panel pen, Form empryF)
        {
            empryF.TopLevel = false;
            empryF.FormBorderStyle = FormBorderStyle.None;
            empryF.Dock = DockStyle.Fill;
            pen.Controls.Add(empryF);
            empryF.BringToFront();
            empryF.Show();
        }

        //Переход на другие формы с помощью panel

        private void button_Circle_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormCircle());
        }

        private void button_Member_circle_Click(object sender, EventArgs e)
        {
            openchild(panel2, new MemberCircleForm());
        }

        private void button_Position_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormPosition());
        }

        private void button_Shedule_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormShedule());
        }

        private void button_Teacher_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormTeacher());
        }

        private void button_Type_Circle_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormTypeCircle());
        }
    }
}
