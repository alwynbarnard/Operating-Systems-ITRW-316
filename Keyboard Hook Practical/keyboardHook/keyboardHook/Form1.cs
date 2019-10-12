/*
        ALWYN BARNARD 
        28430093
        Keyboard Hook Program 
        2019 - ITRW 316
        Hook starts at press of Shift+C
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
using System.IO;

namespace keyboardHook
{
    public partial class Form1 : Form
    {
        ArrayList ElKeys = new ArrayList(); //ElKeys because Keys was reserved
        bool start = false;
        int count=0;
       
       // StreamReader reader = new StreamReader(str);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (start == true)
            {
                ElKeys.Add(e.KeyCode.ToString());
                count++;
            }
            if (e.Shift & e.KeyCode.ToString() == "C")
            {
                

                //Toggle true and false
                if (start == true) start = false;
                else if (start == false) start = true;   
            }
            if ((e.Shift & e.KeyCode.ToString() == "C") && (start==false))
            {
                StartListening();
            }
            
        }
        public void StartListening()
        {
            using (Stream str = new FileStream(@"C:\Users\ALWYN\Downloads\Nodig vir 316_Presentations\KeyBoardHook Program\keys.txt", FileMode.Append, FileAccess.Write))
            {
                // Declare a StreamWriter object that can be used to write text data to the file
                using (StreamWriter writer = new StreamWriter(str))
                {
                    // Write a line of text to the file
                    for (int i = 0; i < count; i++)
                    {
                        writer.WriteLine(ElKeys[i].ToString());
                    }
                    
                }
            }
        }  
    }
}
