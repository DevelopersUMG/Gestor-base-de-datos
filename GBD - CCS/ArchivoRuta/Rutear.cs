using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchivoRuta
{
    public class Rutear
    {
        public string RUTA(string nombre, string extencion, string carpeta)
        {
            //int x = 0;
            string obtenerutactual = AppDomain.CurrentDomain.BaseDirectory;// La ruta donde tengo el ejecutable
            string activeDir = @"" + obtenerutactual;// Ruta para escribir la carpeta
            string rutacompleta = System.IO.Path.Combine(activeDir, carpeta);   //Ruteo la carpeta 
            System.IO.Directory.CreateDirectory(rutacompleta);               //Creare la carpeta

            string nuevaBD = nombre + extencion;
            string h = "\\";
            char a = h[0];
            //string sourceFile = @"" + rutacompleta + a + "BD_default.sqlite";
            string destinationFile = @"" + rutacompleta + a + nuevaBD;
            //System.IO.File.Copy(sourceFile, destinationFile);//realizo la copia

            return destinationFile;
        }

    }
}
