using System;
namespace NunitNS
{
    public class StringBuilder
    {
        private string _string;

        public StringBuilder(string name)
        {
            _string = name;
        }
        public void Connect(string name)
        {
            if (_string != null && name != null)
                _string += name;
            else
                _string = null;
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
