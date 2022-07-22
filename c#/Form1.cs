using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;




namespace Perf_monitor
{
    public partial class Form1 : Form
    {
        NotifyIcon notifyIcon;
        Icon dbIcon;
        Icon monitorIcon;
        Icon usbIcon;
        Icon processorIcon;


        public Form1()
        {
            InitializeComponent();
            updateInfo();
         //   var aTimer = new System.Timers.Timer(1000);
         //   aTimer.Elapsed += OnTimedEvent;
         //   aTimer.Enabled = true;
            #region icons
            dbIcon = new Icon("db_settings_icon.ico");
            monitorIcon = new Icon("monitor_settings_icon.ico");
            usbIcon = new Icon("usb_icon.ico");
            processorIcon = new Icon("processor_icon.ico");

            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = processorIcon;
            notifyIcon.Visible = true;
            #endregion



            #region contextmenu
            MenuItem quitMenuItem = new MenuItem("Quit");

            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(quitMenuItem);

            notifyIcon.ContextMenu = contextMenu;

            quitMenuItem.Click += QuitMenuItem_Click;
            #endregion

            // hide the form
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

        }

        //closing the app
        private void QuitMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Dispose();
            Close();
        }

        public void updateInfo()
        {
            if (CPUdata.CPUName != null)
            {
                cpunamevar.Text = Convert.ToString(CPUdata.CPUName);
                cpuvoltvar.Text = Convert.ToString(CPUdata.CPUVolt) + "V";
                cpuclockspeedvar.Text = Convert.ToString(CPUdata.CPUClock) + "MHz";
            }
        }

       // private static void OnTimedEvent(Object source, EventArgs e)
       // {
       //     if (CPUdata.CPUUtility != 0)
       //     {
       //         Console.WriteLine(CPUdata.CPUUtility);
       //     };
       // }

    }
}
