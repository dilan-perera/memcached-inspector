using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemcachedInspector.UI.Windows.Forms
{
    partial class SplashScreenForm : Form
    {

        private const int OwnerDisplayThreshold = 2;

        private const int SplashClosureThreshold = 3;

        private int splashClosureAttempts = 0;

        private bool CanShowOwner
        {
            get
            {
                return (this.splashClosureAttempts == SplashScreenForm.OwnerDisplayThreshold);
            }
        }

        private bool CanCloseSplash
        {
            get
            {
                return (this.splashClosureAttempts == SplashScreenForm.SplashClosureThreshold);
            }
        }

        public SplashScreenForm()
        {
            this.InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (this.CanShowOwner)
            {
                this.Owner.Show();

                e.Cancel = true;
            }
            else if (this.CanCloseSplash)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            this.Owner.Cursor = Cursors.Default;
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            this.Owner.Cursor = Cursors.AppStarting;

            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.timer.Stop();

            this.splashClosureAttempts++;

            this.Close();

            this.timer.Start();
        }
    }
}
