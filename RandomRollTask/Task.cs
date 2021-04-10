using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomRollTask
{
    class Task
    {
        public string title { get; set; }
        public Task(string title) {
            this.title = title;
        }

        public override string ToString()
        {
            return title;
        }
    }
}
