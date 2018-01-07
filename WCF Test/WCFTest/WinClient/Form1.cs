using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkerService.WorkerServiceClient client = new WorkerService.WorkerServiceClient();
            Guid sessionId = Guid.NewGuid();
            Request request = new Request() { SessionId = sessionId };
            var response = client.GetData(request);
            
            if(response.SessionId == sessionId)
            {
                MessageBox.Show("It Worked!");
            }
        }
    }
}
