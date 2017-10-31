using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Prac8
{
  public  class _13090337
    {
        string Id;
        string nombre;
        string apellido;
        string direccion;
        int telefono;
        string carrera;
        string semestre;
        string correo;
        string github;
        bool deleted;


        [JsonProperty(PropertyName = "ID")]
        public string ID
        {


            get { return Id; }
            set { Id = value; }
        }


        [JsonProperty(PropertyName = "nombre")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        [JsonProperty(PropertyName = "apellido")]
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        [JsonProperty(PropertyName = "direccion")]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        [JsonProperty(PropertyName = "telefono")]
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        [JsonProperty(PropertyName = "carrera")]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }


        [JsonProperty(PropertyName = "semestre")]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }


        [JsonProperty(PropertyName = "correo")]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }


        [JsonProperty(PropertyName = "github")]
        public string GitHub
        {
            get { return github; }
            set { github = value; }
        }

        [Version]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
    }
}
