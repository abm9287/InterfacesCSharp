﻿using System.Collections.Generic;

namespace Carreras.Interface
{
    public class CarreraArquitectura : ICarrera

    {
        //los sustantivos definen atributos
        private List<string> carrerasUniversitarias;
        private string nombre;

        public string Nombre { get { return nombre; } set { value = nombre; } }
        public List<string> CarrerasUniversitarias { get { return carrerasUniversitarias;  } set { value = carrerasUniversitarias; } }


        //Utilizamos verbos para los nombres de los métodos 
        public string Aprender()
        {
            return $"Estoy aprendiendo {nombre} y estoy estudiando {carrerasUniversitarias[0]} ";
        }
        public string Estudiar()
        {
            return "Estoy estudiando los diferentes elementos de acero  ";
        }
        public string Enseñar()
        {
            return "Estoy enseñando los tipos de materiales Ingenieros ";
        }
        public string Trabajar()
        {
            return "Estoy trabajando en la nueva carretera vía Samborondón ";
        }
        public string Leer()
        {
            return "Estoy leyendo los folletos de Construcción en Concreto y Acero ";
        }
        
    }
}
