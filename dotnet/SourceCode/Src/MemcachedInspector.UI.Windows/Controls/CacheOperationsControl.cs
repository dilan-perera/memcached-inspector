using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemcachedInspector.UI.Process.ViewModels;
using MemcachedInspector.UI.Process.Models;

namespace MemcachedInspector.UI.Windows.Controls
{
    public partial class CacheOperationsControl : UserControl
    {

        private CacheSessionViewModel ViewModel { get; set; }

        public CacheOperationsControl(Session session)
        {
            this.ViewModel = new CacheSessionViewModel(session);
            this.InitializeComponent();
        }

        private void CacheOperationsControl_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.ViewModel.Initialize();
        }
    }
}
