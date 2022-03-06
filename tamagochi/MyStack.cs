using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi
{
    class MyStack
    {
        private int capacity;
        private int count_bisy;
        private KeyValuePair<Actions, Image>?[] elements;

        public MyStack(int _capacity)
        {
            capacity = _capacity;
            count_bisy = 0;
            elements = new KeyValuePair<Actions, Image>?[capacity];
        }

        public KeyValuePair<Actions, Image>?[] Elements
        {
            get
            {
                return elements;
            }
        }

        public bool Push(KeyValuePair<Actions, Image> pair)
        {
            if(count_bisy == capacity)
            return false;
            

            elements[count_bisy] = pair;
            count_bisy++;
            return true;

        }

        public KeyValuePair<Actions, Image>? Pop()
        {
            if (count_bisy == 0)
            return null;

            var element = elements[count_bisy - 1];
            elements[count_bisy - 1] = null;
            count_bisy--;
            return element;
        }
    }
}
