using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomRollTask
{
    class MemberManager
    {
        private List<Member> members;
        public MemberManager() {
            members = new List<Member>();
        }
        public Member[] GetMembers() {
            return members.ToArray();
        }
        public bool addMemebers(string name) {
            if (!Check_If_Is_Exist_In_List(name))
            {
                members.Add(new Member(name));
                return true;
            }
            return false;
        }
        public void removemember(string name) {
            for (int i = 0; i < members.Count(); i++) {
                if (members[i].name.Equals(name)) {
                    members.RemoveAt(i);
                }
            }
        }
        public Task[] getMemeberTask(string name) {
            foreach (Member m in members) {
                if (m.name.Equals(name)) {
                    return m.GetTasks();
                }    
            }    
            return null;
        }
        private bool Check_If_Is_Exist_In_List(string name) {
            foreach (Member m in members)
            {
                if (m.name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        public void CleanMembers() {
            members.Clear();
        }
        
    }
}
