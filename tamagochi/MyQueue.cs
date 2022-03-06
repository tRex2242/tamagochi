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

        public MyQueue(int _capacity)
        {
            capacity = _capacity;
            cout_busy = 0;
            elements = new KeyValuePair<Actions, Image>?[capacity];
        } 

        public KeyValuePair<Actions, Image>?[] Elements
        {
            get
            {
                return elements;
            }
        }

        public bool Enqueue(KeyValuePair<Actions, Image> pair)
        {if(cout_busy == capacity)
            { return false;}
            elements[cout_busy] = pair;
            cout_busy++;
            return true;}
        
        public KeyValuePair<Actions, Image>? Dequeue()
        {if(cout_busy == 0){ return null; }
            KeyValuePair<Actions, Image>? element = elements[0];
            for(int i = 0; i < cout_busy - 1; i++)
            {elements[i] = elements[i + 1];}
            elements[cout_busy - 1] = null;
            cout_busy--;
            return element;}
     }
}
