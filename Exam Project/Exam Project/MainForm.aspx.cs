using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace ExamProject3
{
    public partial class MainForm : System.Web.UI.Page
    {
        ArrayList PageFrames = new ArrayList();
        ArrayList HDD = new ArrayList();
        ArrayList TLB = new ArrayList();
        Random Rand = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnComplete_Click(object sender, EventArgs e)
        {
            int OSMem = Convert.ToInt16(txtOSMem.Text);
            int PFSize = Convert.ToInt16(txtPFSize.Text);
            int ServerMem = 2000;
            //ServerMem = (int)new ComputerInfo().TotalPhysicalMemory;
           // ServerMem = (int) Convert.ChangeType(new ServerComputer().Info.AvailableVirtualMemory,typeof(int));`
            
            Session["OSMem"] = OSMem;
            Session["PFSize"] = PFSize;
            Session["ServerMem"] = ServerMem;
            int PFTotal = (ServerMem - OSMem) / PFSize;
            for (int i = 0; i <= PFTotal; i++)
            {
                string value = Convert.ToString(Rand.Next(0000, 9999));
                if (!PageFrames.Contains(value))
                    PageFrames.Add(value);
                else i--;
            }
            for (int i = 0; i <= 10; i++)
            {
                string value = Convert.ToString(Rand.Next(0000, 9999));
                if (!TLB.Contains(value))
                    TLB.Add(value);
                else i--;
            }
            for (int i = 0; i <= 30; i++)
            {
                string value = Convert.ToString(Rand.Next(0000, 9999));
                if (!HDD.Contains(value))
                    HDD.Add(value);
                else i--;
            }
            Session["TLBAL"] = TLB;
            Session["PFAL"] = PageFrames;
            Session["HDDAL"] = HDD;
        }

    }
}