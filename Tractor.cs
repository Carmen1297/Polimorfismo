using System;


namespace Vehiculos_G2_2022_2
{
     class Tractor:Transporte
    {
        #region Propiedades
        public override float Velocidad

        {
            get => base.velocidad;
            set
            {
                if (value < 100 || value > 130)
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

        public Tractor(string Marca, string Modelo, float Precio,float Velocidad) : base(Marca, Modelo, Precio,Velocidad)
        {
            base.marca = Marca;
            base.Modelo = Modelo;
            base.Precio = Precio;
            base.velocidad = Velocidad;

        }

        public void ImprimirPantalla()
        {
            //base.ImprimirPantallaTrasporte();
            Console.WriteLine(base.marca);
            Console.WriteLine(base.Modelo);
            Console.WriteLine(base.Precio);
            Console.WriteLine(base.Velocidad);



        }

        public  Tractor()
        {
            /*//Temperatura = 70;
            Console.WriteLine("Acelerando");
            for (int i = 0; i < 20; i++)
            {
                ElevarAceleracion();
            }
            Console.WriteLine("VELOCIDAD: {0} °C", Velocidad);
            //  MostrarPrecio(MostrarCodigoProducto());

        }
            */
        public void ElevarAceleracion()
        {
            Velocidad++;
            //LimpiarPantalla();
            Console.WriteLine("Estas acelarando,Velocidad: {0} km/h ", velocidad);

        }
    }
}
