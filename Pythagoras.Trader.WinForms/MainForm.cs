using Pythagoras.Infrastructure.WinForms.CubeForms.ClockSignal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pythagoras.Trader.WinForms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void simpleButtonClockSignal_Click(object sender, EventArgs e)
        {
            var form = new ClockSignalForm(Properties.Settings.Default.ClockSignalServerUrl);
            form.ShowInTaskbar = false;
            form.Show(this);
        }
    }
}
