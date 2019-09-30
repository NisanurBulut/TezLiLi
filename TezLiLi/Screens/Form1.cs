using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TezLiLi.APIHelpers;
namespace TezLiLi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNormalization_Click(object sender, EventArgs e)
        {
            string input = richTextBox_OContent.Text;
          
            richTextBox_NContent.Text = ApiMethodViaHelper.NormalizationCall(input);
        }

        private void BtnMorphologicalAnalyzer_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnTokenizer_Click(object sender, EventArgs e)
        {
            string input = richTextBox_NContent.Text;
            richTextBoxTokenizer.Text = ApiMethodViaHelper.Tokenize(input);
        }

        private void BtnMorphGenerator_Click(object sender, EventArgs e)
        {
        }

        private void BtnDisambiguator_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnNoisyPipeline_Click(object sender, EventArgs e)
        {
            string input = richTextBox_OContent.Text;

            richTextBox_NP.Text = ApiMethodViaHelper.NoisyPipeline(input);
        }
    }
}
