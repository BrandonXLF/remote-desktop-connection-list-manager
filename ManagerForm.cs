using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RDCLM
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            IntialSetup();
        }

        private RegistryKey key;
        private ListBox.SelectedIndexCollection selectedIndices;

        private void ManagerFormLoad(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(add, "Add");
            new ToolTip().SetToolTip(remove, "Remove selected");
            new ToolTip().SetToolTip(up, "Move selected up");
            new ToolTip().SetToolTip(down, "Move selected down");
        }

        private void IntialSetup()
        {
            selectedIndices = computers.SelectedIndices;
            key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Terminal Server Client\Default");
            foreach (var computer in key.GetValueNames())
            {
                computers.Items.Add(key.GetValue(computer));
            }
            CleanUp();
        }

        private void CleanUp()
        {
            foreach (var computer in key.GetValueNames())
            {
                key.DeleteValue(computer);
            }
            for (int i = 0; i < computers.Items.Count; i++)
            {
                key.SetValue("MRU" + i, computers.Items[i]);
            }
            add.Enabled = computers.Items.Count < 10;
        }

        private void UpOnClick(object sender, EventArgs e)
        {
            if (selectedIndices.Count > 0 && selectedIndices[0] > 0)
            {
                for (int i = 0; i < selectedIndices.Count; i++)
                {
                    int place = selectedIndices[i];
                    string value = (string)computers.Items[place];
                    computers.Items.RemoveAt(place);
                    computers.Items.Insert(place - 1, value);
                    computers.SetSelected(place - 1, true);
                }
                CleanUp();
            }
        }

        private void DownOnClick(object sender, EventArgs e)
        {
            if (selectedIndices.Count > 0 && selectedIndices[selectedIndices.Count - 1] + 1 < computers.Items.Count)
            {
                for (int i = selectedIndices.Count - 1; i >= 0; i--)
                {
                    int place = selectedIndices[i];
                    string value = (string)computers.Items[place];
                    computers.Items.RemoveAt(place);
                    computers.Items.Insert(place + 1, value);
                    computers.SetSelected(place + 1, true);
                }
                CleanUp();
            }
        }

        private void AddInputKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                AddOnClick(sender, e);
            }
        }

        private void AddOnClick(object sender, EventArgs e)
        {
            if (addInput.Text != "" && computers.Items.Count < 10)
            {
                key.SetValue("MRU" + key.GetValueNames().Length, addInput.Text);
                computers.Items.Add(addInput.Text);
                addInput.Text = "";
                computers.ClearSelected();
                computers.SetSelected(computers.Items.Count - 1, true);
            }
            CleanUp();
        }

        private void RemoveOnClick(object sender, EventArgs e)
        {
            if (selectedIndices.Count > 0) {
                for (int i = selectedIndices.Count - 1; i >= 0; i--)
                {
                    int place = selectedIndices[i];
                    computers.Items.RemoveAt(place);
                    if (computers.Items.Count > 0 && place >= computers.Items.Count - 1)
                    {
                        computers.SetSelected(computers.Items.Count - 1, true);
                    } else if (computers.Items.Count > 0)
                    {
                        computers.SetSelected(place, true);
                    }
                }
                CleanUp();
            }
        }
    }
}