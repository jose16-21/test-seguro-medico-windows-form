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
using WindowsFormsApp.Models;


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        //public dynamic Put(string url, string json, string autorizacion = null)
        //{
        //    try
        //    {
        //        var client = new RestClient(url);
        //        var request = new RestRequest(Method.PUT);
        //        request.AddHeader("content-type", "application/json");
        //        request.AddParameter("application/json", json, ParameterType.RequestBody);

        //        if (autorizacion != null)
        //        {
        //            request.AddHeader("Authorization", autorizacion);
        //        }

        //        IRestResponse response = client.Execute(request);

        //        dynamic datos = JsonConvert.DeserializeObject(response.Content);

        //        return datos;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}
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
        public dynamic Delete(string url, string autorizacion = null)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.DELETE);
                request.AddHeader("content-type", "application/json");
                //request.AddParameter("application/json", json, ParameterType.RequestBody);

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

        private string Url = "https://localhost:44370/api/";
        private string UrlProveedores = "Proveedores";
        private string UrlPersonas = "Personas";
        public Form1()
        {
            InitializeComponent();
            ///llena el  combo box
            //DropProveedores.DataSource = respuestas;
            //DropProveedores.DisplayMember = "nombre";
            //DropProveedores.ValueMember = "id";
            CargaPac();
            CargaProv();
            CargaPer();

        }
        private void CargaPac()
        {
            String Pacientes = "Pacientes";
            dynamic resPac = this.Get(Url + Pacientes, null);
            dgPac.DataSource = resPac;
        }
        private void CargaPer()
        {
            dynamic resPer = this.Get(Url + UrlPersonas, null);
            dgPer.DataSource = resPer;
        }
        private void CargaProv()
        {

            dynamic resProv = this.Get(Url + UrlProveedores, null);
            dgProv.DataSource = resProv;
        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Proveedor";
            tabPage2.Text = "Persona";
            //tabPage3.Text = "Servicios";
            tabPage4.Text = "Paciente";
            tabPage5.Text = "Pago Prima";
            tabPage6.Text = "Facturas";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //string json = "{\"id\":0,\"nombre\":\"" + NombreSer.Text + "\",\"descripcion\":\"" + DescripcionSer.Text + "\",\"proveedorId\":" + DropProveedores.SelectedIndex + "}";



            ////var cadena =  + DescripcionSer.Text + DropProveedores.SelectedIndex;
            //try
            //{
            //    String Entidad = "servicios";
            //    dynamic respuesta = this.Post(Url + Entidad, json);

            //    MessageBox.Show(respuesta.ToString());
            //    NombreSer.Clear();
            //    DescripcionSer.Clear();
            //    MessageBox.Show("Ingresado correctamente");
            //    //else formulario que tengo activo pueda interactura con el nuevo formulario               
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("Datos Invalidos Intente de Nuevo");
            //    Console.WriteLine(error.Message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string json = "{\"id\":0,\"nombres\":\"" + Nombres.Text + "\",\"apellidos\":\"" + Apellidos.Text + "\",\"edad\":" + Edad.Text + ",\"direccion\":\"" + Direccion.Text + "\"}";



            //var cadena =  + DescripcionSer.Text + DropProveedores.SelectedIndex;
            try
            {
                //String Entidad = "personas";
                //dynamic respuesta = this.Post(Url + Entidad, json);

                //MessageBox.Show(respuesta.ToString());
                //Nombres.Clear();
                //Apellidos.Clear();
                //Direccion.Clear();
                //Edad.Clear();
                MessageBox.Show("Ingresado correctamente");
                //else formulario que tengo activo pueda interactura con el nuevo formulario               
            }
            catch (Exception error)
            {
                MessageBox.Show("Datos Invalidos Intente de Nuevo");
                Console.WriteLine(error.Message);
            }
        }

        private Proveedor GetValueProd()
        {
            var Proveedor = new Proveedor();
            Proveedor.Nit = NitProv.Text;
            Proveedor.Nombre = NombreProv.Text;
            Proveedor.RazonSocial = RazonProv.Text;
            Proveedor.Direccion = DireccionPrvo.Text;
            Proveedor.Telefono = Int32.Parse(TelefonoProv.Text);
            Proveedor.Estado = "Activo";

            return Proveedor;
        }

        private Personas GetValuePer()
        {
            try
            {
                var Personas = new Personas();
                Personas.PrimerNombre = Nombre1Per.Text;
                Personas.SegundoNombre = Nombre2Per.Text;
                Personas.PrimerApellido = Apellido1Per.Text;
                Personas.SegundoApellido = Apellido2Per.Text;
                Personas.Edad = Int32.Parse(EdadPer.Text);
                Personas.Direccion = DireccionPer.Text;
                Personas.FechaNacimiento = NacimientoPer.SelectionRange.Start;
                Personas.Estado = "Activo";

                return Personas;

            }catch(Exception Ex)
            {
                MessageBox.Show("Validar correctamente El ingreso de Datos" , Ex.Message.ToString());
                return null;
            }
            
        }

        private void ClearFormPer()
        {
            IdPer.Clear();
           Nombre1Per.Clear();
           Nombre2Per.Clear();
           Apellido1Per.Clear();
           Apellido2Per.Clear();
           EdadPer.Clear();
           DireccionPer.Clear();
            
        }
        private void ClearForm()
        {
            IdProv.Clear();
            NitProv.Clear();
            NombreProv.Clear();
            RazonProv.Clear();
            DireccionPrvo.Clear();
            TelefonoProv.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var Prov = GetValueProd();

            var jsonString = JsonConvert.SerializeObject(Prov);

            try
            {
                //dynamic respuesta = this.Post(Url + UrlProveedores, jsonString);
                ClearForm();
                CargaProv();
                MessageBox.Show("Ingresado correctamente");

            }
            catch (Exception error)
            {
                MessageBox.Show("Datos Invalidos Intente de Nuevo");
                Console.WriteLine(error.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (IdProv.Text == "")
                {
                    MessageBox.Show("Agregue un UUID para buscar su proveedor");
                }
                else
                {

                    //dynamic resProv = this.Get(Url + UrlProveedores + "/" + IdProv.Text, null);

                    //Proveedor proveedor = JsonConvert.DeserializeObject<Proveedor>(resProv.ToString());

                    //NitProv.Text = proveedor.Nit;
                    //NombreProv.Text = proveedor.Nombre;
                    //RazonProv.Text = proveedor.RazonSocial;
                    //DireccionPrvo.Text = proveedor.Direccion;
                    //TelefonoProv.Text = proveedor.Telefono.ToString();

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Proveedor = GetValueProd();

            var jsonString = JsonConvert.SerializeObject(Proveedor);

            try
            {

                //dynamic respuesta = this.Put(Url + UrlProveedores + "/" + IdProv.Text, jsonString, null);
                CargaProv();
                ClearForm();
                MessageBox.Show("Actualizado correctamente");
                //else formulario que tengo activo pueda interactura con el nuevo formulario               
            }
            catch (Exception error)
            {
                MessageBox.Show("Datos Invalidos Intente de Nuevo");
                Console.WriteLine(error.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (IdProv.Text == "")
                {
                    MessageBox.Show("Agregue un UUID para Eliminar su proveedor");
                }
                else
                {

                    //dynamic resProv = this.Delete(Url + UrlProveedores + "/" + IdProv.Text, null);
                    //Proveedor proveedor = JsonConvert.DeserializeObject<Proveedor>(resProv.ToString());
                    //ClearForm();
                    //CargaProv();
                    MessageBox.Show("Eliminado correctamente");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            var Per = GetValuePer();

            var jsonString = JsonConvert.SerializeObject(Per);

            try
            {
                dynamic respuesta = this.Post(Url + UrlPersonas, jsonString);
                ClearFormPer();
                CargaPer();
                MessageBox.Show("Ingresado correctamente");

            }
            catch (Exception error)
            {
                MessageBox.Show("Datos Invalidos Intente de Nuevo");
                Console.WriteLine(error.Message);
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ClearFormPer();
        }

        private void BtnActualizarPer_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarPer_Click(object sender, EventArgs e)
        {

        }

        private void BtpnBuscarPer_Click(object sender, EventArgs e)
        {
            try
            {

                if (IdPer.Text == "")
                {
                    MessageBox.Show("Agregue un UUID para buscar su proveedor");
                }
                else
                {

                    dynamic resProv = this.Get(Url + UrlPersonas + "/" + IdPer.Text, null);

                    Personas personas = JsonConvert.DeserializeObject<Personas>(resProv.ToString());


                    Nombre1Per.Text = personas.PrimerNombre;
                    Nombre2Per.Text = personas.SegundoNombre ;
                    Apellido1Per.Text = personas.PrimerApellido  ;
                    Apellido2Per.Text =personas.SegundoApellido;
                    EdadPer.Text = personas.Edad.ToString();
                    DireccionPer.Text = personas.Direccion;
                    
                    

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }
    }
}
