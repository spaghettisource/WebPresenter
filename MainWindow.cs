using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
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
            output.Write(buffer, 0, buffer.Length);
            // You must close the output stream.
            output.Close();
            listener.Stop();
        }

        private void sendStream() { }

        
    }
}
