using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetModuleConsole
{
    public class Table
    {
        public Table()
        {
            Fields = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Fields { get; set; }

        public string ImportantField { get; set; }


    }
}
