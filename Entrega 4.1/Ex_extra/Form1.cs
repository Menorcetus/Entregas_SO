using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Ex_extra
{
    public partial class Form1 : Form
    {
        Socket server;

        public Form1()
        {
            InitializeComponent();
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            IPAddress direcc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direcc, 9080);

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            if (server == null)
            {
                MessageBox.Show("Y si pruevas a conectarte primero...");
                return;
            }

            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            server = null;
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            switch (server)
            {
                case null:
                    MessageBox.Show("Conectate al server antes de continuar");
                    break;
                default:
                    if (Selector.SelectedIndex == 0)
                    {
                        string mensaje = "1/" + Temperatura.Text;
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                        server.Send(msg);

                        byte[] msg2 = new byte[80];
                        server.Receive(msg2);
                        mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                        MessageBox.Show(mensaje);
                    }
                    else if (Selector.SelectedIndex == 1)
                    {
                        string mensaje = "2/" + Temperatura.Text;
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                        server.Send(msg);

                        byte[] msg2 = new byte[80];
                        server.Receive(msg2);
                        mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                        MessageBox.Show(mensaje);
                    }
                    else if (Selector.SelectedIndex == -1)
                    {
                        MessageBox.Show("Selecciona una escala de temperaturas, esta al lado del texto");
                    }
                    break;
            }
        }
    }
}