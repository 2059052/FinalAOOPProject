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
    public partial class FormScore : Form
    {
        string name;
        string studentid;
        string time;
        bool importFileThiCheck= false;
        bool importDapAnCheck = false;
        string idFileThi;
        string idDapAn;
        public List<String> listFileThi = new List<String>();
        public List<String> listDapAn = new List<String>();
        public FormScore()
        {
            InitializeComponent();
        }
        
        private void btnImportQuestion_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Chon tap tin .xml|*.xml";
            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                // mở tập tin để đọc
                XmlReader reader = XmlReader.Create(filePath);
                reader.ReadToFollowing("info");

                reader.MoveToAttribute("name");
                name = reader.Value;

                reader.MoveToAttribute("studentid");
                studentid = reader.Value;

                reader.MoveToAttribute("time");
                time = reader.Value;

                reader.ReadToFollowing("Questions");
                reader.MoveToAttribute("id");
                idFileThi = reader.Value;

                while (reader.ReadToFollowing("Question"))
                {
                    reader.ReadToFollowing("Option");
                    listDapAn.Add(reader.ReadElementContentAsString());
                }
                reader.Close();
                label1.Text = "Imported";
                importFileThiCheck = true;
            }
            
        }

        private void btnImportAnswer_Click(object sender, EventArgs e)
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
                idDapAn = reader.Value;

                while (reader.ReadToFollowing("Question"))
                {
                    reader.ReadToFollowing("Option");
                    listFileThi.Add(reader.ReadElementContentAsString());
                }
                reader.Close();
                label2.Text = "Imported";
                importDapAnCheck = true;
            }
        }

        private void FormScore_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void btnExportResult_Click(object sender, EventArgs e)
        {
            if(importFileThiCheck==false || importDapAnCheck==false)
                MessageBox.Show("File haven't import!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (idFileThi != idDapAn)
                MessageBox.Show("id not match!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Chon tap tin .txt|*.txt";
                // hiển thị hộp thoại
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    string filePath = dlg.FileName;
                    StreamWriter sw = File.CreateText(filePath);
                    sw.WriteLine("Ten sv: " + name);
                    sw.WriteLine("Id sv: " + studentid);
                    sw.WriteLine("Thoi gian : " + time);

                    int diem = 0;
                    for(int i = 0; i < listFileThi.Count; i++)
                    {
                        if (listFileThi[i] == listDapAn[i])
                        {
                            diem++;
                        }
                    }
                    sw.WriteLine("diem cua ban " + diem);
                    sw.Close();
                    /*WRITE FILE TXT 
                     * TEN SV
                     * MSSV
                     * TGIAN LAM BAI
                     * DIEM SO
                    */
                   
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
