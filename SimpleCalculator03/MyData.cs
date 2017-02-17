using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator03
{
    class MyData //為MyClass加入2個欄位
    {
        private int _x;
        private int _y;
        public int X//X的儲存欄位為 private int _x
        {
            get { return _x; }//從private int _x取值
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
