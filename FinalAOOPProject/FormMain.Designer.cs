
namespace FinalAOOPProject
{
    partial class FormMain
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
            this.btnQuestionsBank = new System.Windows.Forms.Button();
            this.btnCreateQuiz = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestionsBank
            // 
            this.btnQuestionsBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionsBank.Location = new System.Drawing.Point(131, 12);
            this.btnQuestionsBank.Name = "btnQuestionsBank";
            this.btnQuestionsBank.Size = new System.Drawing.Size(194, 85);
            this.btnQuestionsBank.TabIndex = 0;
            this.btnQuestionsBank.Text = "Questions bank";
            this.btnQuestionsBank.UseVisualStyleBackColor = true;
            this.btnQuestionsBank.Click += new System.EventHandler(this.btnQuestionsBank_Click);
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuiz.Location = new System.Drawing.Point(131, 119);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(194, 85);
            this.btnCreateQuiz.TabIndex = 0;
            this.btnCreateQuiz.Text = "Create Quiz";
            this.btnCreateQuiz.UseVisualStyleBackColor = true;
            this.btnCreateQuiz.Click += new System.EventHandler(this.btnCreateQuiz_Click);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(131, 233);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(194, 85);
            this.btnScore.TabIndex = 0;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 333);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnCreateQuiz);
            this.Controls.Add(this.btnQuestionsBank);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuestionsBank;
        private System.Windows.Forms.Button btnCreateQuiz;
        private System.Windows.Forms.Button btnScore;
    }
}