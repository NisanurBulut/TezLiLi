using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TezLiLi.APIHelpers
{
    public class TextParserHelper
    {

        public string FileName = string.Empty;
        public string FilePath = string.Empty;
        public string Content = string.Empty;
        public string Topic = string.Empty;
        public List<string> SentenceList = new List<string>();
        public List<string> TopicFileList = new List<string>();
        public List<string> ResultFilePathList = new List<string>();
        public List<string> OrjFilePathList = new List<string>();
        public string SFilePath = string.Empty;
        public string RFilePath = string.Empty;
        public TextParserHelper(string _topic)
        {
            this.Topic = _topic;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            this.FilePath = projectDirectory + @"\VeriSeti\Konular\";
            this.SFilePath = string.Empty;
        }
        public TextParserHelper()
        {

        }
        public void InitializeTextParserHelper(string _topic)
        {
            this.TopicFileList.Clear();
            this.Topic = _topic;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            this.FilePath = projectDirectory + @"\VeriSeti\";
            this.SFilePath = projectDirectory + @"\VeriSetiSonuclar\";
            this.RFilePath = projectDirectory + @"\VeriSetiSonuclar\";
        }
        public List<string> TopicList = new List<string>()
        {
            "ebooks"
        };
        public void ReadText()
        {
            // Read entire text file content in one string  
            string text = File.ReadAllText(FilePath);
            Console.WriteLine(text);
        }
        public void GetTopicFiles()
        {

            //Verilen klasör içerisindeki dosyaların yolunu alır
            string fpath = this.FilePath + this.Topic;
            this.OrjFilePathList.Clear();
            this.TopicFileList.AddRange(Directory.GetFiles(fpath).ToList());
            this.ResultFilePathList.Clear();
            foreach (var path in this.TopicFileList)
            {
                var p = path.IndexOf('.');
                var pa = path.Substring(0, p);
                pa = pa + "Result.txt";
                this.ResultFilePathList.Add(pa);
                var pa1 = path.Substring(0, p);
                pa1 = pa1 + "Orj.txt";
                this.OrjFilePathList.Add(pa1);
            }
        }
        public void GetContentFromFile(string _filePath)
        {
            var fileStream = new FileStream(_filePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.Default))
            {
                this.Content = streamReader.ReadToEnd();
            }
        }

        public void SplitContentSentenceBySentence()
        {
            string[] sekme1 = Regex.Split(this.Content, @"(?<=[.!?])");

            foreach (var cumle in sekme1)
            {


                if (cumle.Length > 30)
                {
                    string _cumle = cumle.Trim();




                    _cumle = _cumle.Trim();
                    if (_cumle.Contains("..."))
                    {
                        _cumle = _cumle.Replace("...", ".");
                    }

                    if (KontrolCumle(_cumle) == true)
                    {
                        this.SentenceList.Add(_cumle);
                    }




                    //if (lines.Length == 0 && _cumle.Length > 25)
                    //{
                    //    if (KontrolCumle(_cumle) == true)
                    //    {
                    //        if (cumle.Contains("...") == true)
                    //        {
                    //            var result = cumle.Replace("...", ".");
                    //            this.SentenceList.Add(result);
                    //        }
                    //        else
                    //        {
                    //            this.SentenceList.Add(_cumle);
                    //        }

                    //    }
                    //}

                }

            }

        }

        private bool KontrolCumle(string cumle)
        {

            bool kSonuc = false;
            char sonKarater = cumle[cumle.Length - 1];
            string sonKarakterdenOnce = cumle[cumle.Length - 2].ToString();
            char ilkKarater = cumle[0];
            int output = 0;
           // var SayiVarmi = cumle.Any(Char.IsDigit);
            var SembolVarmi = cumle.Any(Char.IsSymbol);
            var cumleHarfler = cumle.ToCharArray();

            if (cumle.Contains("Prof.") || cumle.Contains("prof."))
            {
                return kSonuc;
            }
            if (SembolVarmi == true)
            {
                return kSonuc;
            }
            //if (SayiVarmi == true)
            //{
            //    return kSonuc;
            //}
            if (Char.IsLetter(ilkKarater) == false)
            {
                return kSonuc;
            }
            else if (int.TryParse(sonKarakterdenOnce, out output) == true)
            {
                return kSonuc;
            }
            else if (Char.IsLower(ilkKarater) == true)
            {
                return kSonuc;
            }
            if (cumle.Contains("\\") == true)
            {
                return kSonuc;
            }
            if (cumle.Contains("\"") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("(") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains(")") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("-") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("#") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("@") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("*") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("&") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("+") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("/") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("_") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("www.") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains(".com") == true)
            {
                return kSonuc;
            }
            else if (cumle.Contains("..") == true)
            {
                return kSonuc;
            }
            else if (Char.IsPunctuation(sonKarater) == false)
            {
                return kSonuc;
            }
            else if (sonKarater != '.' && sonKarater != '!' && sonKarater != '?')
            {
                return kSonuc;
            }
            else
            {
                return true;
            }

        }
        public void WriteResultFromParsing(string _content, string _ocontent, int i, int _cs)
        {

            RFilePath = ResultFilePathList[i];

            using (StreamWriter sw = File.AppendText(RFilePath))
            {
                System.Windows.Forms.RichTextBox rch = new System.Windows.Forms.RichTextBox();
                rch.Text = _content;
                foreach (string l in rch.Lines)
                    sw.WriteLine(l);
                sw.WriteLine("\n\n");
            }

            var OrjFilePath = OrjFilePathList[i];
            using (StreamWriter sw = File.AppendText(OrjFilePath))
            {
                System.Windows.Forms.RichTextBox rch = new System.Windows.Forms.RichTextBox();
                rch.Text = _cs + " " + _ocontent;
                foreach (string l in rch.Lines)
                    sw.WriteLine(l);
                sw.WriteLine("\n\n");
            }
        }
    }
}
