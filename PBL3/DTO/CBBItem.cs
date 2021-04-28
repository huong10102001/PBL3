using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class CBBItem
    {
        

        public int Value { get; set; }
        public string Text { get; set; }

        public CBBItem(int value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
