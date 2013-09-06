using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;


namespace RegistroEnBitacora
{
    public class clBitacorax
    {
        /***************************************************************
        NOMBRE:             RegistroDeActividadEnBitacora
        FECHA:		        05-09-2013
        CREADOR:     	    Zayda Hernandez          
        DESCRIPCIÓN         
        DETALLE:            Se reciben los parametros que identifican al Usuario y la Sentencia que se ha ejecutado, para su registro en bitacora
        MODIFICACIÓN:       
        ***************************************************************/
        public void RegistroDeActividadEnBitacora(string lstusuario, string lstsentencia)
        {
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            string lstiplocal = IPHost.AddressList[0].ToString();
            String lstippublica = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                lstippublica = stream.ReadToEnd();
            }

            //Search for the ip in the html
            int linfirst = lstippublica.IndexOf("Address: ") + 9;
            int linlast = lstippublica.LastIndexOf("</body>");
            lstippublica = lstippublica.Substring(linfirst, linlast - linfirst);

            String lstarchivobd;
            string lstobtenerutactual = AppDomain.CurrentDomain.BaseDirectory;// La ruta donde tengo el ejecutable

            string h = "\\";
            char a = h[0];
            string[] vector = lstobtenerutactual.Split(h[0]);


            lstarchivobd = "C:/Users/" + vector[2] + "/Dropbox/CCS - ADST/Bitacora/Bitacora";

            string lstinsercion;
            string lstconsulta;
            int linidb;
            int linANUM = 0;
            SQLiteCommand sntc;
            SQLiteCommand snt;
            SQLiteConnection conexion;
            SQLiteDataReader datos;
            conexion = new SQLiteConnection("Data Source=" + lstarchivobd + ".sqlite;Version=3;New=False;Compress=True;");
            conexion.Open();

            try
            {
                lstconsulta = "SELECT * FROM BITACORA;";
                sntc = new SQLiteCommand(lstconsulta, conexion);
                datos = sntc.ExecuteReader();
                Console.WriteLine("UInicio de qhile");
                while (datos.Read())
                {
                    linidb = Convert.ToInt32(datos[0]);
                    while (linANUM <= linidb)
                    {
                        if (linANUM < linidb)
                        {
                            linANUM = linidb;

                        }
                        linANUM++;
                    }
                }

                lstinsercion = "INSERT INTO BITACORA VALUES  (" + linANUM + ",'" + lstusuario + "',datetime('now','localtime'),'" + lstsentencia + "','" + lstiplocal + "','" + lstippublica + "');";
                Console.WriteLine("Query ejecutado: " + lstinsercion);
                snt = new SQLiteCommand(lstinsercion, conexion);
                snt.ExecuteNonQuery();

            }

            catch (Exception e)
            {
            }

        }
    }
}
