using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//improting Libary file
using System.Net;
using System.Net.Sockets;


namespace ChatApp
{
    public partial class Home : Form
    {
        //Local Variable declearation
        Socket sck;
        EndPoint epLocal,epRemote;
        byte[] buffer;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //setting up scoket & connections
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Calling user Define function(get local IP)
            txtLocalIP.Text = GetLocalIP();

            //Enabling Timer
            homeTimer.Enabled = false;
            homeTimer.Interval = 100;

        }
        //Creating a user define function(get local IP)
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress iP in host.AddressList)
            {
                if (iP.AddressFamily == AddressFamily.InterNetwork)
                    return iP.ToString();
            }
            return "10.20.30.25";
        }
        


        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close Function
            string message = "Are you sure you want to close this window";
            string title = "EXIT";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult result = MessageBox.Show(message, title, button, icon);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtFriendIP_Enter(object sender, EventArgs e)
        {
            // Creating Placeholder Text
            if(txtFriendIP.Text == "Friend's IP")
            {
                txtFriendIP.Text = "";
            }
        }

        private void txtFriendIP_Leave(object sender, EventArgs e)
        {
            // Creating Placeholder Text
            if(txtFriendIP.Text == "")
            {
                txtFriendIP.Text = "Friend's IP";
            }
        }

        private void txtLocalIP_Leave(object sender, EventArgs e)
        {

        }

        private void txtFriendPort_Enter(object sender, EventArgs e)
        {
            // Creating Placeholder Text 
            if(txtFriendPort.Text == "Port")
            {
                txtFriendPort.Text = "";
            }

        }

        private void txtFriendPort_Leave(object sender, EventArgs e)
        {
            //Creating Placeholder Text
            if(txtFriendPort.Text == "")
            {
                txtFriendPort.Text = "Port";
            }
        }

        private void txtLocalPort_Enter(object sender, EventArgs e)
        {
            // Creating Placeholder Text
            if (txtLocalPort.Text == "Port")
            {
                txtLocalPort.Text = "";
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIP.Text), Convert.ToInt32(txtLocalPort.Text));
            sck.Bind(epLocal);

            // Connection to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(txtFriendIP.Text), Convert.ToInt32(txtFriendPort.Text));
            sck.Connect(epRemote);

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epLocal, new AsyncCallback(MessageCallBack), buffer);
            
            // Disable textboxes & Buttons if  Connection Established
            if(sck.Connected)
            {
                txtFriendIP.Visible = false;
                txtFriendPort.Visible = false;
                txtLocalIP.Visible = false;
                txtLocalPort.Visible     = false;

                // Hiding Connect Button
                btnConnect.Visible = false;

                // Hiding Connection Label
                lblConnection.Visible = false;

                // Reposition ListMessage  Box
                listMessage.Size = new Size(301, 498);
                listMessage.Location = new Point(7, 67);

                // hiding items
                chatsPictureBox.Visible = false;
                lblChats.Text = "Chats";
                lblConnection.Visible = false;

            }
        }

        // Creating the Message Call Back Function
        private void MessageCallBack(IAsyncResult aResult)
        {
            byte[] recievedData = new byte[1500];
            recievedData = (byte[])aResult.AsyncState;

            // Converting byte to String
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            string recievedMessage = aEncoding.GetString(recievedData);

            // adding Message to the Message Box
            listMessage.Items.Add("FRIENDS : " + recievedMessage);

            //converting byte to string
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // conveerting string message to byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(txtMessageBox.text);

            //sending encoding message
            sck.Send(sendingMessage);

            //adding message to list box
            listMessage.Items.Add("Me : " + txtMessageBox.text);
            txtMessageBox.text = "";
               
        }

        private void txtLocalPort_Leave(object sender, EventArgs e)
        {
            // Creating Placeholder Text
            if (txtLocalPort.Text == "")
            {
                txtLocalPort.Text = "Port";
            }
        }
    }
}
