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

namespace FinalAOOPProject
{
    public partial class FormCreateQuiz : Form
    {
        public List<Question> ListQuesBank = new List<Question>();
        public List<Question> ListSelectedQues = new List<Question>();
        public FormCreateQuiz()
        {
            InitializeComponent();
        }
        public void LoadFile()
        {
            XmlReader reader = XmlReader.Create("../../QuesBank/QuesBank.xml");
            reader.ReadToFollowing("Questions");

            while (reader.ReadToFollowing("Question"))
            {
                Question question = new Question();
                Option o1 = new Option();
                Option o2 = new Option();
                Option o3 = new Option();
                Option o4 = new Option();

                reader.ReadToFollowing("Content");
                question.content = reader.ReadElementContentAsString();

                reader.ReadToFollowing("Topic");
                question.topic = reader.ReadElementContentAsString();

                reader.ReadToFollowing("Option");
                o1.Text = reader.ReadElementContentAsString();
                o1.isTrue = true;

                reader.ReadToFollowing("Option");
                o2.Text = reader.ReadElementContentAsString();
                o2.isTrue = false;

                reader.ReadToFollowing("Option");
                o3.Text = reader.ReadElementContentAsString();
                o3.isTrue = false;

                reader.ReadToFollowing("Option");
                o4.Text = reader.ReadElementContentAsString();
                o4.isTrue = false;

                question.Options.Add(o1);
                question.Options.Add(o2);
                question.Options.Add(o3);
                question.Options.Add(o4);
                ListQuesBank.Add(question);
                //if (!cmbTopic.Items.Contains(question.topic))
                //{
                //    cmbTopic.Items.Add(question.topic);
                //}

                lbQuesBank.Items.Add(question.content + " - " + question.topic);

            }
            reader.Close();

            //cmbQuesNumber.SelectedItem = "10";
            //cmbTopic.SelectedItem = ListQuesBank[0].topic;
        }
        private void FormCreateQuiz_Load(object sender, EventArgs e)
        {
            lbQuesBank.Items.Clear();
            ListQuesBank.Clear();
            ListSelectedQues.Clear();
            LoadFile();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            this.Hide();
            frm.Show();
        }

        private void lbSelectedQuestion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbQuesBank.IndexFromPoint(e.Location);
            if (lbSelectedQuestion != null)
            {
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    ListSelectedQues.RemoveAt(index);
                    lbSelectedQuestion.Items.RemoveAt(index);
                }
            }
        }

        private void lbQuesBank_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbQuesBank.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                ListSelectedQues.Add(ListQuesBank[index]);
                lbSelectedQuestion.Items.Add(ListQuesBank[index].content + " - " + ListQuesBank[index].topic);
            }
        }

        private void numQuestionAmount_ValueChanged(object sender, EventArgs e)
        {
            lbSelectedQuestion.Items.Clear();
            int amount = int.Parse(numQuestionAmount.Value.ToString());
            if(amount <= ListQuesBank.Count)
            {
                Random random = new Random();
                List<int> lstIndex = new List<int>();
                for (int i = 0; i < amount; i++)
                {
                    int index;
                    do
                    {
                        index = random.Next(0, amount);
                    } while (lstIndex.IndexOf(index) != -1);
                    lstIndex.Add(index);
                }

                for (int i = 0; i < amount; i++)
                {
                    
                    ListSelectedQues.Add(ListQuesBank[lstIndex[i]]);
                    lbSelectedQuestion.Items.Add(ListQuesBank[lstIndex[i]].content + " - " + ListQuesBank[lstIndex[i]].topic);
                }
            }
            else
            {
                MessageBox.Show("not enough questions");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // tạo hộp thoại lưu tập tin
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

                writer.WriteStartElement("Questions");
                writer.WriteAttributeString("id", numQuizID.Value.ToString());

                for (int i = 0; i < ListSelectedQues.Count; i++)
                {
                    writer.WriteStartElement("Question");

                    writer.WriteStartElement("Content");
                    writer.WriteValue(ListSelectedQues[i].content);
                    writer.WriteEndElement();

                    ListSelectedQues[i].Random();
                    for (int j = 0; j < 4; j++)
                    {
                            writer.WriteStartElement("Option");
                            writer.WriteValue(ListSelectedQues[i].Options[j].Text);
                            writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.Close();
            }
        }

        private void btnExportA_Click(object sender, EventArgs e)
        {
            // tạo hộp thoại lưu tập tin
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

                writer.WriteStartElement("Questions");
                writer.WriteAttributeString("id", numQuizID.Value.ToString());

                for (int i = 0; i < ListSelectedQues.Count; i++)
                {
                    writer.WriteStartElement("Question");

                    for (int j = 0; j < 4; j++)
                    {
                        if (ListSelectedQues[i].Options[j].isTrue == true)
                        {
                            writer.WriteStartElement("Option");
                            if(j==0)
                                writer.WriteValue("A");
                            else if(j==1)
                                writer.WriteValue("B");
                            else if(j==2)
                                writer.WriteValue("C");
                            else
                                writer.WriteValue("D");

                            writer.WriteEndElement();
                        }
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.Close();
            }
        }
    }
}
