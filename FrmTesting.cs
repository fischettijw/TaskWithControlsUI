using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskWithControlsUI
{
    public partial class FrmTesting : Form
    {
        public FrmTesting()
        {
            InitializeComponent();
        }

        private void FrmTesting_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            LbxOutput.BackColor = Color.White;
            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    LbxOutput.Items.Add($"T1: {i}");
                    LbxOutput.TopIndex = LbxOutput.Items.Count - 1;
                    Thread.Sleep(100);
                }
                Txt01.Text = "1-Complete";
            });

            Task t2 = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    LbxOutput.Items.Add($"T2: {i}");
                    LbxOutput.TopIndex = LbxOutput.Items.Count - 1;
                    Thread.Sleep(50);
                }
                Txt02.Text = "2-Complete";
            });

            Task<string> t3 = new Task<string>(() =>
            {
                string strReturn = "Downstream";
                return strReturn;
            });
            t3.Start();


            Task.WaitAll(t2);

            Txt03.Text = t3.Result;

            Task t4 = Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Txt04.Text = i.ToString();
                    Thread.Sleep(100);
                }
            });
            Task.WaitAll();
            LbxOutput.BackColor = Color.LightBlue;
        }
    }






}
