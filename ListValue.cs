﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7_Stack
{
    class ListValue
    {
        object _value;
        ListValue _next;
        int _index;

        public ListValue() { }

        public void add(int _inputIndex, object _inputObj)
        {
            if (_next == null)
            {
                _index = _inputIndex;
                _value = _inputObj;
                _next = new ListValue();
            }
            else
                _next.add(_inputIndex, _inputObj);
        }


        public override string ToString()
        {
            string returnString = "\t";
            if (_value == null)
                returnString += "null";
            else
                returnString += _value.ToString();
            returnString += "\n";

            if (_next != null)
                returnString += _next.ToString();

            return returnString;
        }
    }
}
