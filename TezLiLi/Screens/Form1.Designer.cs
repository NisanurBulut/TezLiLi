namespace TezLiLi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel0 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_OContent = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_NContent = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTokenizer = new System.Windows.Forms.RichTextBox();
            this.BtnNoisyPipeline = new System.Windows.Forms.Button();
            this.BtnNormalization = new System.Windows.Forms.Button();
            this.BrnTokenizer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_NP = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel0.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel0
            // 
            this.tableLayoutPanel0.ColumnCount = 1;
            this.tableLayoutPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel0.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel0.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel0.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel0.Name = "tableLayoutPanel0";
            this.tableLayoutPanel0.RowCount = 2;
            this.tableLayoutPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel0.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel0.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_OContent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_NContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxTokenizer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_NP, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Content";
            // 
            // richTextBox_OContent
            // 
            this.richTextBox_OContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_OContent.Location = new System.Drawing.Point(90, 3);
            this.richTextBox_OContent.Name = "richTextBox_OContent";
            this.richTextBox_OContent.Size = new System.Drawing.Size(701, 53);
            this.richTextBox_OContent.TabIndex = 3;
            this.richTextBox_OContent.Text = resources.GetString("richTextBox_OContent.Text");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(16, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tokenizer";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Normalizated Content";
            // 
            // richTextBox_NContent
            // 
            this.richTextBox_NContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_NContent.Location = new System.Drawing.Point(90, 62);
            this.richTextBox_NContent.Name = "richTextBox_NContent";
            this.richTextBox_NContent.Size = new System.Drawing.Size(701, 53);
            this.richTextBox_NContent.TabIndex = 4;
            this.richTextBox_NContent.Text = "";
            // 
            // richTextBoxTokenizer
            // 
            this.richTextBoxTokenizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTokenizer.Location = new System.Drawing.Point(90, 121);
            this.richTextBoxTokenizer.Name = "richTextBoxTokenizer";
            this.richTextBoxTokenizer.Size = new System.Drawing.Size(701, 53);
            this.richTextBoxTokenizer.TabIndex = 10;
            this.richTextBoxTokenizer.Text = "";
            // 
            // BtnNoisyPipeline
            // 
            this.BtnNoisyPipeline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNoisyPipeline.BackColor = System.Drawing.SystemColors.Window;
            this.BtnNoisyPipeline.Location = new System.Drawing.Point(267, 8);
            this.BtnNoisyPipeline.Name = "BtnNoisyPipeline";
            this.BtnNoisyPipeline.Size = new System.Drawing.Size(126, 23);
            this.BtnNoisyPipeline.TabIndex = 2;
            this.BtnNoisyPipeline.Text = "Noisy Pipeline";
            this.BtnNoisyPipeline.UseVisualStyleBackColor = false;
            this.BtnNoisyPipeline.Click += new System.EventHandler(this.BtnNoisyPipeline_Click);
            // 
            // BtnNormalization
            // 
            this.BtnNormalization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNormalization.BackColor = System.Drawing.SystemColors.Window;
            this.BtnNormalization.Location = new System.Drawing.Point(3, 8);
            this.BtnNormalization.Name = "BtnNormalization";
            this.BtnNormalization.Size = new System.Drawing.Size(126, 23);
            this.BtnNormalization.TabIndex = 3;
            this.BtnNormalization.Text = "Normalization\r\n";
            this.BtnNormalization.UseVisualStyleBackColor = false;
            this.BtnNormalization.Click += new System.EventHandler(this.BtnNormalization_Click);
            // 
            // BrnTokenizer
            // 
            this.BrnTokenizer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrnTokenizer.BackColor = System.Drawing.SystemColors.Window;
            this.BrnTokenizer.Location = new System.Drawing.Point(135, 8);
            this.BrnTokenizer.Name = "BrnTokenizer";
            this.BrnTokenizer.Size = new System.Drawing.Size(126, 23);
            this.BrnTokenizer.TabIndex = 5;
            this.BrnTokenizer.Text = "Tokenizer";
            this.BrnTokenizer.UseVisualStyleBackColor = false;
            this.BrnTokenizer.Click += new System.EventHandler(this.BtnTokenizer_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.BrnTokenizer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNormalization, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnNoisyPipeline, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 408);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 39);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(7, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Noisy Pipeline\r\n";
            // 
            // richTextBox_NP
            // 
            this.richTextBox_NP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_NP.Location = new System.Drawing.Point(90, 180);
            this.richTextBox_NP.Name = "richTextBox_NP";
            this.richTextBox_NP.Size = new System.Drawing.Size(701, 216);
            this.richTextBox_NP.TabIndex = 13;
            this.richTextBox_NP.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel0.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_NContent;
        private System.Windows.Forms.RichTextBox richTextBox_OContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxTokenizer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_NP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BrnTokenizer;
        private System.Windows.Forms.Button BtnNormalization;
        private System.Windows.Forms.Button BtnNoisyPipeline;
    }
}

