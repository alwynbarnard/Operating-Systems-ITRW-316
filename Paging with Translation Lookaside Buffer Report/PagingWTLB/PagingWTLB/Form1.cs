/*
        ALWYN BARNARD 28430093
        ITRW 316 2019
        Mr Henry Foulds - Operating Systems
        Paging With TLB Practical
        Assignment 3
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PagingWTLB
{
    public partial class Form1 : Form
    {
        ArrayList Tlb = new ArrayList(); //TLB Values
        ArrayList TlbAges = new ArrayList(); // TLB Ages
        ArrayList Pagetable = new ArrayList();  //Page Table Values

        ArrayList Breakdown = new ArrayList(); //Element breakdown for local page replacement algorithm
        string policy = "G"; //Replacement Policy. Local vs Global
        int Max = 0;
        int MaxNommer;
        public Form1()
        {
            InitializeComponent();
            Tlb.AddRange(lbxTLB.Items);
            TlbAges.AddRange(lbAges.Items);
            TlbAges.RemoveAt(TlbAges.Count - 1);
            Pagetable.AddRange(lbxPT.Items);
            policy = "G";
        }

        private void btnFIFO_Click(object sender, EventArgs e)
        {
            string Waarde = txtRequest.Text;
            bool Found = false;
            // PolicyExecution();
            // if (policy == "G")
            // {
            for (int i = 0; i < Tlb.Count; i++)
            {
                if (Waarde == Tlb[i].ToString())
                {
                    MessageBox.Show("Found in TLB");
                    Found = true;
                    goto WasFound;
                }
            }

            if (Found == false) //Wasnt found in TLD; Search for in PT
            {
                for (int i = 0; i < Pagetable.Count; i++)
                {
                    if (Waarde == Pagetable[i].ToString())
                    {
                        MessageBox.Show("Found in Pagetable");
                        Found = false;
                        break;
                    }
                }
            }
            if (Found == false)
            {
                Replacement(Waarde, 0, Tlb.Count);
                lbxTLB.Items.Clear();
                lbAges.Items.Clear();
                for (int i = 0; i < Tlb.Count; i++)
                {
                    lbxTLB.Items.Add(Tlb[i].ToString());
                    lbAges.Items.Add(TlbAges[i].ToString());
                }
                lbAges.Items.Add("(Ages)");
                lbxPT.Items.Clear();
                for (int i = 0; i < Pagetable.Count; i++)
                {
                    lbxPT.Items.Add(Pagetable[i].ToString());
                }
            }
        WasFound: int k = 0;


        
        //else if (policy == "L")
        //{
        //    LocalExecution(Waarde, Waarde);
        //}

    
}
    

        public void Replacement(string waarde,int start, int stop)
        {
            Max = 0;
            MaxNommer = 0;
           for (int i=start;i<stop;i++)
           {
                if (Max < Convert.ToInt16(TlbAges[i]))
                {
                    Max = Convert.ToInt16(TlbAges[i]);
                    MaxNommer = i;
                }
           }
           Tlb.RemoveAt(MaxNommer);
           TlbAges.RemoveAt(MaxNommer);
           Tlb.Insert(MaxNommer, waarde);
           TlbAges.Insert(MaxNommer, 1);
           Pagetable.Remove(waarde);
        }


        private void cbLocal_Click(object sender, EventArgs e)
        {
            policy = "L";
        }

        private void cbGlobal_CheckedChanged(object sender, EventArgs e)
        {
            policy = "G";
        }

        private void cbGlobal_Click(object sender, EventArgs e)
        {
            policy = "G";
        }

        private void cbLocal_CheckedChanged(object sender, EventArgs e)
        {
            policy = "L";
        }

        public void PolicyExecution()
        {
            string EersteLetter = Tlb[0].ToString().Substring(0, 1);
            
            Breakdown.Add(EersteLetter);
            Breakdown.Add(0);
            for (int i=0;i<Tlb.Count;i++)
            {
                if (EersteLetter != Tlb[i].ToString().Substring(0, 1))
                {
                    Breakdown.Add(i - 1);
                    EersteLetter = Tlb[i].ToString().Substring(0, 1);
                    Breakdown.Add(EersteLetter);
                    Breakdown.Add(i+1);
                }
            }
            Breakdown.Add(Tlb.Count - 1);

            //for (int i=0;i<Breakdown.Count;i++)
            //{
            //    textBox1.Text += " " + Breakdown[i].ToString();
            //}
        }
        public void LocalExecution(string LetterWaarde,string waarde2)
        {
            for (int i=0;i<Tlb.Count;i++)
            {
                if (LetterWaarde.Substring(0,1) == Breakdown[i].ToString())
                {
                    Replacement(waarde2, Convert.ToInt16(Breakdown[i + 1]), Convert.ToInt16(Breakdown[i + 2]));
                }
            }
        }
    }
}
