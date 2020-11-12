using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private string Url = "https://localhost:44370/api/";

        public Form1()
        {
            InitializeComponent();
            String Entidad = "Proveedores";
            dynamic respuestas = this.Get(Url + Entidad, null);
            ///llena el  combo box
            DropProveedores.DataSource = respuestas;
            DropProveedores.DisplayMember = "nombre";
            DropProveedores.ValueMember = "id";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public dynamic Post(string url, string json, string autorizacion = null)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                if (autorizacion != null)
                {
                    request.AddHeader("Authorization", autorizacion);
                }

                IRestResponse response = client.Execute(request);

                dynamic datos = JsonConvert.DeserializeObject(response.Content);

                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public dynamic Get(string url, string token)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            //myWebRequest.CookieContainer = myCookie;
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            //esto de content type se lo agregue yo octavio en el bearear tengo que ver como meter aqui el token y luego inseretarselo aqui en bes del token quemado
            myWebRequest.ContentType = "application/json";
            myWebRequest.Headers.Add("Authorization", "Bearer " + token);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            //Leemos los datos
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
            dynamic data = JsonConvert.DeserializeObject(Datos);

            return data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string json = "{\"id\":0,\"nombre\":\"" + NombreSer.Text + "\",\"descripcion\":\"" + DescripcionSer.Text + "\",\"proveedorId\":" + DropProveedores.SelectedIndex + "}";



            //var cadena =  + DescripcionSer.Text + DropProveedores.SelectedIndex;
            try
            {
                String Entidad = "servicios";
                dynamic respuesta = this.Post(Url + Entidad, json);

                MessageBox.Show(respuesta.ToString());
                NombreSer.Clear();
                DescripcionSer.Clear();
                MessageBox.Show("Ingresado correctamente");
                //else formulario que tengo activo pueda interactura con el nuevo formulario               
            }
            catch (Exception error)
            {
                MessageBox.Show("Datos Invalidos Intente de Nuevo");
                Console.WriteLine(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string json = "{\"id\":0,\"nombres\":\"" + Nombres.Text + "\",\"apellidos\":\"" + Apellidos.Text + "\",\"edad\":" + Edad.Text + ",\"direccion\":\"" + Direccion.Text + "\"}";



            //var cadena =  + DescripcionSer.Text + DropProveedores.SelectedIndex;
            try
            {
                String Entidad = "personas";
                dynamic respuesta = this.Post(Url + Entidad, json);

                MessageBox.Show(respuesta.ToString());
                Nombres.Clear();
                Apellidos.Clear();
                Direccion.Clear();
                Edad.Clear();
                MessageBox.Show("Ingresado correctamente");
                //else formulario que tengo activo pueda interactura con el nuevo formulario               
            }
            catch (Exception error)
            {
                MessageBox.Show("Datos Invalidos Intente de Nuevo");
                Console.WriteLine(error.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            string json = "{\"id\":0,\"nombre\":\"" + NombreProv.Text + "\",\"razonSocial\":\"" + RazonProv.Text + "\",\"direccion\":\"" + DireccionPrvo.Text + "\"}";

            //var cadena =  + DescripcionSer.Text + DropProveedores.SelectedIndex;
            try
            {
                String Entidad = "proveedores";
                dynamic respuesta = this.Post(Url + Entidad, json);
                MessageBox.Show(respuesta.ToString());
                NombreProv.Clear();
                RazonProv.Clear();
                DireccionPrvo.Clear();
                MessageBox.Show("Ingresado correctamente");
                //else formulario que tengo activo pueda interactura con el nuevo formulario               
            }
            catch (Exception error)
            {
                MessageBox.Show("Datos Invalidos Intente de Nuevo");
                Console.WriteLine(error.Message);
            }
        }
    }
}
