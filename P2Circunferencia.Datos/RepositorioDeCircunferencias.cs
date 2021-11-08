using P2Circunferencia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P2Circunferencia.Datos
{
    public class RepositorioDeCircunferencias
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Circunferencias.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + "\\Circunferencia.bak";
        private List<Circunferencia> listaCircunferencia;

        public static RepositorioDeCircunferencias instancia = null;
        public static RepositorioDeCircunferencias GetInstancia()
        {
            if (instancia==null)
            {
                instancia = new RepositorioDeCircunferencias();
            }
            return instancia;
        }

        
        public RepositorioDeCircunferencias()
        {
            listaCircunferencia = new List<Circunferencia>();
            listaCircunferencia = LeerDatosDelArchivo();
        }

        private List<Circunferencia> LeerDatosDelArchivo()
        {
            List<Circunferencia> lista = new List<Circunferencia>();
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Circunferencia circunferencia = ConstruirCircunferencia(linea);
                    lista.Add(circunferencia);
                }
                lector.Close();
            }
            return lista;
        } 

        private Circunferencia ConstruirCircunferencia(string linea)
        {
            var campos = linea.Split('|');
            return new Circunferencia() 
            { 
                Radio = int.Parse(campos[0]), 
                ColoresDispiblesRelleno=(ColoresDispiblesRelleno)int.Parse(campos[1]),
                ColoresDisponiblesBorde=(ColoresDisponiblesBorde)int.Parse(campos[2])
            };

        }

        public void Agregar(Circunferencia circunferencia)
        {
            listaCircunferencia.Add(circunferencia);
            AgregarEnArchivo(circunferencia);
        }

        private void AgregarEnArchivo(Circunferencia circunferencia)
        {
            StreamWriter escritor = new StreamWriter(_archivo,true);
            var linea = ConstruirLinea(circunferencia);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private object ConstruirLinea(Circunferencia circunferencia)
        {
            return $"{circunferencia.Radio} | {circunferencia.ColoresDispiblesRelleno.GetHashCode()} | {circunferencia.ColoresDisponiblesBorde.GetHashCode()}";
        }

        public bool Borrar(Circunferencia circunferencia)
        {
            BorrarDelArchivo(circunferencia);
            return listaCircunferencia.Remove(circunferencia);
        }

        private void BorrarDelArchivo(Circunferencia circunferencia)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Circunferencia circunferenciaEnArchivo = ConstruirCircunferencia(linea);
                if (!circunferenciaEnArchivo.Equals(circunferencia))
                {
                    escritor.WriteLine(linea);
                }
            }
            lector.Close();
            escritor.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }

        public void Editar(Circunferencia circunferencia, Circunferencia circunferenciaEditada)
        {

        }

        public int GetCantidad()
        {
            return listaCircunferencia.Count;
        }

        

        public List<Circunferencia> GetLista()
        {
            return listaCircunferencia;
        }

        public Circunferencia GetPorPosicion(int index)
        {
            return listaCircunferencia[index];
        }

        public bool Existe(Circunferencia circunferencia)
        {
            return listaCircunferencia.Contains(circunferencia);
        }

        public List<Circunferencia> OrdenAscendentePorRadio()
        {
            return listaCircunferencia.OrderBy( r=>r.Radio).ToList();
        }

        public List<Circunferencia> OrdenDescendentePorRadio()
        {
            return listaCircunferencia.OrderByDescending(r => r.Radio).ToList();
        }

        public List<Circunferencia> GetListaFiltrada(Func<Circunferencia, bool>predicado)
        {
            return listaCircunferencia.Where(predicado).ToList();
        }

        public int GetCantidad(Func<Circunferencia, bool> index)
        {
            return listaCircunferencia.Count(index);
        }
        //public int GetCantidad(string index)
        //{
        //    return listaCircunferencia.Count(p => p.ColoresDispiblesRelleno == index.ToString);
        //}
    }
}
