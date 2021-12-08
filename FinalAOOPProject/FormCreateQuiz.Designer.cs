
namespace FinalAOOPProject
{
    partial class FormCreateQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbQuesBank = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbSelectedQuestion = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.numQuestionAmount = new System.Windows.Forms.NumericUpDown();
            this.btnExportA = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numQuizID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuizID)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuesBank
            // 
            this.lbQuesBank.FormattingEnabled = true;
            this.lbQuesBank.Location = new System.Drawing.Point(11, 66);
            this.lbQuesBank.Margin = new System.Windows.Forms.Padding(2);
            this.lbQuesBank.Name = "lbQuesBank";
            this.lbQuesBank.Size = new System.Drawing.Size(385, 446);
            this.lbQuesBank.TabIndex = 13;
            this.lbQuesBank.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbQuesBank_MouseDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 41);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back to menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbSelectedQuestion
            // 
            this.lbSelectedQuestion.FormattingEnabled = true;
            this.lbSelectedQuestion.Location = new System.Drawing.Point(413, 66);
            this.lbSelectedQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.lbSelectedQuestion.Name = "lbSelectedQuestion";
            this.lbSelectedQuestion.Size = new System.Drawing.Size(385, 446);
            this.lbSelectedQuestion.TabIndex = 13;
            this.lbSelectedQuestion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSelectedQuestion_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "double click to select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "double click to remove";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Questions Amount";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(115, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 49);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export Quiz";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // numQuestionAmount
            // 
            this.numQuestionAmount.Location = new System.Drawing.Point(509, 24);
            this.numQuestionAmount.Name = "numQuestionAmount";
            this.numQuestionAmount.Size = new System.Drawing.Size(120, 20);
            this.numQuestionAmount.TabIndex = 17;
            this.numQuestionAmount.ValueChanged += new System.EventHandler(this.numQuestionAmount_ValueChanged);
            // 
            // btnExportA
            // 
            this.btnExportA.Location = new System.Drawing.Point(208, 12);
            this.btnExportA.Name = "btnExportA";
            this.btnExportA.Size = new System.Drawing.Size(87, 49);
            this.btnExportA.TabIndex = 14;
            this.btnExportA.Text = "Export Answer";
            this.btnExportA.UseVisualStyleBackColor = true;
            this.btnExportA.Click += new System.EventHandler(this.btnExportA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Questions Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Selected Questions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quiz ID";
            // 
            // numQuizID
            // 
            this.numQuizID.Location = new System.Drawing.Point(702, 24);
            this.numQuizID.Name = "numQuizID";
            this.numQuizID.Size = new System.Drawing.Size(96, 20);
            this.numQuizID.TabIndex = 17;
            // 
            // FormCreateQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 523);
            this.Controls.Add(this.numQuizID);
            this.Controls.Add(this.numQuestionAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportA);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbSelectedQuestion);
            this.Controls.Add(this.lbQuesBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCreateQuiz";
            this.Text = "Form Create Quiz";
            this.Load += new System.EventHandler(this.FormCreateQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuestionAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuizID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuesBank;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbSelectedQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.NumericUpDown numQuestionAmount;
        private System.Windows.Forms.Button btnExportA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numQuizID;
    }
}