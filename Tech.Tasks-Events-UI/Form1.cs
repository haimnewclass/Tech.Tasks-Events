using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tech.Tasks_Events.Core;
namespace Tech.Tasks_Events_UI
{
    public partial class Form1 : Form
    {
        Manager manager = new Manager();
        int a = 0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void HttpJob_HandlerUpdate(QueueItem item)
        {
            // UpdateControls
            // Safe mode 
            
          
                a++;
            // Invoke from UI thread
            if(label1.InvokeRequired)
            {
                label1.Invoke(new Action(() => {
                    label1.Text = manager.queueTask1.q.Count.ToString();
                }));
                label2.Invoke(new Action(() => {
                    label2.Text = manager.queueTask2.q.Count.ToString();
                }));
                label3.Invoke(new Action(() => {
                    label3.Text = manager.queueTask3.q.Count.ToString();
                }));
                label4.Invoke(new Action(() => {
                    label4.Text = $"{item.Num} at {item.now.ToShortTimeString()}";
                }));
            }
            else
            {
                UpdateControls();
            }
        }

        private void UpdateControls()
        {
            label1.Text = manager.queueTask1.q.Count.ToString();
            label2.Text = manager.queueTask2.q.Count.ToString();
            label3.Text = manager.queueTask3.q.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            manager.Run();
            manager.httpJob.HandlerUpdate += HttpJob_HandlerUpdate;
            UpdateControls();
        }
    }
}
