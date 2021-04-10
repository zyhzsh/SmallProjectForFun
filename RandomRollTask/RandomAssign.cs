using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomRollTask
{
    public partial class RandomAssign : Form
    {
        private MemberManager memberManager;
        private TaskManager taskManager;
        private RandomTaskAssigner randomTaskAssigner;
        
        public RandomAssign()
        {
            InitializeComponent();
            memberManager = new MemberManager();
            taskManager = new TaskManager();
            randomTaskAssigner = new RandomTaskAssigner();
            memberManager.addMemebers("S.Zhu");
            memberManager.addMemebers("David");
            memberManager.addMemebers("Joost");
            memberManager.addMemebers("Nino");
            memberManager.addMemebers("Rares");
            Up_Date_Member_List_Box();
            Up_Date_Task_List_Box();
        }

        private void Up_Date_Member_List_Box() {
            listbox_members.Items.Clear();
            listbox_members.Items.AddRange(memberManager.GetMembers());
            lbnumberofmember.Text = listbox_members.Items.Count.ToString();
        }

        private void Up_Date_Task_List_Box() {
            listbox_tasks.Items.Clear();
            listbox_tasks.Items.AddRange(taskManager.GetTasks());
            lbnumberoftasks.Text = listbox_tasks.Items.Count.ToString();
        }

        private void Up_Date_Random_Task_List_Box() {
            listBox_random_list.Items.Clear();
            listBox_random_list.Items.AddRange(randomTaskAssigner.getResult());
        }

        private void btn_add_memeber_Click(object sender, EventArgs e)
        {
            if (textBox_member_name.Text != ""){
                string name = textBox_member_name.Text;
                memberManager.addMemebers(name);
                Up_Date_Member_List_Box();
            }
        }

        private void btn_remove_memeber_Click(object sender, EventArgs e)
        {
            if (listbox_members.SelectedItem != null) {
                string name = listbox_members.SelectedItem.ToString();
                memberManager.removemember(name);
                Up_Date_Member_List_Box();
            }
        }

        private void btn_add_task_Click(object sender, EventArgs e)
        {
            if (textBox_task_title.Text != "") {
                string title = textBox_task_title.Text;
                taskManager.addTask(title);
                Up_Date_Task_List_Box();
            }
        }

        private void btn_remove_task_Click(object sender, EventArgs e)
        {
            if (listbox_tasks.SelectedItem != null){
                string title = listbox_tasks.SelectedItem.ToString();
                taskManager.removemember(title);
                Up_Date_Task_List_Box();
            }

        }
        private void btn_random_assign_task_Click(object sender, EventArgs e)
        {
            try
            {
                randomTaskAssigner.RandomAssignTask(memberManager.GetMembers(), taskManager.GetTasks());
                Up_Date_Random_Task_List_Box();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message.ToString());
            }

        }

        private void btnClearallmembers_Click(object sender, EventArgs e)
        {
            memberManager.CleanMembers();
            Up_Date_Member_List_Box();
        }

        private void btnClearAllTasks_Click(object sender, EventArgs e)
        {
            taskManager.ClearTasks();
            Up_Date_Task_List_Box();
        }
    }
}
