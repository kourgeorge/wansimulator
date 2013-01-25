using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NetEmulator
{
  public class NetMonLogger
  {
    private string LogFileName;
    private StreamWriter LogFile;
    private string log;
    private bool LogState;  //Determines wheher to redirect Result.Text to log file

    public void InitializeLogFile(bool LogState)
    {
      LogState = LogState;
      if (LogState==false)
        return;
      //Create the Wansim Directiry
      if (!Directory.Exists(@"C:\Wansim"))
      {
        Directory.CreateDirectory(@"C:\Wansim");
      }

      //Create the log file in the filesystem
      string LogFileName = @"C:\Wansim\NetmonLog.html";
      LogFileName = LogFileName.Insert(LogFileName.IndexOf("."), "__D" + DateTime.Now.ToLongDateString().Replace(" ", "_")+ "__T" + DateTime.Now.ToLongTimeString().Replace(":", "_"));
      LogFile = new System.IO.StreamWriter(LogFileName, true);
      LogFile.WriteLine(
        @"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.01 Transitional//EN"" ""http://www.w3.org/TR/html4/loose.dtd"">");

      LogFile.WriteLine("<html>");
      LogFile.WriteLine("<head>");
      LogFile.WriteLine("<title>NetMon Log</title>");
      LogFile.WriteLine(
        @"<p style=""color: #3A3A3A; font-size: xx-large; font-weight: bold;"">Wansim - NetMon Log</p>");
      LogFile.WriteLine(
        @"<p style=""color: #224466; font-size: medium; font-weight: bold"">HP Software R&D Internal</p>");
      LogFile.WriteLine(@"<style type=""text/css"">");

      LogFile.WriteLine("</style>");
      LogFile.WriteLine("</head>");
      LogFile.WriteLine(@"<body bgcolor=""#FFFFFF"" topmargin=""6"" leftmargin=""6"">");
      LogFile.WriteLine(@"<hr size=""1"" noshade>");
      LogFile.WriteLine("Log session start time: " + DateTime.Now.ToString() + "<br><br>");
      LogFile.WriteLine(
        @"<table cellspacing=""0"" cellpadding=""4"" border=""1"" bordercolor=""#224466"" width=""100%"">");
      LogFile.WriteLine("<tr> <th>Time</th><th>Category</th><th>Message</th></tr>");
    }


    public void AddEventToLog(int Category, string Message)
    {
      if (LogState == false)
        return;
      LogFile.WriteLine("<tr>");
      string NowTime = DateTime.Now.TimeOfDay.ToString();
      if (NowTime.Length >= 12)
      {
        NowTime = NowTime.Substring(0, 12);
      }
      string NowDay = DateTime.Now.Date.ToString().Substring(0, 10);
      LogFile.WriteLine("<td>" + NowDay + "  " + NowTime + "</td>");
      if (Category == 1)
      {
        LogFile.WriteLine("<td title=" + "Category" + ">" + "Info" + "</td>");
      }
      else
      {
        LogFile.WriteLine("<td title=" + "Category" + " style=" + "color: #0F73A1" + ">" + "Performance" + "</td>");
      }
      LogFile.WriteLine("<td title=" + "Message" + ">" + Message + "</td>");
      LogFile.WriteLine("</tr>");
    }

    public void CloseStream()
    {
      if (LogState == false)
        return;
      LogFile.Close();
    }
  }
}
