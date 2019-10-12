using System;
using System.Collections;

namespace ExamProject3
{
    public partial class Paging : System.Web.UI.Page
    {
        int OSMemory;
        int PFSizes;
        int ServerMemory;
        Random Rand = new Random();
        int PFTotal;
        ArrayList PageFrames = new ArrayList();
        ArrayList HDD = new ArrayList();
        ArrayList TLB = new ArrayList();
        bool Loaded = false;
        string Waarde = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            Waarde = txtSearch.Text;
        }

        public void LoadPageTable()
        {
            lbxPageTable.Items.Clear();
            for (int i = 0; i < PFTotal; i++)
            {
                lbxPageTable.Items.Add(Convert.ToString(PageFrames[i]));
            }
        }

        public void RandomPageReplacement()
        {
            bool found = false;
            for (int i = 0; i < TLB.Count; i++)
            {
                if (TLB[i].ToString() == Waarde)
                {
                    found = true;
                    Response.Write(" " + Waarde + "Found in TLB");
                }
            }
            if (found == false)
            {
                for (int i = 0; i < PageFrames.Count; i++)
                {
                    if (Waarde == PageFrames[i].ToString())
                    {
                        found = true;
                        Replacement((Waarde), TLB, 0, TLB.Count);
                        Response.Write(" " + Waarde + "Found in Page Table");
                    }
                }
            }
            if (found == false)
            {
                for (int i = 0; i < HDD.Count; i++)
                {
                    if (Waarde == HDD[i].ToString())
                    {
                        found = true;
                        Replacement((Waarde), PageFrames, 0, PageFrames.Count);
                        Replacement((Waarde), TLB, 0, TLB.Count);
                        Response.Write(" " + Waarde + "Found in RAM");
                    }
                }
            }
            if (found == false)
            {
               // Response.Write(" " + Waarde + " was not found in the TLB, Page Table or RAM");
            }
           // LoadPageTable();
           // LoadTLB();
           // LoadHDD();
        }


        public void Replacement(string NewValue, ArrayList arrayList, int Start, int Stop)
        {
            arrayList[Rand.Next(Start, Stop)] = NewValue;
            LoadTLB();
            LoadPageTable();
            LoadHDD();

        }
        public void LoadHDD()
        {
            lbxHDD.Items.Clear();
            for (int i = 0; i < HDD.Count; i++)
            {
                lbxHDD.Items.Add(Convert.ToString(HDD[i]));
            }
        }

        public void LoadTLB()
        {
            lbxTLB.Items.Clear();
            for (int i = 0; i < TLB.Count; i++)
            {
                lbxTLB.Items.Add(Convert.ToString(TLB[i]));
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Waarde = txtSearch.Text;
            RandomPageReplacement();
        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            OSMemory = (int)Session["OSMem"];
            PFSizes = (int)Session["PFSize"];
            ServerMemory = (int)Session["ServerMem"];
            //Response.Write("ServerMemory = " + ServerMemory);
            PFTotal = (ServerMemory - OSMemory) / PFSizes;

            //if (Loaded == false)
            //{
            //    for (int i = 0; i <= PFTotal; i++)
            //    {
            //        string value = Convert.ToString(Rand.Next(0000, 9999));
            //        if (!PageFrames.Contains(value))
            //            PageFrames.Add(value);
            //        else i--;
            //    }
            //    for (int i = 0; i <= 10; i++)
            //    {
            //        string value = Convert.ToString(Rand.Next(0000, 9999));
            //        if (!TLB.Contains(value))
            //            TLB.Add(value);
            //        else i--;
            //    }
            //    for (int i = 0; i <= 30; i++)
            //    {
            //        string value = Convert.ToString(Rand.Next(0000, 9999));
            //        if (!HDD.Contains(value))
            //            HDD.Add(value);
            //        else i--;
            //    }
            //    Loaded = true;
            //}
            TLB = (ArrayList)Session["TLBAL"];
            PageFrames = (ArrayList)Session["PFAL"];
            HDD = (ArrayList)Session["HDDAL"];
            LoadPageTable();
            LoadTLB();
            LoadHDD();
            Response.Write("Entry 1" + TLB[0].ToString()+"Entry 2 "+TLB[1].ToString()+"TextBox "+Waarde);
        }
    }
}