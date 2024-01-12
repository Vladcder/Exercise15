using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface ISeries
    {
        void SetStart(int x);
        void SetStep(int x);
         int GetNext();

        void Reset();
    }
}
