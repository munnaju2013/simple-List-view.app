using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleListView.app
{
    public partial class SimpleListView : Form
    {
        public SimpleListView()
        {
            InitializeComponent();
        }

        List<employee> employeeList = new List<employee>();
 
        private void saveButton_Click(object sender, EventArgs e)
        {
            employee anEmployee = new employee();
            anEmployee.id = idTextBox.Text;
            anEmployee.name = nameTextBox.Text;
            anEmployee.salary = salaryTextBox.Text;
            anEmployee.address = addressTextBox.Text;

            employeeList.Add(anEmployee);

            InsertIntoListView(anEmployee);

            ClearTextBox();
        }

        private void ClearTextBox()
        {
            idTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            salaryTextBox.Text = String.Empty;
            addressTextBox.Text = String.Empty;
        }

        private void InsertIntoListView(employee anEmployee)
        {
            ListViewItem item = new ListViewItem(anEmployee.id);
            item.SubItems.Add(anEmployee.name);
            item.SubItems.Add(anEmployee.salary);
            item.SubItems.Add(anEmployee.address);
            showListView.Items.Add(item);
        }

        private void showListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = showListView.SelectedIndices[0];
            idTextBox.Text = employeeList[selectedIndex].id;
            nameTextBox.Text = employeeList[selectedIndex].name;
            salaryTextBox.Text = employeeList[selectedIndex].salary;
            addressTextBox.Text = employeeList[selectedIndex].address;
        }

      
    }
}
