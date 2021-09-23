using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15RambunctiousRecitation
{
    class Part1
    {
        public int calculate(int iterations, string Variables)
        {
            //convert string to array 
            string[] variable = Variables.Split(',');
            int[] intsVar = Array.ConvertAll(variable, s => int.Parse(s));

            //setting start variables getting first and last positions and new array of 2020
            int first = 0;
            int last = intsVar.Last();
            int[] positions = new int[iterations];

            //adds the initial variables to the array
            for (int j = 0; j < intsVar.Count(); j++)
            {
                positions[intsVar[j]] = ++first;
            }

            
            for (int i = first; i < iterations; i++)
            {
               int prevpos = positions[last];
               int next = prevpos != 0 ? first - prevpos : 0;
               positions[last] = first++;
               last = next;
            }

            return last;
        }
    }
}
