using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezLiLi.APIHelpers
{
    public static class ApiMethodViaHelper
    {
        public static string NormalizationCall(string input)
        {
            var Taskresult = ApiMainHelper.CallApi(input, "normalize");
            return Taskresult.Result;
        }

        public static string MorphGenerator(string input)
        {
            var Taskresult = ApiMainHelper.CallApi(input, "morphgenerator");
            return Taskresult.Result;
        }
        public static string MorphAnalyzer(string input)
        {
            var Taskresult = ApiMainHelper.CallApi(input, "morphanalyzer");
            return Taskresult.Result;
        }
        public static string Tokenize(string input)
        {
            var Taskresult = ApiMainHelper.CallApi(input, "tokenizer");
            return Taskresult.Result;
        }
        public static string Disambiguator(string input)
        {
            var Taskresult = ApiMainHelper.CallApi(input, "disambiguator");
            return Taskresult.Result;
        }
        public static string NoisyPipeline(string input)
        {
            var Taskresult = ApiMainHelper.CallApi(input, "pipelineNoisy");
            return Taskresult.Result;
        }
    }
}