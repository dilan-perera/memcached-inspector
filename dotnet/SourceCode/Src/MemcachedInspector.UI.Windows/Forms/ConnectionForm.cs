using MemcachedInspector.Common;
using MemcachedInspector.UI.Process.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemcachedInspector.UI.Windows.Forms
{
    public partial class ConnectionForm : Form
    {

        public Connection Connection
        {
            get;
            private set;
        }

        public ConnectionForm() : this(new Connection(
            ConnectionSettings.DefaultConnectionName,
            ConnectionSettings.DefaultHostName,
            ConnectionSettings.DefaultPort))
        {
        }

        public ConnectionForm(Connection connection)
        {
            this.Connection = connection;
            this.InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            this.BindModelToView();
        }

        private void AcceptActionButton_Click(object sender, EventArgs e)
        {
            this.BindViewToModel();
        }

        private void BindModelToView()
        {
            if (this.Connection != null)
            {
                this.nameDataTextBox.Text = this.Connection.Name;
                this.hostNameDataTextBox.Text = this.Connection.HostName;
                this.portDataNumericUpDown.Value = this.Connection.Port;
            }
        }

        private void BindViewToModel()
        {
            if (this.Connection != null)
            {
                this.Connection.Name = this.nameDataTextBox.Text;
                this.Connection.HostName = this.hostNameDataTextBox.Text;
                this.Connection.Port = Convert.ToInt32(this.portDataNumericUpDown.Value);
            }
        }
    }
}
