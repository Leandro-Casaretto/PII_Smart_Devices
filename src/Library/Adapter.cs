using System;

namespace AdapterExample
{

    /// <summary>
    /// Implementamos la interfaz ISmartDevice
    /// </summary>
    public class Adapter : ISmartDevice
    {

        /// <summary>
        /// Creamos un plug para poder realizar aplicar el Adapter
        /// </summary>
        public Plug Plug { get; set; }

        public Adapter(Plug plug)
        {
            this.Plug = plug;
        }

        public string GetStatus()
        {
            return Plug.GetStatus();
        }

        /// <summary>
        /// Cambiamos el estado en caso de que esté OFF 
        /// </summary>
        public void On()
        {
            if (Plug.GetStatus().Equals("off"))
            {
            Plug.status = "on";
            Console.WriteLine("The Plug is on");
            }
        }

        /// <summary>
        /// Cambiamos el estado en caso de que esté ON 
        /// </summary>
        public void Off()
        {
            if (Plug.GetStatus().Equals("on"))
            {
            Plug.status = "off";
            Console.WriteLine("The Plug is off");
            }
        }
    }
}