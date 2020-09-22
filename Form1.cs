using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void SetConnection(char[] IpAddress, int Port);
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetConnectionPort();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void GetConnectionAddress(char[] Data);
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetConnectionAddressLength();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetConnection(char[] Data, out int Port);
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void Connect();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void Disconnect();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern byte IsConnected();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void DownloadDevId();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern byte IsDevIdExists();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetDevTypeLength();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void GetDevType(char[] Data);
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetNameLen();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DownloadStatus();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern byte IsStatusExists();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern byte IsPrinting();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern byte GetPrintMode();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetActiveTxtNameLen();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void GetActiveTxt(char[] Data);
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void PrintOn();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void PrintOffNow();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void SetActiveTxt(char[] TextName);
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern byte IsCountersExists();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void DownloadCounters();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetGlobalCounter();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetLastMsg();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void PowerOff();
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void SendFieldData(char[] Data);
        [DllImport("EbsApi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLibVer(out UInt16 a, out UInt16 b, out UInt16 c, out UInt16 d);
        [DllImport("Test.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Add(int a, int b);

        private void EConnectionError()
        {
            MessageBox.Show("Connection Error");
        }

        private void ESetConnection()
        {
            MessageBox.Show("Set Connection");
        }

        private void EDownloadId()
        {
            MessageBox.Show("Download ID");
        }

        private void EDownloadStatus()
        {
            MessageBox.Show("Download Status");
        }

        private void EDownloadCounters()
        {
            MessageBox.Show("Download Counters");
        }

        private void OK_Click(object sender, EventArgs e)
        {
            int Answer;
            byte TestByte;
            char[] Data;
            string TestString;
            UInt16 a, b, c, d;
            char[] IpAddress = IpTextBox.Text.ToCharArray();
            int Port = Convert.ToInt16(PortTextBox.Text);
            char[] TextName = TextNameTextBox.Text.ToCharArray();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    try
                    {
                        SetConnection(IpAddress, Port);
                    }
                    catch
                    {
                        EConnectionError();
                    }
                    break;
                case 1:
                    try
                    {
                        Answer = GetConnectionPort();
                        MessageBox.Show(Answer.ToString());
                    }
                    catch
                    {
                        EConnectionError();
                    }
                    
                    break;
                case 2:
                    try
                    {
                        Answer = GetConnectionAddressLength();
                        Data = new char[Answer + 1];
                        GetConnectionAddress(Data);
                        TestString = new string(Data);
                        MessageBox.Show(TestString);
                    }
                    catch
                    {
                        ESetConnection();
                    }
                    break;
                case 3:
                    try
                    {
                    Answer = GetConnectionAddressLength();
                        MessageBox.Show(Answer.ToString());
                    }
                    catch
                    {
                        ESetConnection();
                    }
                    break;
                case 4:
                    try
                    {
                        Answer = GetConnectionAddressLength();
                        Data = new char[Answer + 1];
                        GetConnection(Data, out Port);
                        TestString = new string(Data);
                        MessageBox.Show(TestString);
                        MessageBox.Show(Port.ToString());
                    }
                    catch
                    {
                        ESetConnection();
                    }
                    
                    break;
                case 5:
                    try
                    {
                        Connect();
                    }
                    catch
                    {
                        EConnectionError();
                    }

                    break;
                case 6:
                    try
                    {
                       Disconnect();
                    }
                    catch
                    {
                        EConnectionError();
                    }
                    break;
                case 7:
                    try
                    {
                        TestByte = IsConnected();
                        if (TestByte > 0)
                        {
                            MessageBox.Show("Yes");
                        }
                        else
                        {
                            MessageBox.Show("No");
                        }
                    }
                    catch
                    {
                        EConnectionError();
                    }
                    break;
                case 8:
                    try
                    {
                        DownloadDevId();
                    }
                    catch
                    {
                        ESetConnection();
                    }
                    break;
                case 9:
                    try
                    {
                        TestByte = IsDevIdExists();
                        if (TestByte > 0)
                        {
                            MessageBox.Show("Yes");
                        }
                        else
                        {
                            MessageBox.Show("No");
                        }
                    }
                    catch
                    {
                        EDownloadId();
                    }
                    break;
                case 10:
                    try
                    {
                        Answer = GetDevTypeLength();
                        MessageBox.Show(Answer.ToString());
                    }
                    catch
                    {
                        EDownloadId();
                    }
                    break;
                case 11:
                    try
                    {
                        Answer = GetDevTypeLength();
                        Data = new char[Answer + 1];
                        GetDevType(Data);
                        TestString = new string(Data);
                        MessageBox.Show(TestString);
                    }
                    catch
                    {
                        EDownloadId();
                    }
                    break;
                case 12:
                    try
                    {
                        Answer = GetNameLen();
                        MessageBox.Show(Answer.ToString());
                    }
                    catch
                    {
                        EDownloadId();
                    }
                    break;
                case 13:
                    try
                    {
                        DownloadStatus();
                    }
                    catch
                    {
                        EDownloadId();
                    }
                    break;
                case 14:
                    try
                    {
                        TestByte = IsStatusExists();
                        if (TestByte > 0)
                        {
                            MessageBox.Show("Yes");
                        }
                        else
                        {
                            MessageBox.Show("No");
                        }
                    }
                    catch
                    {
                        EDownloadId();
                    }
                    
                    break;
                case 15:
                    try
                    {
                        TestByte = IsPrinting();
                        if (TestByte > 0)
                        {
                            MessageBox.Show("Yes");
                        }
                        else
                        {
                            MessageBox.Show("No");
                        }
                    }
                    catch
                    {
                        EDownloadId();
                    }
                    
                    break;
                case 16:
                    try
                    {
                        TestByte = GetPrintMode();
                        switch (TestByte)
                        {
                            case 0:
                                MessageBox.Show("Paused");
                                break;
                            case 1:
                                MessageBox.Show("Std");
                                break;
                            case 2:
                                MessageBox.Show("Multirow");
                                break;
                            case 3:
                                MessageBox.Show("Code");
                                break;
                        }
                    }
                    catch
                    {
                        EDownloadStatus();
                    }
                    break;
                case 17:
                    try
                    {
                        Answer = GetActiveTxtNameLen();
                        MessageBox.Show(Answer.ToString());
                    }
                    catch
                    {
                        EDownloadStatus();
                    }
                    
                    break;
                case 18:
                    try
                    {
                        Answer = GetActiveTxtNameLen();
                        Data = new char[Answer + 1];
                        GetActiveTxt(Data);
                        TestString = new string(Data);
                        MessageBox.Show(TestString);
                    }
                    catch
                    {
                        EDownloadStatus();
                    }
                    
                    break;
                case 19:
                    try
                    {
                        PrintOn();
                    }
                    catch
                    {
                        ESetConnection();
                    }
                    
                    break;
                case 20:
                    try
                    {
                        PrintOffNow();
                    }
                    catch
                    {
                        ESetConnection();
                    }
                    break;
                case 21:
                    try
                    {
                        SetActiveTxt(TextName);
                        MessageBox.Show("Active Text is: " + TextName);
                    }
                    catch
                    {
                        EDownloadStatus();
                    }
                    
                    break;
                case 22:
                    try
                    {
                        TestByte = IsCountersExists();
                        if (TestByte > 0)
                        {
                            MessageBox.Show("Yes");
                        }
                        else
                        {
                            MessageBox.Show("No");
                        }
                    }
                    catch
                    {
                        EDownloadStatus();
                    }
                    
                    break;
                case 23:
                    try
                    {
                        DownloadCounters();
                    }
                    catch
                    {
                        EDownloadStatus();
                    }
                    break;
                case 24:
                    try
                    {
                        Answer = GetGlobalCounter();
                        MessageBox.Show(Answer.ToString());
                    }
                    catch
                    {
                        EDownloadCounters();
                    }
                    
                    break;
                case 25:
                    try
                    {
                        Answer = GetLastMsg();
                        MessageBox.Show(Answer.ToString());
                    }
                    catch
                    {
                        EDownloadStatus();
                    }
                    
                    break;
                case 26:
                    try
                    {
                        PowerOff();
                    }
                    catch
                    {
                        ESetConnection();
                    }
                    break;
                case 27:
                    try
                    {
                        string DataString = "";
                        for (int i = 0; i < SendFieldDataRichBox.Lines.Count(); i++)
                        {
                            DataString += SendFieldDataRichBox.Lines[i];
                            if (i < (SendFieldDataRichBox.Lines.Count() - 1))
                            {
                                DataString += (char)(09);
                            }
                        }
                        SendFieldData(DataString.ToCharArray());
                        MessageBox.Show(DataString);
                    }
                    catch
                    {
                        ESetConnection();
                    }
                    
                    break;
                case 28:
                    try
                    {
                        GetLibVer(out a, out b, out c, out d);
                        MessageBox.Show(a.ToString() + "." + b.ToString() + "." + c.ToString() + "." + d.ToString());
                    }
                  catch
                    {
                        MessageBox.Show("Make sure if EbsApi.dll exists");
                    }
                    break;
                case 29:
                    try
                    {
                        Answer = Add(4, 5);
                        MessageBox.Show(Answer.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Make sure if Test.dll file exists");
                    }
                    
                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
