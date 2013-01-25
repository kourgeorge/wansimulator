using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using Echevil;
using ZedGraph;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;

namespace NetEmulator
{
  public partial class NetMon : Form
  {
    public delegate void EventHandler(long pt);
    public EventHandler UpdateEvent;
    private NetMonLogger log;

    public NetMon()
    {
      InitializeComponent();
      UpdateEvent = new EventHandler(UpdateUI);
      log = new NetMonLogger();
      SaveLogsToolTip.SetToolTip(this.NetmonSaveLogCB, @"The log are saved by default to C:\Wansim\NetmonLog<Time>.html");

    }

    private void Monitor_Click(object sender, EventArgs e)
    {

      if (NetMontimer.Enabled == false)
      {
        NetMontimer.Enabled = true;
        log.InitializeLogFile(NetmonSaveLogCB.Checked);
        Monitor.Text = "Stop";
        Host.Enabled = false;
        new Thread(PingHost).Start();
        PingTime.Text = "Pinging ...";
        log.AddEventToLog(1,"Pinging "+ Host.Text);
        PingTime.ForeColor = Color.Black;
        PingGraph.Value = 0;
        mstoolStrip.Visible = false;
        plotter.Clear();
      }

      else
      {
        NetMontimer.Enabled = false;
        SaveGraphBtn.Enabled = true;
        Monitor.Text = "Monitor";
        Host.Enabled = true;
        PingGraph.Value = 0;
        PingTime.Text = "Ready";
        PingTime.ForeColor = Color.Black;
        mstoolStrip.Visible = false;
        log.CloseStream();
      }
    }

    private void NetMontimer_Tick(object sender, EventArgs e)
    {
      new Thread(PingHost).Start();
    }

    public void PingHost()
    {
      try
      {
        Ping ping = new Ping();

        //Ping host (this will block until complete)

        PingReply response = ping.Send(Host.Text);

        //Process ping response

        if (response != null)
        {
          //RTT = response.RoundtripTime;
          if (response.Status == IPStatus.Success)
          {
            UpdateEvent(response.RoundtripTime);
            log.AddEventToLog(1, "Ping Completed Succesfully. Ping Response Time: " + response.RoundtripTime.ToString());
          }
          else
          {
            if (NetMontimer.Enabled == true) //update the UI to unreachable only if the monitor is running
            {
              UpdateEvent(int.MaxValue); //int.MaxValue simbols unreachable (timeout/wrong host)
              log.AddEventToLog(2, "Host Unreachable ");
            }
          }
        }

      }
      catch (Exception exp)
      {
        //MessageBox.Show(exp.Message);
        if (NetMontimer.Enabled == true) //update the UI to unreachable only if the monitor is running
          UpdateEvent(int.MaxValue);
      }
    }

    public void UpdateUI(long pingtime)
    {

      if (PingGraph.Control.InvokeRequired)
      {
        // this is worker thread
        EventHandler del = new EventHandler(UpdateUI);
        PingGraph.Control.Invoke(del, new object[] { pingtime });
      }
      else
      {
        // this is UI thread
        if (NetMontimer.Enabled == true) //only if the netmon is running
        {
          if (pingtime == int.MaxValue) //if Unreachable
          {
            PingTime.Text = "Unreachable";
            PingTime.ForeColor = Color.Red;
            mstoolStrip.Visible = false;
          }
          else
          {
            PingTime.ForeColor = Color.Black;
            mstoolStrip.Visible = true;
            if (pingtime < 1) PingTime.Text = "<1";
            else
              PingTime.Text = pingtime.ToString();

            if ((int)pingtime > 900)
              PingGraph.Value = 900;
            else
            {
              PingGraph.Value = (int)pingtime;
            }
            plotter.Add((int)pingtime + 10); // the 10 is to be able to see time 0 in the graph.

          }
        }

      }
    }
    public static bool UrlIsValid(string smtpHost)
    {
      bool br = false;
      try
      {
        IPHostEntry ipHost = Dns.Resolve(smtpHost);
        br = true;
      }
      catch (SocketException se)
      {
        br = false;
      }
      return br;
    }
    private void NetMon_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (NetMontimer.Enabled == true)
      {
        NetMontimer.Enabled = false;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      plotter.Clear();
    }

    private void SaveGraphBtn_Click(object sender, EventArgs e)
    {
      CreateGraph(plotter.GetBuffer());
    }

    private void CreateGraph(float[] buf)
    {

      PointPairList list = new PointPairList();
      for (int x = 0; x < buf.Length; x++)
      {
        double y = buf[x];

        list.Add(x, y);
      }

      ZedGraphControl zgc = new ZedGraphControl();
      zgc.Hide();
      zgc.Size = new Size(1000, 500);
      
      GraphPane myPane = zgc.GraphPane;
      myPane.XAxis.Title.Text = "PIng index";
      myPane.YAxis.Title.Text = "RoundTrip [ms]";
      myPane.Title.Text = "HP Softtware R&D - WanSim";

      // Generate a blue curve with circle symbols, and "My Curve 2" in the legend
      LineItem myCurve = myPane.AddCurve("Ping to: "+Host.Text, list, Color.White, SymbolType.TriangleDown);
      myCurve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
      // Fill the axis background with a color gradient
      myPane.Chart.Fill = new Fill(Color.Black, Color.Blue, 45F);
      zgc.AxisChange();
      zgc.SaveAsBitmap();
    }
  }
}
