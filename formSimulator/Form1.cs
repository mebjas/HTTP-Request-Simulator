using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace formSimulator
{
    public partial class mainform : Form
    {
        private string data;
        private bool isGet = true;
        private string tempfile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +@"/formsimulatortemp.txt";
        public static string regexcase;
        public mainform()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (inputData.Text.Length == 0 || inputName.Text.Length == 0)
            {
                log("One or more field is missing");
                inputData.Text = inputName.Text = "";
                inputName.Select();
                return;
            }
            string addString = inputName.Text + "=" + inputData.Text;
            if (query.Text.Length != 0)
            {
                addString = "&" + addString;
            }
            query.Text += addString;
            log(addString +" added to query");
            inputData.Text = inputName.Text = "";
            inputName.Select();
        }
        
        private void log(string str)
        {
            logrtb.Text += Environment.NewLine + str;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            pb.Visible = true;
            pb.Value = 10;
            if (url.Text.Length == 0)
            {
                log("the url is missing ");
                url.Select();
                pb.Value = 0;
                pb.Visible = false;
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                log("You need to select either one of GET OR POST method");
                comboBox1.SelectedIndex = 0;
                pb.Value = 0;
                pb.Visible = false;
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            { 
                //get
                pb.Value = 20;
                log("GET method chosen");
                pb.Value = 30;
                log("attempting to send request to " +url.Text +"?" +query.Text);
                pb.Value = 40;
                requester.RunWorkerAsync();
                pb.Value = 50;
                log("Request sent");
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //get
                isGet = false;
                pb.Value = 20;
                log("POST method chosen");
                pb.Value = 30;
                log("attempting to send request to " + url.Text +" with post data as " +query.Text);
                pb.Value = 40;
                requester.RunWorkerAsync();
                pb.Value = 50;
                log("Request sent");

            }
        }
        /**
         * function to send post request to any page and retrieve the content
         */
        public string SendPost(string url, string postData)
        {
            string webpageContent = string.Empty;

            try
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = byteArray.Length;

                using (Stream webpageStream = webRequest.GetRequestStream())
                {
                    webpageStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                    {
                        webpageContent = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                //throw or return an appropriate response/exception
            }
            return webpageContent;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            query.Text = url.Text = inputName.Text = inputData.Text = "";
            logrtb.Text = response.Text = "";
            inputName.Select();
            regexbox.Enabled = regexbutton.Enabled = false;
        }

        private void requester_DoWork(object sender, DoWorkEventArgs e)
        {
            if(isGet) data = SendPost(url.Text + "?" + query.Text, "");
            else data = SendPost(url.Text,query.Text);
            requester.ReportProgress(1);
              
        }

        private void requester_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                log("Data recieved: [data-length] = " + data.Length);
                pb.Value += 40;
            }
        }

        private void requester_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            response.Text = data;
            pb.Value = 100;
            pb.Visible = false;
            pb.Value = 0;
            regexbox.Enabled = true;
            regexbutton.Enabled = true;
        }

        private void regexbutton_Click(object sender, EventArgs e)
        {
            string data = response.Text;

            string regexcase = regexbox.Text;
            File.WriteAllText(tempfile, "");
            foreach (Match m in Regex.Matches(data, @regexcase, RegexOptions.IgnoreCase | RegexOptions.Multiline))
            {
                File.AppendAllText(tempfile, m.Groups[0].Value.ToString() +Environment.NewLine);
            }
            Form2 obj = new Form2(regexcase);
            obj.Show();
        }

    }
}
