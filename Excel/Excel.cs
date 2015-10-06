using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel
{
    public static class Excel
    {
        public static String GetColumnName(int columnNumber, int baseNumber)
        {
            int modulo;
            string columnName = String.Empty;
            while (columnNumber > 0)
            {
                modulo = (columnNumber - 1) % baseNumber;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                columnNumber = (int)((columnNumber - modulo) / baseNumber);
            }

            return columnName;
        }
    }
}
