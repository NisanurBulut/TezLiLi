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

            prBarFileCount.Minimum = 0;
            prBarFileCount.Value = 0;
            foreach (var topic in textParser.TopicList) {
              
                //continue;
                textParser.InitializeTextParserHelper(topic);
                //Konu içindeki dosya isimlerini alalımint
               
                textParser.GetTopicFiles(); //konuya dair tetx dosyaları belirlenir
                prBarFileCount.Maximum = textParser.TopicFileList.Count;
                for (int i = 0; i < textParser.TopicFileList.Count; i++)
                {
                    PrFile = PrFile + 1 ;
                    prBarFileCount.Value = PrFile;

                    prBarSentenceCount.Value = 0;
                    textParser.SentenceList.Clear();
                    var textFilePath = textParser.TopicFileList[i];

                    textParser.GetContentFromFile(textFilePath);
                    textParser.SplitContentSentenceBySentence();
                    string pResult = string.Empty;
                    if (textParser.SentenceList.Any())
                    {
                        prBarSentenceCount.Maximum = textParser.SentenceList.Count;
                    }
                   
                    for (var s=0; s< textParser.SentenceList.Count; s++)
                    {
                      
                        try
                        {
                            rTBOriginal_Text.Text = textParser.SentenceList[s] + "\n\n";
                            //var nresult = ApiMethodViaHelper.NormalizationCall(s);
                            pResult = ApiMethodViaHelper.NoisyPipeline(textParser.SentenceList[s]);
                            rTBDepParsingText.Text = pResult + "\n\n";
                            
                            textParser.WriteResultFromParsing(pResult, textParser.SentenceList[s], i, cs);
                            cs = cs + 1;
                            prBarSentenceCount.Value = cs;
                            textParser.SentenceList[s] = string.Empty;
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
