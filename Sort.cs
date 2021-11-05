using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDetails
{
    class Sort:IComparer<Job>
    {
        public int Compare(Job x, Job y)
        {
            return x.Sal.CompareTo(y.Sal);
        }
    }
}
