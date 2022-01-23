using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkademineSistema.Backend.Repositorys;
using AkademineSistema.Backend.Objects;

namespace AkademineSistema.Frontend.Controlers.AdminControls
{
    public partial class GroupButtonControl : UserControl
    {
        public GroupButtonControl()
        {
            InitializeComponent();
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            UserRepository usRepository = new UserRepository();
            ActionRepository acRepository = new ActionRepository();

            GroupName newGroupName = new GroupName(groupTextBox.Text);
            acRepository.AddGroupName(newGroupName);

            groupCheckBoxList.Items.Clear();
            List<GroupName> groupNameList = usRepository.GetGroupsName();
            for (int i = 0; i < groupNameList.Count; i++)
            {
                groupCheckBoxList.Items.Add(groupNameList[i].Name);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            UserRepository usRepository = new UserRepository();
            ActionRepository acRepository = new ActionRepository();
            List<GroupName> groupNameList = usRepository.GetGroupsName();
            var checkedList = groupCheckBoxList.CheckedItems;

            foreach (GroupName groupName in groupNameList)
            {
                foreach(string selected in checkedList)
                {
                    if(selected == groupName.GetGroupName())
                    {
                        acRepository.RemoveGroup(groupName);
                        break;
                    }
                }   
            }

            groupCheckBoxList.Items.Clear();
            groupNameList = usRepository.GetGroupsName();
            for (int i = 0; i < groupNameList.Count; i++)
            {
                groupCheckBoxList.Items.Add(groupNameList[i].Name);
            }


        }
        private void GroupButtonControl_Load(object sender, EventArgs e)
        {
            groupCheckBoxList.Items.Clear();
            UserRepository usRepository = new UserRepository();
            List<GroupName> groupNameList = usRepository.GetGroupsName();

            for(int i = 0; i < groupNameList.Count; i++)
            {
                groupCheckBoxList.Items.Add(groupNameList[i].Name);
            }
            
        }

        private void groupsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
