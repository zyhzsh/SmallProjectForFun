namespace RandomRollTask
{
    partial class RandomAssign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox_members = new System.Windows.Forms.ListBox();
            this.textBox_member_name = new System.Windows.Forms.TextBox();
            this.btn_add_memeber = new System.Windows.Forms.Button();
            this.btn_remove_memeber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_remove_task = new System.Windows.Forms.Button();
            this.btn_add_task = new System.Windows.Forms.Button();
            this.textBox_task_title = new System.Windows.Forms.TextBox();
            this.listbox_tasks = new System.Windows.Forms.ListBox();
            this.listBox_random_list = new System.Windows.Forms.ListBox();
            this.btn_random_assign_task = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbnumberofmember = new System.Windows.Forms.Label();
            this.lbnumberoftasks = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearallmembers = new System.Windows.Forms.Button();
            this.Task = new System.Windows.Forms.GroupBox();
            this.btnClearAllTasks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Task.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox_members
            // 
            this.listbox_members.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_members.FormattingEnabled = true;
            this.listbox_members.ItemHeight = 25;
            this.listbox_members.Location = new System.Drawing.Point(6, 45);
            this.listbox_members.Name = "listbox_members";
            this.listbox_members.Size = new System.Drawing.Size(370, 254);
            this.listbox_members.TabIndex = 0;
            // 
            // textBox_member_name
            // 
            this.textBox_member_name.Location = new System.Drawing.Point(86, 19);
            this.textBox_member_name.Name = "textBox_member_name";
            this.textBox_member_name.Size = new System.Drawing.Size(207, 20);
            this.textBox_member_name.TabIndex = 1;
            // 
            // btn_add_memeber
            // 
            this.btn_add_memeber.Location = new System.Drawing.Point(299, 19);
            this.btn_add_memeber.Name = "btn_add_memeber";
            this.btn_add_memeber.Size = new System.Drawing.Size(77, 23);
            this.btn_add_memeber.TabIndex = 2;
            this.btn_add_memeber.Text = "Add Member";
            this.btn_add_memeber.UseVisualStyleBackColor = true;
            this.btn_add_memeber.Click += new System.EventHandler(this.btn_add_memeber_Click);
            // 
            // btn_remove_memeber
            // 
            this.btn_remove_memeber.Location = new System.Drawing.Point(6, 310);
            this.btn_remove_memeber.Name = "btn_remove_memeber";
            this.btn_remove_memeber.Size = new System.Drawing.Size(98, 23);
            this.btn_remove_memeber.TabIndex = 3;
            this.btn_remove_memeber.Text = "Remove Member";
            this.btn_remove_memeber.UseVisualStyleBackColor = true;
            this.btn_remove_memeber.Click += new System.EventHandler(this.btn_remove_memeber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MemberName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TaskTitle";
            // 
            // btn_remove_task
            // 
            this.btn_remove_task.Location = new System.Drawing.Point(6, 310);
            this.btn_remove_task.Name = "btn_remove_task";
            this.btn_remove_task.Size = new System.Drawing.Size(94, 23);
            this.btn_remove_task.TabIndex = 8;
            this.btn_remove_task.Text = "Remove Task";
            this.btn_remove_task.UseVisualStyleBackColor = true;
            this.btn_remove_task.Click += new System.EventHandler(this.btn_remove_task_Click);
            // 
            // btn_add_task
            // 
            this.btn_add_task.Location = new System.Drawing.Point(307, 17);
            this.btn_add_task.Name = "btn_add_task";
            this.btn_add_task.Size = new System.Drawing.Size(69, 23);
            this.btn_add_task.TabIndex = 7;
            this.btn_add_task.Text = "Add Task";
            this.btn_add_task.UseVisualStyleBackColor = true;
            this.btn_add_task.Click += new System.EventHandler(this.btn_add_task_Click);
            // 
            // textBox_task_title
            // 
            this.textBox_task_title.Location = new System.Drawing.Point(63, 19);
            this.textBox_task_title.Name = "textBox_task_title";
            this.textBox_task_title.Size = new System.Drawing.Size(238, 20);
            this.textBox_task_title.TabIndex = 6;
            // 
            // listbox_tasks
            // 
            this.listbox_tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_tasks.FormattingEnabled = true;
            this.listbox_tasks.ItemHeight = 25;
            this.listbox_tasks.Location = new System.Drawing.Point(6, 45);
            this.listbox_tasks.Name = "listbox_tasks";
            this.listbox_tasks.Size = new System.Drawing.Size(370, 254);
            this.listbox_tasks.TabIndex = 5;
            // 
            // listBox_random_list
            // 
            this.listBox_random_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_random_list.FormattingEnabled = true;
            this.listBox_random_list.ItemHeight = 20;
            this.listBox_random_list.Location = new System.Drawing.Point(12, 417);
            this.listBox_random_list.Name = "listBox_random_list";
            this.listBox_random_list.Size = new System.Drawing.Size(770, 184);
            this.listBox_random_list.TabIndex = 10;
            // 
            // btn_random_assign_task
            // 
            this.btn_random_assign_task.Location = new System.Drawing.Point(10, 369);
            this.btn_random_assign_task.Name = "btn_random_assign_task";
            this.btn_random_assign_task.Size = new System.Drawing.Size(772, 42);
            this.btn_random_assign_task.TabIndex = 11;
            this.btn_random_assign_task.Text = "Random Assign";
            this.btn_random_assign_task.UseVisualStyleBackColor = true;
            this.btn_random_assign_task.Click += new System.EventHandler(this.btn_random_assign_task_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Member:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Task:";
            // 
            // lbnumberofmember
            // 
            this.lbnumberofmember.AutoSize = true;
            this.lbnumberofmember.Location = new System.Drawing.Point(303, 315);
            this.lbnumberofmember.Name = "lbnumberofmember";
            this.lbnumberofmember.Size = new System.Drawing.Size(0, 13);
            this.lbnumberofmember.TabIndex = 14;
            // 
            // lbnumberoftasks
            // 
            this.lbnumberoftasks.AutoSize = true;
            this.lbnumberoftasks.Location = new System.Drawing.Point(330, 315);
            this.lbnumberoftasks.Name = "lbnumberoftasks";
            this.lbnumberoftasks.Size = new System.Drawing.Size(0, 13);
            this.lbnumberoftasks.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearallmembers);
            this.groupBox1.Controls.Add(this.listbox_members);
            this.groupBox1.Controls.Add(this.btn_remove_memeber);
            this.groupBox1.Controls.Add(this.lbnumberofmember);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_member_name);
            this.groupBox1.Controls.Add(this.btn_add_memeber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 344);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member";
            // 
            // btnClearallmembers
            // 
            this.btnClearallmembers.Location = new System.Drawing.Point(110, 310);
            this.btnClearallmembers.Name = "btnClearallmembers";
            this.btnClearallmembers.Size = new System.Drawing.Size(94, 23);
            this.btnClearallmembers.TabIndex = 15;
            this.btnClearallmembers.Text = "Clear All";
            this.btnClearallmembers.UseVisualStyleBackColor = true;
            this.btnClearallmembers.Click += new System.EventHandler(this.btnClearallmembers_Click);
            // 
            // Task
            // 
            this.Task.Controls.Add(this.btnClearAllTasks);
            this.Task.Controls.Add(this.listbox_tasks);
            this.Task.Controls.Add(this.textBox_task_title);
            this.Task.Controls.Add(this.lbnumberoftasks);
            this.Task.Controls.Add(this.btn_add_task);
            this.Task.Controls.Add(this.label4);
            this.Task.Controls.Add(this.btn_remove_task);
            this.Task.Controls.Add(this.label2);
            this.Task.Location = new System.Drawing.Point(400, 12);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(382, 344);
            this.Task.TabIndex = 17;
            this.Task.TabStop = false;
            this.Task.Text = "Task";
            // 
            // btnClearAllTasks
            // 
            this.btnClearAllTasks.Location = new System.Drawing.Point(106, 310);
            this.btnClearAllTasks.Name = "btnClearAllTasks";
            this.btnClearAllTasks.Size = new System.Drawing.Size(94, 23);
            this.btnClearAllTasks.TabIndex = 16;
            this.btnClearAllTasks.Text = "Clear All";
            this.btnClearAllTasks.UseVisualStyleBackColor = true;
            this.btnClearAllTasks.Click += new System.EventHandler(this.btnClearAllTasks_Click);
            // 
            // RandomAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 616);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_random_assign_task);
            this.Controls.Add(this.listBox_random_list);
            this.Name = "RandomAssign";
            this.Text = "Random Assign";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Task.ResumeLayout(false);
            this.Task.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_members;
        private System.Windows.Forms.TextBox textBox_member_name;
        private System.Windows.Forms.Button btn_add_memeber;
        private System.Windows.Forms.Button btn_remove_memeber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_remove_task;
        private System.Windows.Forms.Button btn_add_task;
        private System.Windows.Forms.TextBox textBox_task_title;
        private System.Windows.Forms.ListBox listbox_tasks;
        private System.Windows.Forms.ListBox listBox_random_list;
        private System.Windows.Forms.Button btn_random_assign_task;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbnumberofmember;
        private System.Windows.Forms.Label lbnumberoftasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Task;
        private System.Windows.Forms.Button btnClearallmembers;
        private System.Windows.Forms.Button btnClearAllTasks;
    }
}

