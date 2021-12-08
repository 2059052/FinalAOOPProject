using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAOOPProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnQuestionsBank_Click(object sender, EventArgs e)
        {
            FormQuesBank frm = new FormQuesBank();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            FormCreateQuiz frm = new FormCreateQuiz();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            FormScore frm = new FormScore();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
