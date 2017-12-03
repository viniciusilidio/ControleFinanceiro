using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Data
{
    class Table
    {
        private string name;
        private string Name { get { return name; } }

        private string[] fieldNames;
        private string[] FieldNames { get { return FieldNames; } }

        private string[] dataTypes;
        private string[] DataTypes { get { return dataTypes; } }

        public Table(string name, string[] fieldNames, string[] dataTypes)
        {
            this.name = name;
            this.fieldNames = fieldNames;
            this.dataTypes = dataTypes;
        }
    }
}
