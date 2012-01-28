﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PData.data;
using PService;
using PService.tests;

namespace PMonitor.views
{
    public partial class FScan : Form
    {
        private PMonitor.fMain fm;


        public FScan(fMain fMain)
        {
            InitializeComponent();


            this.fm = fMain;
        }

        private void scan()
        {
            String[] ipStart = tbStart.Text.Split(new Char[] { '.' });
            String[] ipStop = tbStop.Text.Split(new Char[] { '.' });



            for (int i1 = Convert.ToInt32(ipStart[0]); i1 <= Convert.ToInt32(ipStop[0]); i1++)
            {
                for (int i2 = Convert.ToInt32(ipStart[1]); i2 <= Convert.ToInt32(ipStop[1]); i2++)
                {
                    for (int i3 = Convert.ToInt32(ipStart[2]); i3 <= Convert.ToInt32(ipStop[2]); i3++)
                    {
                        for (int i4 = Convert.ToInt32(ipStart[3]); i4 <= Convert.ToInt32(ipStop[3]); i4++)
                        {
                            String ip = i1 + "." + i2 + "." + i3 + "." + i4;
                            String hostname = "-";
                            TPing ping = new TPing(ip, 3);

                            PResult result = ping.getTest();

                            if (result.errCode == 0)
                            {
                                try
                                {
                                    hostname = Dns.GetHostEntry(ip).HostName;
                                }
                                catch (Exception e12)
                                {
                                    hostname = String.Empty;
                                }

                                Hardware h = new Hardware();
                                h.ip = ip;
                                h.hostname = hostname;
                                ;
                                //MessageBox.Show("" + fm.mset1.hardwares.Where(hhh => ip.Equals(hhh.ip_address)).Count());
                                if (fm.mset1.hardwares.Where(hhh => ip.Equals(hhh.ip_address)).Count() == 0)
                                {
                                    this.Invoke(new MethodInvoker(
                                                    delegate {
                                                                 this.cbFind.Items.Add(h);
                                                    }
                                                    ));
                                    AddToListBox(ip + "  добавлен");
                                }
                           
                                else
                                {
                                    AddToListBox(ip + "  уже существует");
                                }
                 
                                
                            }
                            else
                            {
                                AddToListBox(ip + " недоступен");
                            }

                           
                            //Thread.CurrentThread.Interrupt();
                        }
                    }
                }
            }
        }


        private void AddToListBox(object oo)
        {
            try
            {
                this.Invoke(new MethodInvoker(
                                delegate { this.lbLog.Items.Insert(0, oo); }
                                ));
            }catch( Exception e)
            {
            }
        }

        private void bScan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tbStart.Text + "--" + tbStop.Text);
            lbLog.Items.Clear();
            cbFind.Items.Clear();
            ;


            new Thread(scan).Start();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // lbLog.Items.Clear();

            foreach (Hardware hh in cbFind.CheckedItems)
            {
                lbLog.Items.Add(hh);
                    

                monitorDataSet.hardwaresRow row = fm.mset1.hardwares.NewhardwaresRow();
                row.description = "scan";
                row.dns_name = hh.hostname;
                row.ip_address = hh.ip;
                row.is_snmp = false;
                try
                {
                    fm.mset1.hardwares.Rows.Add(row);
                    fm.tableAdapterManager.UpdateAll(fm.mset1);


                    PMonitor.monitorDataSetTableAdapters.hardwaresTableAdapter hardwaresTableAdapter = new PMonitor.monitorDataSetTableAdapters.hardwaresTableAdapter();
                    hardwaresTableAdapter.Insert(hh.hostname, false, hh.ip , "scan", 1);


                    lbLog.Items.Add("Added");
                }catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }

            }
                
            
        }






    }


   

}
