using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPresenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendImage_Click(object sender, EventArgs e)
        {
            sendStream();
        }

        private void sendStream() {
            MemoryStream memoryStream = new MemoryStream();
            selectedImage.Image.Save(memoryStream, ImageFormat.Jpeg);
            byte[] buffer = memoryStream.ToArray();

            // Create a listener.
            HttpListener listener = new HttpListener();

            listener.Prefixes.Add("http://localhost:8080/");

            listener.Start();
            Console.WriteLine("Listening...");
            // Note: The GetContext method blocks while waiting for a request. 
            HttpListenerContext context = listener.GetContext();
            HttpListenerRequest listenerrequest = context.Request;
            // Obtain a response object.
            HttpListenerResponse listenerresponse = context.Response;
            // Construct a response.           
            listenerresponse.ContentLength64 = buffer.Length;
            // Get a response stream and write the response to it.
            System.IO.Stream output = listenerresponse.OutputStream;
            try
            {
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error sending the file");
            }
            finally
            {
                output.Close();
                listener.Stop();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogOpenFile.ShowDialog();            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple program to send images without uploading them");
        }

        private void dialogOpenFile_FileOk(object sender, CancelEventArgs e)
        {            
            string filetype = System.Web.MimeMapping.GetMimeMapping(dialogOpenFile.FileName);
            if (filetype.StartsWith("image"))
            {
            try
            {
                selectedImage.LoadAsync(dialogOpenFile.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error loading the file");
            }
            }
            else
            {
                MessageBox.Show("You are trying to a file that is not an image");
            }
        }

        private void btnGetAddress_Click(object sender, EventArgs e)
        {
            //string localIP;
            //using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            //{
            //    socket.Connect("10.0.2.4", 65530);
            //    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
            //    localIP = endPoint.Address.ToString();
            //}

            MessageBox.Show("255.255.255.0", "IP Address");            
        }

        private void GetIPAddress()
        {

        }
        
    }
}
