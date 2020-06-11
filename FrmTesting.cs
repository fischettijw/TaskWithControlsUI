using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            Task.WaitAll(t2);

            Txt03.Text = "Downstream";
        }
    }






}
