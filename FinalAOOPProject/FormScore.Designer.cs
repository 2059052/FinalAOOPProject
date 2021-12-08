
namespace FinalAOOPProject
{
    partial class FormScore
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportResult = new System.Windows.Forms.Button();
            this.btnImportAnswer = new System.Windows.Forms.Button();
            this.btnImportQuestion = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // btnExportResult
            // 
            this.btnExportResult.Location = new System.Drawing.Point(287, 59);
            this.btnExportResult.Name = "btnExportResult";
            this.btnExportResult.Size = new System.Drawing.Size(102, 41);
            this.btnExportResult.TabIndex = 2;
            this.btnExportResult.Text = "Export Result";
            this.btnExportResult.UseVisualStyleBackColor = true;
            this.btnExportResult.Click += new System.EventHandler(this.btnExportResult_Click);
            // 
            // btnImportAnswer
            // 
            this.btnImportAnswer.Location = new System.Drawing.Point(156, 59);
            this.btnImportAnswer.Name = "btnImportAnswer";
            this.btnImportAnswer.Size = new System.Drawing.Size(102, 41);
            this.btnImportAnswer.TabIndex = 3;
            this.btnImportAnswer.Text = "Import Answer";
            this.btnImportAnswer.UseVisualStyleBackColor = true;
            this.btnImportAnswer.Click += new System.EventHandler(this.btnImportAnswer_Click);
            // 
            // btnImportQuestion
            // 
            this.btnImportQuestion.Location = new System.Drawing.Point(22, 59);
            this.btnImportQuestion.Name = "btnImportQuestion";
            this.btnImportQuestion.Size = new System.Drawing.Size(102, 41);
            this.btnImportQuestion.TabIndex = 4;
            this.btnImportQuestion.Text = "Import File ";
            this.btnImportQuestion.UseVisualStyleBackColor = true;
            this.btnImportQuestion.Click += new System.EventHandler(this.btnImportQuestion_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 28);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 112);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportResult);
            this.Controls.Add(this.btnImportAnswer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnImportQuestion);
            this.Name = "FormScore";
            this.Text = "FormScore";
            this.Load += new System.EventHandler(this.FormScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportResult;
        private System.Windows.Forms.Button btnImportAnswer;
        private System.Windows.Forms.Button btnImportQuestion;
        private System.Windows.Forms.Button btnBack;
    }
}