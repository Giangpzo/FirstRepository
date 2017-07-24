using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logviewer
{
    //public class Data
    //{
    //    public int Id;
    //    public string Level { get; set; }
    //    public string Info { get; set; }
    //    public Data(string level,string info, int id)
    //    {
    //        this.Level = level;
    //        this.Info = info;
    //        this.Id = id;
    //    }
    //}
    public class Data
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string Source { get; set; }
        public string SourceName { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public Data(string date, string time, string source,
            string sourceName,string level,string message)
        {
            this.Date = date;
            this.Time = time;
            this.Source = source;
            this.SourceName = sourceName;
            this.Level = level;
            this.Message = message;
        }
    }
}
