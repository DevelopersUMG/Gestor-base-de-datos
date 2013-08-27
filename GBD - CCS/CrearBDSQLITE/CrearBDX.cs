using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CrearBDSQLITE
{
    public class CrearBDX
    {
        public int CrearBD(string nombre) {
            int x = 0;
            string obtenerutactual = AppDomain.CurrentDomain.BaseDirectory;// La ruta donde tengo el ejecutable
            string activeDir = @"" + obtenerutactual;// Ruta para escribir la BD
            string rutacompleta = System.IO.Path.Combine(activeDir, "BD");   //Ruteo la carpeta BD
            System.IO.Directory.CreateDirectory(rutacompleta);               //Creare la carpeta BD

            string nuevaBD = nombre + ".sqlite";
            string h = "\\";
            char a = h[0];
            string sourceFile = @"" + rutacompleta + a + "BD_default.sqlite";
            string destinationFile = @"" + rutacompleta + a + nuevaBD;
            System.IO.File.Copy(sourceFile, destinationFile);//realizo la copia
            
            return x;
        }
    }
}
