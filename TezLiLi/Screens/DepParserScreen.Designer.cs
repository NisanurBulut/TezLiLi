namespace TezLiLi
{
    partial class DepParserScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rTBDepParsingText = new System.Windows.Forms.RichTextBox();
            this.rTBOriginal_Text = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.prBarFileCount = new System.Windows.Forms.ProgressBar();
            this.prBarSentenceCount = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rTBDepParsingText, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rTBOriginal_Text, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 399);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rTBDepParsingText
            // 
            this.rTBDepParsingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBDepParsingText.Location = new System.Drawing.Point(400, 3);
            this.rTBDepParsingText.Name = "rTBDepParsingText";
            this.rTBDepParsingText.Size = new System.Drawing.Size(391, 393);
            this.rTBDepParsingText.TabIndex = 1;
            this.rTBDepParsingText.Text = "";
            // 
            // rTBOriginal_Text
            // 
            this.rTBOriginal_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBOriginal_Text.Location = new System.Drawing.Point(3, 3);
            this.rTBOriginal_Text.Name = "rTBOriginal_Text";
            this.rTBOriginal_Text.Size = new System.Drawing.Size(391, 393);
            this.rTBOriginal_Text.TabIndex = 0;
            this.rTBOriginal_Text.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.prBarFileCount, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.prBarSentenceCount, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 408);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 39);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // prBarFileCount
            // 
            this.prBarFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prBarFileCount.Location = new System.Drawing.Point(3, 3);
            this.prBarFileCount.Name = "prBarFileCount";
            this.prBarFileCount.Size = new System.Drawing.Size(788, 13);
            this.prBarFileCount.TabIndex = 0;
            // 
            // prBarSentenceCount
            // 
            this.prBarSentenceCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prBarSentenceCount.Location = new System.Drawing.Point(3, 22);
            this.prBarSentenceCount.Name = "prBarSentenceCount";
            this.prBarSentenceCount.Size = new System.Drawing.Size(788, 14);
            this.prBarSentenceCount.TabIndex = 1;
            // 
            // DepParserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DepParserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepParserScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DepParserScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox rTBDepParsingText;
        private System.Windows.Forms.RichTextBox rTBOriginal_Text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ProgressBar prBarFileCount;
        private System.Windows.Forms.ProgressBar prBarSentenceCount;
    }
}