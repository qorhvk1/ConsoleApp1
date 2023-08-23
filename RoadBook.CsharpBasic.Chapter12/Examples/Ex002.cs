using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Lucene.Net.Analysis;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Documents;
using Lucene.Net.Store;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.QueryParsers;


namespace RoadBook.CsharpBasic.Chapter12.Examples
{

    public class StemAnalyzer : Analyzer
    {
        public override TokenStream TokenStream(string fieldName,
            TextReader reader)
        {
            return new PorterStemFilter(new StandardTokenizer(Lucene.Net.Util.Version.LUCENE_30, reader));
        }
    }

    public class Ex002
    {
        string indexPath = Environment.CurrentDirectory + "\\LuceneIndex";
        Lucene.Net.Util.Version luceneVersion = Lucene.Net.Util.Version.LUCENE_30;

        System.Collections.Generic.List<Document> _docs;
        Lucene.Net.Store.Directory _directory;
        Analyzer _analyzer;

        public void  Run()
        {
            Crawl();
            Index();
        }
    }
}
