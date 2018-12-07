using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockedDownKioskMode
{
    public partial class DefaultPrinter : Form
    {
        public DefaultPrinter()
        {
            InitializeComponent();
            listAllPrinters();
        }

        private void CurrentDefaultButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SetDefaultButton_Click(object sender, EventArgs e)
        {
            string printerName = PrinterListBox.SelectedItem.ToString();
            myPrinters.SetDefaultPrinter(printerName);

            DialogResult newDefault = MessageBox.Show("Default Printer is now: " + printerName);

            //Need If Statement to Catch if someone doesnt select something
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void listAllPrinters()
        {
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                PrinterListBox.Items.Add(item.ToString());
            }
        }
    }

    public static class myPrinters
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);

    }
}
