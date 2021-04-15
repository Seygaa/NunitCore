using System;
using System.Collections.Generic;
using System.Text;

namespace NunitCoreNS
{
    public class StringBuilderException
    {
        private string _string;

        public StringBuilderException(string name)
        {
            _string = name;
        }
        public void Connect(string name)
        {
            if (name == null||_string==null)
            {
                throw new ArgumentNullException();
            }
            _string += name;

        }
        public string ReturnString()
        {
            return _string;
        }
        public void Display()
        {
            Console.WriteLine(_string);
        }

    }
}
