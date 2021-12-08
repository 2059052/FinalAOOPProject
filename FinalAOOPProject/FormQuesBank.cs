using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalAOOPProject
{
    public partial class FormQuesBank : Form
    {
        public static List<Question> ListQuesBank = new List<Question>();
        public FormQuesBank()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbQuesBank.Items.Clear();
            ListQuesBank.Clear();
            LoadFile();
        }

        public void ClearAllTextBox()
        {
            txtQuestion.Clear();
            txtTopic.Clear();
            txtAnswerA.Clear();
            txtAnswerB.Clear();
            txtAnswerC.Clear();
            txtAnswerD.Clear();
        }
        public void LoadFile()
        {
            //XmlReader reader = XmlReader.Create("../../QuesBank/QuesBank.xml");
            XmlReader reader = XmlReader.Create("QuesBank.xml");
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

                lbQuesBank.Items.Add(question.content);
            }
            reader.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtQuestion.Text)||
                string.IsNullOrEmpty(txtAnswerA.Text) || 
                string.IsNullOrEmpty(txtAnswerB.Text) ||
                string.IsNullOrEmpty(txtAnswerC.Text) ||
                string.IsNullOrEmpty(txtAnswerD.Text) ||
                string.IsNullOrEmpty(txtTopic.Text) )
            {
                MessageBox.Show("error!");
            }
            else
            {
                Question ques = new Question();

                Option o1 = new Option();
                Option o2 = new Option();
                Option o3 = new Option();
                Option o4 = new Option();
                
                o1.Text = txtAnswerA.Text;
                o2.Text = txtAnswerB.Text;
                o3.Text = txtAnswerC.Text;
                o4.Text = txtAnswerD.Text;

                o1.isTrue = true;

                ques.Options.Add(o1);
                ques.Options.Add(o2);
                ques.Options.Add(o3);
                ques.Options.Add(o4);

                if(ListQuesBank.Count>0)
                {
                    for(int i=0;i<ListQuesBank.Count;i++)
                    {
                        // neu giong thi break
                        if(ListQuesBank[i].content.ToString() == txtQuestion.Text)
                        {
                            MessageBox.Show("already exists!");
                            break;
                        }
                        //check toi cuoi list, neu khac thi add
                        else if (ListQuesBank[i].content.ToString() != txtQuestion.Text && i == ListQuesBank.Count - 1)
                        {
                            ques.topic = txtTopic.Text;
                            //if (!cmbTopic.Items.Contains(ques.topic))
                            //{
                            //    cmbTopic.Items.Add(ques.topic);
                            //}
                            ques.content = txtQuestion.Text;
                            ListQuesBank.Add(ques);
                            lbQuesBank.Items.Add(ques.content);
                            ClearAllTextBox();
                            break;
                        }
                    }
                }
                else
                {
                    ques.topic = txtTopic.Text;
                    ques.content = txtQuestion.Text;
                    ListQuesBank.Add(ques);
                    lbQuesBank.Items.Add(ques.content);
                    ClearAllTextBox();
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lbQuesBank.SelectedIndex;

            if (index >= 0)
            {
                ListQuesBank[index].content = txtQuestion.Text;
                ListQuesBank[index].Options[0].Text = txtAnswerA.Text;
                ListQuesBank[index].Options[1].Text = txtAnswerB.Text;
                ListQuesBank[index].Options[2].Text = txtAnswerC.Text;
                ListQuesBank[index].Options[3].Text = txtAnswerD.Text;
                ListQuesBank[index].topic = txtTopic.Text;

                lbQuesBank.Items[index] = ListQuesBank[index].content;
                ClearAllTextBox();
            }
            else
                MessageBox.Show("haven't choose");
        }

        private void lbQuesBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show info len textbox
            int index = lbQuesBank.SelectedIndex;
            if (index >= 0)
            {
            txtQuestion.Text = ListQuesBank[index].content;
            txtAnswerA.Text = ListQuesBank[index].Options[0].Text;
            txtAnswerB.Text = ListQuesBank[index].Options[1].Text;
            txtAnswerC.Text = ListQuesBank[index].Options[2].Text;
            txtAnswerD.Text = ListQuesBank[index].Options[3].Text;
            txtTopic.Text = ListQuesBank[index].topic;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbQuesBank.SelectedIndex;
            if (index >= 0)
            {
                ListQuesBank.RemoveAt(index);
                lbQuesBank.Items.RemoveAt(index);
            }
            else
                MessageBox.Show("Chua chon phan tu can xoa");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("../../QuesBank/QuesBank.xml", new XmlWriterSettings() { Indent = true });

            writer.WriteStartElement("Questions");

            for(int i = 0; i < ListQuesBank.Count; i++)
            {
                writer.WriteStartElement("Question");

                writer.WriteStartElement("Content");
                writer.WriteValue(ListQuesBank[i].content);
                writer.WriteEndElement();

                writer.WriteStartElement("Topic");
                writer.WriteValue(ListQuesBank[i].topic);
                writer.WriteEndElement();

                for(int j = 0; j < 4; j++)
                {
                    if (ListQuesBank[i].Options[j].isTrue == true)
                    {
                        writer.WriteStartElement("Option");
                        writer.WriteAttributeString("isTrue", "true");
                        writer.WriteValue(ListQuesBank[i].Options[j].Text);
                        writer.WriteEndElement();
                    }
                    else 
                    {
                        writer.WriteStartElement("Option");
                        writer.WriteAttributeString("isTrue", "false");
                        writer.WriteValue(ListQuesBank[i].Options[j].Text);
                        writer.WriteEndElement();
                    }
                }
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.Close();
            MessageBox.Show(" Saved !");
        }

        //Search listbox source: https://stackoverflow.com/questions/4878929/c-sharp-searching-a-listbox
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lbQuesBank.Items.Clear();

            foreach(Question question in ListQuesBank)
            {
                string str = question.content;
                if (str.StartsWith(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lbQuesBank.Items.Add(str);
                }
            }
        }

         private void btnBack_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            this.Hide();
            frm.Show();
        }
    }
}
