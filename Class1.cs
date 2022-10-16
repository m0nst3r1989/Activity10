using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10
{
    class Set

    {

        private List<int> elements;



        public Set()

        {

            elements = new List<int>();

        }

        public bool addElement(int val)

        {

            if (containsElement(val)) return false;

            else

            {

                elements.Add(val);

                return true;

            }

        }

        private bool containsElement(int val)

        {

            for (int i = 0; i < elements.Count; i++)

            {

                if (val == elements[i])

                    return true;

                    //return false; Removed this because it is the wrong case. We do not want to return false here only if the if statement is false. 


            }

            return false;

        }

        public override string ToString()

        {

            string str = "";

            foreach (int i in elements)

            {

                str += i + " ";

            }

            return str;

        }

        public void clearSet()

        {

            elements.Clear();

        }

        public Set union(Set rhs)

        {

            // creating set to store the union
            Set c = new Set();

            // adds the elements to this set if they do not exist 
            for (int i = 0; i < elements.Count; i++)
            {
                if (!c.containsElement(elements[i]))
                { // if 'c' doesn't already contain the elements it adds them
                    c.addElement(elements[i]);
                }
            }

            // goes through the passed list
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                if (!c.containsElement(rhs.elements[i]))
                { // if the list 'c' does not have the current elements it adds them to c
                    c.addElement(rhs.elements[i]);
                }
            }

            return c; // returns C for union

        }

    }
}


