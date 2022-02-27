using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi
{
    class MyQueue
    {
        private int capacity;
        private int cout_busy;
        private KeyValuePair<Actions, Image>?[] elements;


        public KeyValuePair<Actions, Image>?[] Elements
        {
            get
            {
                return elements;
            }
        }

        public bool Enqueue(KeyValuePair<Actions, Image> pair)
        {
            if(cout_busy == capacity)
            {
                return false;
            }

            elements[cout_busy] = pair;
            cout_busy++;
            return true;
        }

        public KeyValuePair<Actions, Image>? Dequeue()
        {

        }

    }
}
