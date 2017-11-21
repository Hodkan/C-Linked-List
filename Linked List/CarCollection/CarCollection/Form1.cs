using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ali Albayrak - P304320 - Assesment 1.1
namespace CarCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList<string> myCarCollection = new LinkedList<string>();

       
        //Show Method
        private void showLinkedList()
        {
            // clear input boxes and list box
            listBoxOutput.Items.Clear();
            textBoxCarName.Clear();
            textBoxNodePosition.Clear();
            // display number of list nodes
            textBoxNumOfNodes.Text = numberOfNodes().ToString();
            // display linked list
            foreach (string car in myCarCollection)
                listBoxOutput.Items.Add(car);
        }

        //number of nodes
        private int numberOfNodes()
        {
            return myCarCollection.Count;
        }



        // Add first button
        private void buttonAdd_First_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text))
            {
                myCarCollection.AddFirst(textBoxCarName.Text);
                showLinkedList();
            }
            else
                MessageBox.Show("Please enter a Car name");
        }

        //add last button
        private void buttonAdd_Last_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text))
            {
                myCarCollection.AddLast(textBoxCarName.Text);
                showLinkedList();
            }
            else
                MessageBox.Show("Please enter a Car name");
        }

        //Add before button
        private void buttonAdd_Before_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text) &&
                        (!string.IsNullOrEmpty(textBoxNodePosition.Text)))

            {
                try
                {
                    int nodePos = Convert.ToInt32(textBoxNodePosition.Text);
                    string x = myCarCollection.ElementAt(nodePos);
                    LinkedListNode<string> current = myCarCollection.Find(x);
                    myCarCollection.AddBefore(current, textBoxCarName.Text);
                    showLinkedList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter valid node number (Node Position cannot be greater than " + ((myCarCollection.Count) - 1) + " )");  // List index starts with 0 that is why "-1"

                }
            }
            else
                MessageBox.Show("Please enter a Car name and Node position");
        }

        //Add after button
        private void buttonAdd_After_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text) &&
                    (!string.IsNullOrEmpty(textBoxNodePosition.Text)))
            {
                try
                {
                    int nodePos = Convert.ToInt32(textBoxNodePosition.Text);
                    string x = myCarCollection.ElementAt(nodePos);
                    LinkedListNode<string> current = myCarCollection.Find(x);
                    myCarCollection.AddAfter(current, textBoxCarName.Text);
                    showLinkedList();
                }
                catch(Exception)
                {
                    MessageBox.Show("Please enter valid node number (Node Position cannot be greater than " + ((myCarCollection.Count)-1) + " )");          // List index starts with 0 that is why "-1"

                }
                
            }
            else
                MessageBox.Show("Please enter a Car name and Node position");
        }

        //Remove button
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCarName.Text))
            {
                myCarCollection.Remove(textBoxCarName.Text);
                showLinkedList();
            }
            else
                MessageBox.Show("Please enter a Car name");
        }


        //Clear Button
        private void buttonClear_Click(object sender, EventArgs e)
        {
            myCarCollection.Clear();
            showLinkedList();
        }

        //Search button
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string current = myCarCollection.Find((textBoxCarName.Text)).Value;         
                int a = listBoxOutput.Items.IndexOf(current);
                listBoxOutput.SetSelected(a, true);                                         // Finds the element and sets it selected on the listbox
            }
            catch (Exception)
            {
                MessageBox.Show("Car could not found.");

            }
        }

     
    }
}
