using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DoTest
{
    public partial class Form1 : Form
    {
        int id;
        public static List<Question> ListQuestions = new List<Question>();
        
        public Form1()
        {
            InitializeComponent();
            uscClock.uscEClock_Exit += new uscClock.uscEClock_ExitHandle(uscClock_uscEClock_Exit);
            //uscQuestion.changeQuestion += UscQuestion_changeQuestion;
        }

        //private void UscQuestion_changeQuestion()
        //{
        //    for(int i = 0; i < ListAnswer.Answers.Count; i++)
        //    {
        //        if (ListAnswer.Answers[i] == "")
        //            ((Button)pnAnswer.Controls[i]).Enabled = true;
        //        else
        //            ((Button)pnAnswer.Controls[i]).Enabled = false;
        //    }
        //}

        void uscClock_uscEClock_Exit()
        {
            uscClock.Stop();
            MessageBox.Show("Over time", "EClock Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int s = ListQuestions.Count * 15;
            int m = s / 60;
            int temp = m;
            s -= m * 60;
            uscClock._mm = m;
            uscClock._ss = s;
            uscClock.Start();
            btnStart.Enabled = false;
            uscQuestion.Start();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Chon tap tin .xml|*.xml";
            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                // mở tập tin để đọc
                XmlReader reader = XmlReader.Create(filePath);
                reader.ReadToFollowing("Questions");
                reader.MoveToAttribute("id");
                id = int.Parse(reader.Value);

                while (reader.ReadToFollowing("Question"))
                {
                    Question question = new Question();
                    Option o1 = new Option();
                    Option o2 = new Option();
                    Option o3 = new Option();
                    Option o4 = new Option();

                    reader.ReadToFollowing("Content");
                    question.content = reader.ReadElementContentAsString();

                    reader.ReadToFollowing("Option");
                    o1.Text = reader.ReadElementContentAsString();

                    reader.ReadToFollowing("Option");
                    o2.Text = reader.ReadElementContentAsString();

                    reader.ReadToFollowing("Option");
                    o3.Text = reader.ReadElementContentAsString();

                    reader.ReadToFollowing("Option");
                    o4.Text = reader.ReadElementContentAsString();

                    question.Options.Add(o1);
                    question.Options.Add(o2);
                    question.Options.Add(o3);
                    question.Options.Add(o4);
                    ListQuestions.Add(question);

                }
                reader.Close();
                btnStart.Enabled = true;
                btnSubmit.Enabled = true;


                ListAnswer.Answers.Clear();
                for(int i = 0; i < ListQuestions.Count; i++)
                {
                    ListAnswer.Answers.Add("");
                    //Button btn = new Button();
                    //btn.Text = "Cau "+ i.ToString();
                    //btn.Location =new Point( i * btn.Width + 1,btn.Location.Y);
                    //pnAnswer.Controls.Add(btn);
                }
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text) || !String.IsNullOrEmpty(txtStudentID.Text))
            {

                SaveFileDialog dlg = new SaveFileDialog();
                // chỉ lưu tập tin dạng .txt
                dlg.Filter = "Luu tap tin .xml|*.xml";
                // hiển thị hộp thoại
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // lấy đường dẫn tập tin sẽ lưu
                    string filePath = dlg.FileName;
                    // mở tập tin để lưu 
                    XmlWriter writer = XmlWriter.Create(filePath, new XmlWriterSettings() { Indent = true });


                    //them info sv 
                    writer.WriteStartElement("info");
                    writer.WriteAttributeString("name", txtName.Text);
                    writer.WriteAttributeString("studentid", txtStudentID.Text);
                    DateTime d = DateTime.Now;
                    writer.WriteAttributeString("time", d.ToString());
                    writer.WriteStartElement("Questions");
                    writer.WriteAttributeString("id", id.ToString());

                    for (int i = 0; i < ListAnswer.Answers.Count; i++)
                    {
                        writer.WriteStartElement("Question");

                        writer.WriteStartElement("Option");
                        writer.WriteValue(ListAnswer.Answers[i].ToString());
                        writer.WriteEndElement();

                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.Close();
                    this.Close();
                }
            }
            else
                MessageBox.Show("please insert name and id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
