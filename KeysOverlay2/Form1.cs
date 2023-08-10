using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeysOverlay2
{
    public partial class Form1 : Form
    {
               
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        GlobalKeyboardHook gkh = new GlobalKeyboardHook();
        private PanelList lst = new PanelList();





        //public LinkedList<Panel_link> buttonmap = new LinkedList<Panel_link>();
        private Keys[] default_keys = 
        {   
            Keys.W, Keys.A, Keys.S, Keys.D, 
            Keys.Y, Keys.H, Keys.U, Keys.J, Keys.I, 
            Keys.K, Keys.O, Keys.L, Keys.V, 
            Keys.B, Keys.N,
            Keys.NumPad4,Keys.NumPad5,Keys.NumPad6,
            Keys.NumPad7,Keys.NumPad8,Keys.NumPad9,
            Keys.Add, Keys.Subtract 
        };
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Panel_link blink = new Panel_link();
            //link(panel1, Keys.W);
            label1.Visible = false;
            
            notifyIcon1.Visible = true;

            object zz = Controls;
            
            gkh.HookedKeys.AddRange(default_keys);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyU);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyD);

            
            
        }

        private void gkh_KeyU(object sender, KeyEventArgs e)
        {
            //label1.Text = "Отпустили " + e.KeyCode.ToString();
            int state = 0;
            Panels_switch(e.KeyData, state);
            label1.Text = e.KeyData.ToString();


        }
        
        private void Panels_switch(Keys key, int state)
        {
            switch (key)
            {
                case Keys.A:
                    PanelColorSwitch(4, state);
                    break;
                case Keys.W:
                    PanelColorSwitch(2, state);
                    break;
                case Keys.S:
                    PanelColorSwitch(8, state);
                    break;
                case Keys.D:
                    PanelColorSwitch(6, state);
                    break;
                case Keys.Y:
                    PanelColorSwitch(12, state);
                    break;
                case Keys.Add:
                    PanelColorSwitch(12, state);
                    break;
                case Keys.U:
                    PanelColorSwitch(13, state);
                    break;
                case Keys.NumPad7:
                    PanelColorSwitch(13, state);
                    break;
                case Keys.I:
                    PanelColorSwitch(14, state);
                    break;
                case Keys.NumPad8:
                    PanelColorSwitch(14, state);
                    break;
                case Keys.O:
                    PanelColorSwitch(15, state);
                    break;
                case Keys.NumPad9:
                    PanelColorSwitch(15, state);
                    break;
                case Keys.H:
                    PanelColorSwitch(17, state);
                    break;
                case Keys.Subtract:
                    PanelColorSwitch(17, state);
                    break;
                case Keys.J:
                    PanelColorSwitch(18, state);
                    break;
                case Keys.NumPad4:
                    PanelColorSwitch(18, state);
                    break;
                case Keys.K:
                    PanelColorSwitch(19, state);
                    break;
                case Keys.NumPad5:
                    PanelColorSwitch(19, state);
                    break;
                case Keys.L:
                    PanelColorSwitch(20, state);
                    break;
                case Keys.NumPad6:
                    PanelColorSwitch(20, state);
                    break;
            }
        }

        private void gkh_KeyD(object sender, KeyEventArgs e)
        {
            int state = 1;
            //label1.Text = "Нажали " + e.KeyCode.ToString();
            Panels_switch(e.KeyData, state);
        }


        public void PanelColorSwitch(int panel, int state)
        {
            Color cl1 = Color.DodgerBlue, cl2 = Color.Black;
            switch (panel)
            {
                case 2:
                    if (state == 0) { p2.BackColor = cl1; }
                    else { p2.BackColor = cl2; }
                    break;
                
                case 4:
                    if (state == 0) { p1.BackColor = cl1; }
                    else { p1.BackColor = cl2; }
                    break;
                
                case 6:
                    if (state == 0) { p4.BackColor = cl1; }
                    else { p4.BackColor = cl2; }
                    break;
                
                case 8:
                    if (state == 0) { p3.BackColor = cl1; }
                    else { p3.BackColor = cl2; }
                    break;
                
                case 11:
                    if (state == 0) { panel11.BackColor = cl1; }
                    else { panel11.BackColor = cl2; }
                    break;
                case 12:
                    if (state == 0) { panel12.BackColor = cl1; }
                    else { panel12.BackColor = cl2; }
                    break;
                case 13:
                    if (state == 0) { panel13.BackColor = cl1; }
                    else { panel13.BackColor = cl2; }
                    break;
                case 14:
                    if (state == 0) { panel14.BackColor = cl1; }
                    else { panel14.BackColor = cl2; }
                    break;
                case 15:
                    if (state == 0) { panel15.BackColor = cl1; }
                    else { panel15.BackColor = cl2; }
                    break;
                case 16:
                    if (state == 0) { panel16.BackColor = cl1; }
                    else { panel16.BackColor = cl2; }
                    break;
                case 17:
                    if (state == 0) { panel17.BackColor = cl1; }
                    else { panel17.BackColor = cl2; }
                    break;
                case 18:
                    if (state == 0) { panel18.BackColor = cl1; }
                    else { panel18.BackColor = cl2; }
                    break;
                case 19:
                    if (state == 0) { panel19.BackColor = cl1; }
                    else { panel19.BackColor = cl2; }
                    break;
                case 20:
                    if (state == 0) { panel20.BackColor = cl1; }
                    else { panel20.BackColor = cl2; }
                    break;

            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
            tableLayoutPanel1.BackColor = Color.Magenta;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.TopMost = false;
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyData.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false; 
        }
    }


    class PanelList
    {
        List<Panel_link> pan_lnk = new List<Panel_link>();
        class Panel_link
        {
            public Panel pan;
            public Keys button;
            public Panel_link(Panel aa, Keys bb)
            {
                pan = aa;
                button = bb;
            }

            public void Clear()
            {
                pan = null;
                button = Keys.None;

            }


        }


        public void Add(Panel a, Keys b)
        {
            Panel_link zzz = new Panel_link(a, b);
            pan_lnk.Add(zzz);
        }

        public Object Find(Panel a)
        {
            return pan_lnk.Find(ff => ff.pan == a);
        }
        public Object FindAll(Panel a)
        {
            return pan_lnk.FindAll(ff => ff.pan == a);
        }


        public int FindIndex(Panel a)
        {
            return pan_lnk.FindIndex(ff => ff.pan == a);
        }





    }






}
