using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio11Rectangulo.Entidades;

namespace Ejercicio11Rectangulo.Datos
{
    public class RepositorioDeRectangulos
    {
        private List<Rectangulo> listaRectangulo;
        private readonly string _archivo = Environment.CurrentDirectory + @"\\Rectangulos.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\\Rectangulos.bak";

        public RepositorioDeRectangulos()
        {
            listaRectangulo = new List<Rectangulo>();
            listaRectangulo=LeerDatosDelArchivo();
        }

        private List<Rectangulo> LeerDatosDelArchivo()
        {
            var lista = new List<Rectangulo>();
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Rectangulo r = ConstruirRectangulo(linea);
                    lista.Add(r);
                }
                lector.Close();

            }
            return lista;
        }

        private Rectangulo ConstruirRectangulo(string linea)
        {
            var campos = linea.Split(';');
            return new Rectangulo()
            {
                LadoMayor = int.Parse(campos[0]),
                LadoMenor = int.Parse(campos[1])
            };
        }

        public void Agregar(Rectangulo rectangulo)
        {
            listaRectangulo.Add(rectangulo);
            AgregarRegistroAlArchivo(rectangulo);
        }

        private void AgregarRegistroAlArchivo(Rectangulo rectangulo)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            var linea = ConstruirLinea(rectangulo);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Rectangulo rectangulo)
        {
            return $"{rectangulo.LadoMayor};{rectangulo.LadoMenor}";
        }

        public void Borrar(Rectangulo rectangulo)
        {
            listaRectangulo.Remove(rectangulo);
        }

        public List<Rectangulo> GetLista()
        {
            return listaRectangulo;
        }

        public int GetCantidad()
        {
            return listaRectangulo.Count;
        }

        public bool Existe(Rectangulo rectangulo)
        {
            return listaRectangulo.Contains(rectangulo);
        }

        public void Editar(Rectangulo rectanguloSeleccionado, Rectangulo rectanguloEditado)
        {
            var index = listaRectangulo.FindIndex(r =>
                r.LadoMayor == rectanguloSeleccionado.LadoMayor &&
                r.LadoMenor == rectanguloSeleccionado.LadoMenor);
            listaRectangulo.RemoveAt(index);
            listaRectangulo.Insert(index,rectanguloEditado);
            EditarRegistroEnArchivo(rectanguloSeleccionado, rectanguloEditado);
        }

        private void EditarRegistroEnArchivo(Rectangulo rectanguloSeleccionado, Rectangulo rectanguloEditado)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Rectangulo rectanguloEnArchivo = ConstruirRectangulo(linea);
                if (!rectanguloEnArchivo.Equals(rectanguloSeleccionado))
                {
                    escritor.WriteLine(linea);
                }
                else
                {
                    linea = ConstruirLinea(rectanguloEditado);
                    escritor.WriteLine(linea);
                }
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }
    }
}
