using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomRollTask
{
    class Member
    {
        public string name { get; set; }
        public List<Task> tasks;
        public Member(string name)
        {
            this.name = name;
            tasks = new List<Task>();
        }
        public bool addTask(Task task) {
            foreach (Task t in tasks) {
                if (t.title.Equals(task.title)) {
                    return false;
                }
            }
            tasks.Add(task);
            return true;
        }
        public Task[] GetTasks() {
            return tasks.ToArray();
        }

        public override string ToString() {
            return name;
        }

    }
}
