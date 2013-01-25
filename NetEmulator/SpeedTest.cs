using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using ZedGraph;


namespace NetEmulator
{
  public partial class SpeedTest : Form
  {
    public EventHandler UpdateEvent;
    private long timer = 0;
    private double BW;
    private string DownloadedFileName;
    private List<double> BandWidthSamples = new List<double>();
    private WebClient webClient = new WebClient();
    
    public SpeedTest()
    {
      InitializeComponent();
      
    }

    private void SaveGraphBtn_Click(object sender, EventArgs e)
    {
      CreateGraph(BandWidthSamples.ToArray());
    }

    private void CreateGraph(double[] buf)
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
      myPane.XAxis.Title.Text = "Time";
      myPane.YAxis.Title.Text = "Speed [Mbps]";
      myPane.Title.Text = "HP Softtware R&D - WanSim";

      // Generate a blue curve with circle symbols, and "My Curve 2" in the legend
      LineItem myCurve = myPane.AddCurve("Speed Test to: http://www.thinkbroadband.com", list, Color.White, SymbolType.TriangleDown);
      myCurve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
      // Fill the axis background with a color gradient
      myPane.Chart.Fill = new Fill(Color.Black, Color.Blue, 45F);
      zgc.AxisChange();
      zgc.SaveAsBitmap();
    }

    private void TestsBtn_Click(object sender, EventArgs e)
    {
      CalculateNetworkSpeed();
      UpdateUITimer.Start();
      TestBtn.Enabled = false;
      SaveGraphBtn.Enabled = false;
    }
    
    private void CalculateNetworkSpeed()
    {
      webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
      webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
      DownloadedFileName = @"C:\Wansim\TestDownloadFile.txt";
      DownloadedFileName = DownloadedFileName.Insert(DownloadedFileName.IndexOf("."), "__D" + DateTime.Now.ToLongDateString().Replace(" ", "_")+ "__T" + DateTime.Now.ToLongTimeString().Replace(":", "_"));
      webClient.DownloadFileAsync(new Uri("http://download.thinkbroadband.com/50MB.zip"), DownloadedFileName);
      timer = DateTime.Now.TimeOfDay.Ticks;
      StatusLabel.Text = "Running Speed Test";
    }

    private void Completed(object sender, AsyncCompletedEventArgs e)
    {
      double sum = 0;
      foreach (double sample in BandWidthSamples)
      {
        sum += sample;
      }
      airSpeedIndicatorInstrumentControl1.SetAirSpeedIndicatorParameters(0);
      StatusLabel.Text = "Avg. Con. Speed: "+ (sum/BandWidthSamples.Count).ToString("#.##") + " Mbps";
      File.Delete(DownloadedFileName);
      TestBtn.Enabled = true;
      SaveGraphBtn.Enabled = true;
    }

    private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
      ProgressUpdate.Value = e.ProgressPercentage;

      long ticksElapsed = DateTime.Now.TimeOfDay.Ticks - timer;
      long milisecondsElapsed = ticksElapsed / 10000;
      BW = CalculateBandWidth(e.BytesReceived, milisecondsElapsed);
      BandWidthSamples.Add(BW);
    }

    private double CalculateBandWidth(long BytesReceived, long milisecondsElapsed)
    {
      return ((BytesReceived*8) / ((double)milisecondsElapsed / 1000))/(1024*1024);
    }

    private void UpdateUITimer_Tick(object sender, EventArgs e)
    {
      plotter.Add((float)BW);
      airSpeedIndicatorInstrumentControl1.SetAirSpeedIndicatorParameters((int)BW);
    }

    private void SpeedTest_FormClosing(object sender, FormClosingEventArgs e)
    {
      webClient.DownloadFileCompleted -= new AsyncCompletedEventHandler(Completed);
      webClient.DownloadProgressChanged -= new DownloadProgressChangedEventHandler(ProgressChanged);
      webClient.Dispose();
    }

  }
}
