using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoTest
{
    public partial class uscQuestion : UserControl
    {
        private int currentQuestionIndex = 0;
        //public delegate void uscQuestion_ChangeQuestionHandle();
        //public event uscQuestion_ChangeQuestionHandle changeQuestion;
        public uscQuestion()
        {
            InitializeComponent();
        }
        public void setQuesAndRadioText()
        {
            lbQuestion.Text = Form1.ListQuestions[currentQuestionIndex].content;
            rbA.Text = Form1.ListQuestions[currentQuestionIndex].Options[0].Text;
            rbB.Text = Form1.ListQuestions[currentQuestionIndex].Options[1].Text;
            rbC.Text = Form1.ListQuestions[currentQuestionIndex].Options[2].Text;
            rbD.Text = Form1.ListQuestions[currentQuestionIndex].Options[3].Text;
        }
        public void chooseAnswer()
        {
            if (rbA.Checked)
                ListAnswer.Answers[currentQuestionIndex] = "A";
            else if (rbB.Checked)
                ListAnswer.Answers[currentQuestionIndex] = "B";
            else if (rbC.Checked)
                ListAnswer.Answers[currentQuestionIndex] = "C";
            else if (rbD.Checked)
                ListAnswer.Answers[currentQuestionIndex] = "D";
            else
                return;
        }
        public void checkAnswer()
        {
            if(ListAnswer.Answers[currentQuestionIndex] != "")
            {
                if (ListAnswer.Answers[currentQuestionIndex] == "A")
                {
                    rbA.Checked = true;
                }
                else if (ListAnswer.Answers[currentQuestionIndex] == "B")
                {
                    rbB.Checked = true;
                }
                else if (ListAnswer.Answers[currentQuestionIndex] == "C")
                {
                    rbC.Checked = true;
                }
                else if (ListAnswer.Answers[currentQuestionIndex] == "D")
                {
                    rbD.Checked = true;
                }
            }
            else
            {
                rbA.Checked = false;
                rbB.Checked = false;
                rbC.Checked = false;
                rbD.Checked = false;
            }
        }

        public void LoadQA()
        {
            if (currentQuestionIndex == Form1.ListQuestions.Count-1)
            {
                btnNext.Enabled = false;
                btnBack.Enabled = true;
                setQuesAndRadioText();
                checkAnswer();
            }
            else if (currentQuestionIndex == 0)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
                setQuesAndRadioText();
                checkAnswer();
            }
            else
            {
                btnNext.Enabled = true;
                btnBack.Enabled = true;
                setQuesAndRadioText();
                checkAnswer();
            }
        }
        public void Start()
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;

            rbA.Enabled = true;
            rbB.Enabled = true;
            rbC.Enabled = true;
            rbD.Enabled = true;

            LoadQA();
            btnNext.Enabled = true;
        }
     
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            if (currentQuestionIndex <= Form1.ListQuestions.Count-1)
            {
                this.currentQuestionIndex--;
                LoadQA();
            }
            //changeQuestion();
        }

        

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex >= 0)
            {
                this.currentQuestionIndex++;
                LoadQA();
            }
            //changeQuestion();
        }

        private void rbA_CheckedChanged(object sender, EventArgs e)
        {
            ListAnswer.Answers[currentQuestionIndex] = "A";
        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {
            ListAnswer.Answers[currentQuestionIndex] = "B";
        }

        private void rbC_CheckedChanged(object sender, EventArgs e)
        {
            ListAnswer.Answers[currentQuestionIndex] = "C";
        }

        private void rbD_CheckedChanged(object sender, EventArgs e)
        {
            ListAnswer.Answers[currentQuestionIndex] = "D";
        }
    }
}
