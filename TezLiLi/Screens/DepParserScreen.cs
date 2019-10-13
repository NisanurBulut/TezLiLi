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
        int PrFile = 0;
        int PrSentence= 0;
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
           
           foreach(var topic in textParser.TopicList) {
              
                //continue;
                textParser.InitializeTextParserHelper(topic);
                //Konu içindeki dosya isimlerini alalımint

                textParser.GetTopicFiles(); //konuya dair tetx dosyaları belirlenir
                if (textParser.TopicFileList.Any())
                {
                    PrFile = textParser.TopicFileList.Count/100;
                }
                
                for (int i = 0; i < textParser.TopicFileList.Count; i++)
                {
                    prBarSentenceCount.Value = 0;
                    textParser.SentenceList.Clear();
                    var textFilePath = textParser.TopicFileList[i];

                    textParser.GetContentFromFile(textFilePath);
                    textParser.SplitContentSentenceBySentence();
                    string pResult = string.Empty;
                    if (textParser.SentenceList.Any())
                    {
                        PrSentence =  textParser.SentenceList.Count/100;
                        prBarSentenceCount.Maximum = textParser.SentenceList.Count;
                    }
                    prBarFileCount.Value = prBarFileCount.Value + PrFile;
                    foreach (var s in textParser.SentenceList)
                    {
                      
                        try
                        {
                            rTBOriginal_Text.Text = s + "\n\n";
                            //var nresult = ApiMethodViaHelper.NormalizationCall(s);
                            pResult = ApiMethodViaHelper.NoisyPipeline(s);
                            rTBDepParsingText.Text = pResult + "\n\n";
                            
                            textParser.WriteResultFromParsing(pResult, s, i, cs);
                            cs = cs + 1;
                            prBarSentenceCount.Value = prBarSentenceCount.Value + 1;
                        }
                        catch (Exception ex)
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
