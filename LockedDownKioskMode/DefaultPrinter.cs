using System;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LockedDownKioskMode
{
    public partial class DefaultPrinter : Form
    {
        //Global Variables Here
        private ListBox.SelectedObjectCollection ListBoxSelections;

        //Constructors Here
        public DefaultPrinter()
        {
            InitializeComponent();
            listAllPrinters();
        }

        //Button Click Methods
        private void CurrentDefaultButton_Click(object sender, EventArgs e)
        {
            PrinterSettings settings = new PrinterSettings();
            if (settings.PrinterName != null)
            {
                DialogResult newDefault = MessageBox.Show("Default Printer is Currently: " + settings.PrinterName);
            }
            else
            {
                DialogResult newDefault = MessageBox.Show("No Default Printer Currently Set.");
            }
        }

        private void SetDefaultButton_Click(object sender, EventArgs e)
        {
            ListBoxSelections = new ListBox.SelectedObjectCollection(PrinterListBox);
            ListBoxSelections = PrinterListBox.SelectedItems;

            if (ListBoxSelections.Count == 0)
            {
                DialogResult newDefault1 = MessageBox.Show("No Default Printer Selected. Try Again.");
            }
            else
            {
                string printerName = PrinterListBox.SelectedItem.ToString();
                PrinterList.SetDefaultPrinter(printerName);

                DialogResult newDefault = MessageBox.Show("Default Printer is now: " + printerName);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //Method for Showing Printers in ListBox
        private void listAllPrinters()
        {
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                PrinterListBox.Items.Add(item.ToString());
            }
        }
    }

    //Class for calling Printer Settings
    public static class PrinterList
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);
    }
}
