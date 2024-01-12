using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ArithProgression : ISeries
    {
        private int firstNumber;
        private int currentNumber;
        private int step;

        public ArithProgression(int firstNumber=0, int step=0)
        {
            this.firstNumber = firstNumber;
            this.step = step;
            currentNumber= firstNumber;
        }


        public int GetNext()
        {
            currentNumber = currentNumber + step;
            return currentNumber;
        }

     

        public void Reset()
        {
            currentNumber = firstNumber;
        }

        public void SetStart(int x)
        {
            firstNumber = x;
            currentNumber = firstNumber;
        }

        public void SetStep(int x)
        {
            step = x;
        }
    }
}
