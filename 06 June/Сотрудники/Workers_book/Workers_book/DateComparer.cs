using System.Collections.Generic;

namespace Notebook_structures
{
    class DateComparer : IComparer<Worker>
    {
        public DateComparer() {}

        public int Compare(Worker x, Worker y)
        {
            if (x.Date>y.Date) return 1;
            if (x.Date<y.Date) return -1;
            return 0;
        }

    }

}

