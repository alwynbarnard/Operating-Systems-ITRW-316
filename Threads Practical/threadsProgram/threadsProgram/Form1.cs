/*
        ALWYN BARNARD  28430093
        SCHEDULING REPORT 
        Mr Henry Foulds
        ITRW 316 Operating Systems 2019
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace threadsProgram
{
    public partial class Form1 : Form
    {
        //Output form declaration
        


        //Number of all the treads
        int AllThreadCounter = 0;

        //Priority Scheduling ArrayLists
        ArrayList Priority1;
        ArrayList Priority2;
        ArrayList Priority3;
        ArrayList Priority4;
        ArrayList Priority5;

        //ArrayLists for Round Robin Scheduling
        ArrayList Elemente = new ArrayList();
        ArrayList Breakdown = new ArrayList();
        ArrayList one = new ArrayList();

        //Round Robin
        int amount;
        int Sum;
        public Form1()
        {
            InitializeComponent();
            //Create the ArrayLists
            Priority1 = new ArrayList();
            Priority2 = new ArrayList();
            Priority3 = new ArrayList();
            Priority4 = new ArrayList();
            Priority5 = new ArrayList();
        }

        public void PriorityScheduling()
        {
            Output ShowMe = new Output();
            string OutputString = "";
            
            string threadName = txtPName.Text;
            int threadCount = Convert.ToInt16(txtPCount.Text);
            int priority = Convert.ToInt16(txtPPriority.Text);
            if ((priority != 1) && (priority != 2) && (priority != 3) && (priority != 4) && (priority != 5))  //Test validity of the entered priority
            {
                MessageBox.Show("Invalid priority. Restart and re-enter the correct thread priority");
                Application.Exit();
            }

            // Add thread
            if (AllThreadCounter == 0)
            {
                AddQueues(threadCount, priority, threadName);
                AddQueues(Convert.ToInt16(txtPTCount2.Text), Convert.ToInt16(txtPPriority2.Text), txtPPName2.Text);
                AllThreadCounter = 2;
            }
            else
            {
                AddQueues(threadCount, priority, threadName);
                AllThreadCounter++;
            }
            

            //Execute threads in order of priority
            for (int b = 0; b < Priority1.Count; b++)
            {
                OutputString += Priority1[b] + ", ";
            }
            for (int b = 0; b < Priority2.Count; b++)
            {
                OutputString += Priority2[b] + ", ";
            }
            for (int b = 0; b < Priority3.Count; b++)
            {
                OutputString += Priority3[b] + ", ";
            }
            for (int b = 0; b < Priority4.Count; b++)
            {
                OutputString += Priority4[b] + ", ";
            }
            for (int b = 0; b < Priority5.Count; b++)
            {
                OutputString += Priority5[b] + ", ";
            }

            //SHOW OUTPUT
            ShowMe.OutResult(OutputString);
            ShowMe.Show();
            txtPName.Text = "";
            txtPCount.Text = "";
            txtPPriority.Text = "";
            txtPTCount2.Text = "";
            txtPPriority2.Text = "";
            txtPPName2.Text = "";
        }

        public void AddQueues(int threadCount, int priority, string threadName)
        {
            switch (priority)
            {
                case 1:
                    for (int a = 1; a <= threadCount; a++)
                    {
                        Priority1.Add(threadName + Convert.ToString(a));
                    }
                    break;
                case 2:
                    for (int a = 1; a <= threadCount; a++)
                    {
                        Priority2.Add(threadName + Convert.ToString(a));
                    }
                    break;
                case 3:
                    for (int a = 1; a <= threadCount; a++)
                    {
                        Priority3.Add(threadName + Convert.ToString(a));
                    }
                    break;
                case 4:
                    for (int a = 1; a <= threadCount; a++)
                    {
                        Priority4.Add(threadName + Convert.ToString(a));
                    }
                    break;
                default:
                    for (int a = 1; a <= threadCount; a++)
                    {
                        Priority5.Add(threadName + Convert.ToString(a));
                    }
                    break;

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PriorityScheduling();

        }
        
        
        public void MultipleQueues()
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PriorityScheduling();
        }

        private void BtnRRStart_Click(object sender, EventArgs e)
        {
            
           
            int[] BurstTime = new int[amount];
            int[] WaitTime = new int[amount];
            int[] TurnAroundTime = new int[amount];
            int[] OriginalTimes = new int[amount];
            
            for (int i = 0; i < amount; i++)
            {
                label11.Text = "Enter Burst Time for Process " + Convert.ToString(i);

                BurstTime[i] = Convert.ToInt16(txtRCount.Text);
            }
            int Quantum = Convert.ToInt16(MessageBox.Show("Enter the Quantum Time: "));
            for (int i = 0; i < amount; i++)
            {
                OriginalTimes[i] = BurstTime[i];
            }
            for (int i = 0; i < amount; i++)
            {
                WaitTime[i] = 0;
            }

            do
            {
                for (int i = 0; i < amount; i++)
                {
                    if (BurstTime[i] > Quantum)
                    {
                        BurstTime[i] = BurstTime[i] - Quantum;
                        for (int j = 0; j < amount; j++)
                        {
                            if ((j != i) && (BurstTime[j] != 0))
                            {
                                WaitTime[j] = WaitTime[j] + Quantum;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < amount; j++)
                        {
                            if ((j != i) && (BurstTime[j] != 0))
                            {
                                WaitTime[j] = WaitTime[j] + BurstTime[i];
                            }
                            BurstTime[i] = 0;
                        }
                    }
                    Sum = 0;
                    for (int k = 0; k < amount; k++)
                    {
                        Sum = Sum + BurstTime[k];
                    }
                }

            }
            while (Sum != 0);
            for (int i=0;i<amount;i++)
            {
                TurnAroundTime[i] = WaitTime[i] + OriginalTimes[i];
            }
            Output ShowMe = new Output();
            ShowMe.OutResult("Process\t\tBurst Time\tWaiting Time\tTurn Arount Time\n");
            for(int i=0;i<amount;i++)
            {
                ShowMe.OutResult("  p" + Convert.ToString((i + 1)) + "\t\t    " + Convert.ToString(OriginalTimes[i]) + "\t\t    " + Convert.ToString(WaitTime[i]) + "\t\t    " + TurnAroundTime[i]);
            }
            ShowMe.OutResult("\n");

            Double AverageWaitTime = 0;
            Double AverageTurnAroundT = 0;
            for (int j=0;j<amount;j++)
            {
                AverageWaitTime = AverageWaitTime + WaitTime[j];
                AverageTurnAroundT = AverageTurnAroundT + TurnAroundTime[j];
            }
            ShowMe.OutResult("Average Wait Time : " + Convert.ToString(AverageWaitTime / amount)+"\nAverage Turn Around Time: " + Convert.ToString(AverageTurnAroundT/amount));


            //// var elemente = new List<string>();
            //string threadName1 = txtRName.Text;
            //string threadName2 = txtRName2.Text;
            //int threadCount1 = Convert.ToInt16(txtRCount.Text);
            //int threadCount2 = Convert.ToInt16(txtRCount2.Text);
            //AddElemente(threadName1, threadCount1);
            //AddElemente(threadName2, threadCount2);

            //Output ShowMe = new Output();
            //string OutputString = "";
            //for (int i = 0; i < Elemente.Count; i++)
            //{
            //    textBox1.Text += Elemente[i].ToString();
            //}
            //// RoundRobin();


        }

        public void AddElemente(string threadN, int threadC)
        {
            int afwyking = 0;
            string StringLyn = "";
            for (int i = 1; i <= threadC + afwyking; i++)
            {
                one.Add(threadN + Convert.ToString(i));
                if ((i % 5) == 0)
                {
                    //Elemente.Add("+");
                    //afwyking++;
                    for (int j = 0; j < 5; j++)
                    {
                        StringLyn += one[i].ToString() + " ";
                    }
                    Elemente.Add(StringLyn);
                }
            }
            //Elemente.Add("#");
            //Breakdown.Add(threadN);
        }
        public void RoundRobin()
        {
            string OutputString = "";

            //Doen dit weer

            for (int i = 0; i <= Elemente.Count; i++)
            {
                if (Convert.ToInt16(Elemente.IndexOf("+")) == 5)
                {
                    OutputString += Elemente.GetRange(0, Elemente.IndexOf("+"));
                    Elemente.RemoveRange(0, Elemente.IndexOf("+"));
                    Elemente.TrimToSize();
                }
                else
                {
                    OutputString += Elemente.GetRange(0, Elemente.IndexOf("+"));
                    Elemente.RemoveRange(0, Elemente.IndexOf("+"));
                    Elemente.TrimToSize();
                }
                if (Elemente.Count != 0)
                {
                    one.Clear();
                    one.AddRange(Elemente.GetRange(0, Elemente.IndexOf("#")));
                    Elemente.RemoveRange(0, Elemente.IndexOf("#"));
                    Elemente.AddRange(one.GetRange(0, one.Count));
                    Elemente.TrimToSize();
                }
            }











        }

        private void BnStart_Click(object sender, EventArgs e)
        {
            amount = Convert.ToInt16(MessageBox.Show("Enter the number of processes you want to schedule"));
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Hide();
            textBox2.Hide();
        }

        private void BtnRRAdd_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            label1.Show();
            textBox2.Show();
            label1.Text = "Enter number of Processes ";
            amount = Convert.ToInt16(textBox2.Text);
        }
    }

}
    
