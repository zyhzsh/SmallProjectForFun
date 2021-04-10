using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomRollTask
{
    class RandomTaskAssigner
    {
        private List<string> result;
        public RandomTaskAssigner()
        {
            result = new List<string>();
        }
        public void RandomAssignTask(Member[] members, Task[] tasks)
        {
            if (members.Length == 0 || tasks.Length == 0) { throw new Exception("Plese Check Your Member List and Task List"); }
            if (tasks.Length % members.Length != 0)
            {
                throw new Exception("Members and tasks should be equally distributed, Plese Check Your Member List and Task List");
            }
            else
            {
                result.Clear();
                foreach (Member m in members) {
                    m.tasks.Clear(); 
                }
                int number_of_tasks_per_member = tasks.Length / members.Length;
                List<Member> memberlist = new List<Member>();
                memberlist.AddRange(members);
                List<Task> tasklist = new List<Task>();
                tasklist.AddRange(tasks);
                Random random = new Random();      
                while (memberlist.Count!=0) {
                    int rd_task_index = 0;
                    if (tasklist.Count!=0) {  rd_task_index = random.Next(0, tasklist.Count);}
                    if (memberlist[0].GetTasks().Length < number_of_tasks_per_member)
                    {
                        bool result = memberlist[0].addTask(tasklist[rd_task_index]);
                        if (result) { tasklist.RemoveAt(rd_task_index); }
                    }
                    else {
                        foreach (Task t in memberlist[0].GetTasks()) {
                            result.Add("Member: " +memberlist[0].name+ " Task: "+ t.title);
                        }
                        memberlist.RemoveAt(0);
                    }
                }
            }
        }
        public string[] getResult()
        {
            return result.ToArray();
        }
    }
}