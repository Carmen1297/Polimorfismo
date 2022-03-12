using System;


namespace Vehiculos_G2_2022_2
{
    public abstract class Transporte
    {
        #region Atributos
        internal string marca;
        internal string modelo;
        internal float precio;
        internal float velocidad;

        #endregion

        #region Propiedades
        public virtual  float Velocidad
        {
            //Leer
            get => velocidad;
            //Escribir
            set
            {
                if (value < 100|| value > 130)
                {
                    velocidad = 128;
                }
                else
                {
                    velocidad = value;
                }
            }
        }
        #endregion

        #region Constructores
       
        #endregion

        #region Metodos
               public Transporte(string Marca, string Modelo, float Precio,float Velocidad)
        {
            this.marca = Marca;
            this.modelo = Modelo;
            this.precio = Precio;
            this.velocidad = Velocidad;

        }

        public float Marca { get; internal set; }
        public float Precio { get; internal set; }
        public string Modelo { get; internal set; }
        //public float Velocidad { get; internal set; }

        public void ImprimirPantallaTrasporte()
        {
            Console.WriteLine("Caracteristicas");
            Console.WriteLine(marca,modelo,precio,velocidad);
        }
        public void ElevarAceleracion()
        {
            velocidad++;
            //LimpiarPantalla();
            Console.WriteLine("Estas acelarando,Velocidad: {0} km/h ", velocidad);

        }
        #endregion
      
    }

}

