using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TezLiLi.APIHelpers;

namespace TezLiLi
{
    public partial class DepParserScreen : Form
    {
        public DepParserScreen()
        {
            InitializeComponent();
        }

        private void BtnDepParser_Click(object sender, EventArgs e)
        {
            string input = rTBOriginal_Text.Text;

            rTBDepParsingText.Text = ApiMethodViaHelper.NoisyPipeline(input);
        }

        private void DepParserScreen_Load(object sender, EventArgs e)
        {
            ParserProcess();
        }
        private void ParserProcess()
        {
            TextParserHelper textParser = new TextParserHelper();
            int cs = 1;
            foreach (var topic in textParser.TopicList)
           {
                
                //continue;
                textParser.InitializeTextParserHelper(topic);
                //Konu içindeki dosya isimlerini alalımint
               
                textParser.GetTopicFiles(); //konuya dair tetx dosyaları belirlenir
                for (int i = 0; i < textParser.TopicFileList.Count; i++)
                {
                    
                    textParser.SentenceList.Clear();
                    var textFilePath = textParser.TopicFileList[i];

                    textParser.GetContentFromFile(textFilePath);
                    textParser.SplitContentSentenceBySentence();
                    string pResult = string.Empty;
                    foreach (var s in textParser.SentenceList)
                    {
                        try
                        {
                            rTBOriginal_Text.Text =  s + "\n\n";
                            pResult = ApiMethodViaHelper.NoisyPipeline(s);
                            rTBDepParsingText.Text =  pResult + "\n\n";
                            Thread.Sleep(100);
                            textParser.WriteResultFromParsing(pResult, s, i, cs);
                            cs = cs + 1;
                        }
                        catch(Exception ex)
                        {
                            continue;
                        }
                    }
                }
            }
            MessageBox.Show("Bitti");  
        }
    }
}
