using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomRollTask
{
    class TaskManager
    {
        private List<Task> tasks;
        public TaskManager()
        {
            tasks = new List<Task>();
        }
        public Task[] GetTasks()
        {
            return tasks.ToArray();
        }
        public bool addTask(string title)
        {
            if (!Check_If_Is_Exist_In_List(title))
            {
                tasks.Add(new Task(title));
                return true;
            }
            return false;
        }
        public void removemember(string name)
        {
            for (int i = 0; i < tasks.Count(); i++)
            {
                if (tasks[i].title.Equals(name))
                {
                    tasks.RemoveAt(i);
                }
            }
        }
        private bool Check_If_Is_Exist_In_List(string title)
        {
            foreach (Task m in tasks)
            {
                if (m.title.Equals(title))
                {
                    return true;
                }
            }
            return false;
        }
        public void ClearTasks() {
            tasks.Clear();
        }
        
    }
}
