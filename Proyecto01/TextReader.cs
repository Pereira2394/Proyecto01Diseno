using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class TextReader
    {
        public void readText(String filename)
        {
            //Cargo el archivo en el string 
            //Direccion Daniel:C:\Users\Daniel\Desktop\Texto\" + filename + ".txt"
            //Direccion Kevin:
            //Direccion Juan:
            String[] lines = (System.IO.File.ReadAllLines(@"C:\Users\Daniel\Desktop\Texto\" + filename + ".txt"));

            
            //Recorro cada linea de la variable.
            foreach (string line in lines)
            {
                //Voy imprimiendo cada linea
                Console.WriteLine("\t" + line);

                //Creo un arreglo que contiene cada char
                char[] wordArr = line.ToCharArray();                
                //Saco el tamaño de cada hilera y lo imprimo
                int val = line.Length - 1;
                Console.WriteLine(val);
                
                //EL PROBLEMA QUE HAY AHORITA ES QUE ME SOBREESCRIBE CADA FILA, NO CONCATENA.!
            }            
        }        
    }    
}
