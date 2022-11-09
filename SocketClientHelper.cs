using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace AsynchronousSocketClient
{
    class SocketClientHelper
    {
        public SocketClientHelper(string ip, int port)
        {
            Ip = ip;
            Port = port;
        }

        public string Ip { get; set; }
        public int Port { get; set; }
        private Socket SocketHandler { get; set; }

        public Action<string> Log;
        public Action<string> Exclog;

        private AutoResetEvent connectDone = new AutoResetEvent(false);
        private AutoResetEvent receiveDone = new AutoResetEvent(false);
        private AutoResetEvent disconnectDone = new AutoResetEvent(false);

        public void ConnectToServer()
        {
            try
            {
                SocketHandler = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                SocketHandler.BeginConnect(new IPEndPoint(IPAddress.Parse(Ip), Port), new AsyncCallback(ConnectCallback), SocketHandler);
                connectDone.WaitOne(1000);
            }
            catch (Exception ex)
            {
                Exclog?.Invoke(ex.Message);
            }
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket socket = (Socket)ar.AsyncState;
                socket.EndConnect(ar);
                SocketHandler = socket;
                connectDone.Set();
            }
            catch(Exception ex)
            {
                Exclog?.Invoke(ex.Message);
            }
        }

        public void SendMsg(string msg)
        {
            try
            {
                byte[] sendbytes = Encoding.ASCII.GetBytes(msg);
                byte[] recvbytes = new byte[16384];
                SocketHandler.BeginSend(sendbytes, 0, sendbytes.Length, SocketFlags.None, new AsyncCallback(SendCallback), SocketHandler);

                ReceiveObj receiveObj = new ReceiveObj();
                receiveObj.RecvSocket = SocketHandler;
                SocketHandler.BeginReceive(receiveObj.Buffer, 0, receiveObj.BufferSize, SocketFlags.None, new AsyncCallback(ReceiveCallback), receiveObj);
                receiveDone.WaitOne(1000);
            }
            catch (SocketException sec)
            {
                Exclog?.Invoke(sec.Message);
            }
            catch (Exception ex)
            {
                Exclog?.Invoke(ex.Message);
            }
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket socket = (Socket)ar.AsyncState;
                socket.EndSend(ar);
            }
            catch (SocketException sec)
            {
                Exclog?.Invoke(sec.Message);
            }
            catch (Exception ex)
            {
                Exclog?.Invoke(ex.Message);
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                ReceiveObj receiveObj = (ReceiveObj)ar.AsyncState;
                var recvlen = receiveObj.RecvSocket.EndReceive(ar);
                receiveDone.Set();
                if (recvlen > 0)
                {
                    var temstr = Encoding.ASCII.GetString(receiveObj.Buffer, 0, recvlen);
                    Log?.Invoke(temstr);
                    //收到資料存入StringBuilder
                }
            }
            catch (SocketException sec)
            {
                Exclog?.Invoke(sec.Message);
            }
            catch (Exception ex)
            {
                Exclog?.Invoke(ex.Message);
            }
        }

        public void ConnectionClose()
        {
            try
            {
                SocketHandler.Close();
                //SocketHandler.BeginDisconnect(false, new AsyncCallback(DisconnectCallback), SocketHandler);
                //disconnectDone.WaitOne(500);
            }
            catch (SocketException sec)
            {
                Exclog?.Invoke(sec.Message);
            }
            catch (Exception ex)
            {
                Exclog?.Invoke(ex.Message);
            }
        }

        private void DisconnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket socket = ar.AsyncState as Socket;
                socket.EndDisconnect(ar);
                disconnectDone.Set();
            }
            catch (SocketException sec)
            {
                Exclog?.Invoke(sec.Message);
            }
            catch (Exception ex)
            {
                Exclog?.Invoke(ex.Message);
            }
        }
    }

    class ReceiveObj
    {
        public ReceiveObj()
        {
            Buffer = new byte[16384];
            BufferSize = 16384;
            Sb = new StringBuilder();
        }

        public byte[] Buffer { get; set; }
        public int BufferSize { get; set; }
        public StringBuilder Sb { get; set; }
        public Socket RecvSocket { get; set; }
    }
}
