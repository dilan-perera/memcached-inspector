using MemcachedInspector.UI.Process.Events;
using MemcachedInspector.UI.Process.Models;
using MemcachedInspector.UI.Process.ViewModels;
using MemcachedInspector.UI.Windows.Controls;
using MemcachedInspector.UI.Windows.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemcachedInspector.UI.Windows.Forms
{
    public partial class CacheOperationsForm : Form
    {

        private CacheOperationsViewModel ViewModel { get; set; } = new CacheOperationsViewModel();

        public CacheOperationsForm()
        {
            this.InitializeComponent();

            this.connectionDataGridView.Columns.Clear();
            this.connectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.nameColumn,
                this.hostNameColumn,
                this.portColumn});

            this.ViewModel.ConnectionAvailable += this.ViewModel_ConnectionAvailable;
            this.ViewModel.ConnectionAdded += this.ViewModel_ConnectionAdded;
            this.ViewModel.SessionStarted += this.ViewModel_SessionStarted;
            this.ViewModel.SessionEnded += this.ViewModel_SessionEnded;

            this.Hide();
            this.ShowSplashScreen();
        }

        private void ViewModel_ConnectionAvailable(object sender, ConnectionEventArgs e)
        {
            this.OnConnectionAdded(e.Connection);
        }

        private void ViewModel_ConnectionAdded(object sender, ConnectionEventArgs e)
        {
            this.OnConnectionAdded(e.Connection);
        }

        private void ViewModel_SessionStarted(object sender, SessionEventArgs e)
        {
            this.AddSession(e.Session);
        }

        private void ViewModel_SessionEnded(object sender, SessionEventArgs e)
        {
            this.CloseSession(e.Session);
        }

        private void ShowSplashScreen()
        {
            SplashScreenForm splashScreen = new SplashScreenForm();

            splashScreen.ShowDialog(this);
        }

        private void AboutApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AboutForm();

            form.ShowDialog(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.HandleConnectionAddRequest();
        }

        private void CacheOperationsForm_Load(object sender, EventArgs e)
        {
            this.connectionDataGridView.AutoGenerateColumns = false;

            this.Initialize();
        }

        private void Initialize()
        {
            this.ViewModel.Initialize();
        }

        private void ConnectionDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.connectionDataGridView.Rows[e.RowIndex];

            Connection connection = row.DataBoundItem as Connection;

            this.ViewModel.StartSession(connection);
        }

        private void CacheOperationsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ViewModel.SaveConnections();
        }

        private void HandleConnectionAddRequest()
        {
            ConnectionForm form = new ConnectionForm();

            DialogResult result = form.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                this.AddConnection(form.Connection);
            }
        }

        private void AddConnection(Connection connection)
        {
            try
            {
                this.ViewModel.Register(connection);
            }
            catch
            {
                MessageBox.Show(this, Resources.ConnectionAddError);
            }
        }

        private void HandleConnectionRemovalRequest(Connection connection)
        {
            try
            {
                this.ViewModel.Unregister(connection);
            }
            catch
            {
                MessageBox.Show(this, Resources.ConnectionRemovalError);
            }
        }

        private void OnConnectionAdded(Connection connection)
        {
            this.connectionBindingSource.Add(connection);
        }

        private void AddSession(Session session)
        {
            string tabTitle = string.Format(CultureInfo.CurrentUICulture,
                Resources.SessionTabTitleFormat,
                session.Connection.Name,
                session.Connection.HostName,
                session.Connection.Port);
            string tabTooltip = string.Format(CultureInfo.CurrentUICulture,
                Resources.SessionTabTooltipFormat,
                session.Connection.Name,
                session.Connection.HostName,
                session.Connection.Port);

            TabPage tab = new TabPage();

            tab.Tag = session;
            tab.Text = tabTitle;
            tab.ToolTipText = tabTooltip;

            CacheOperationsControl tabControl = new CacheOperationsControl(session);

            tabControl.Dock = DockStyle.Fill;
            tabControl.BorderStyle = BorderStyle.None;

            tab.Controls.Clear();
            tab.Controls.Add(tabControl);

            this.sessionTabControl.TabPages.Add(tab);
        }

        private void CloseSession(Session session)
        {

        }
    }
}
