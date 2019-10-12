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
        ArrayList Pagetable = new ArrayList();  //Page Table Values
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            Pagetable.AddRange(lbxPT.Items);

        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            string soek = txtRequest.Text;
            bool soektog = false;
            for (int i=0;i<Pagetable.Count;i++)
            {
                if (Pagetable[i].ToString() == soek)
                {
                    soektog = true;
                    label4.Text = "Found";
                    break;
                }
            }
            if (soektog == false)
            {
                Pagetable[rand.Next(0,Pagetable.Count+1)] = soek;
                label4.Text = "Replaced";
            }
            lbxPT.Items.Clear();
            for (int i=0;i<Pagetable.Count;i++)
            {
                lbxPT.Items.Add(Pagetable[i].ToString());
            }
            txtRequest.Clear();

        }
    }
}
