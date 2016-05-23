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
    public partial class ObjectExplorerForm : Form
    {

        public object Data
        {
            get;
            private set;
        }

        public ObjectExplorerForm(object data)
        {
            this.Data = data;
            this.InitializeComponent();
        }

        private void ObjectExplorerForm_Load(object sender, EventArgs e)
        {
            this.objectDataPropertyGrid.SelectedObject = this.Data;
        }

    }
}
