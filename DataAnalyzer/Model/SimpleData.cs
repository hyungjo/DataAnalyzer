using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyzer.Model
{
    public class SimpleData
    {
        private int id;
        public int ID { get { return id; } set { id = value; } }
        private string name;
        public string NAME { get { return name; } set { name = value; } }
        public SimpleData(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
