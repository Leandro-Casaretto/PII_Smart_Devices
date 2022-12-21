//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using AdapterExample;

namespace ConsoleApplication
{
    
    public static class Program
    {

        public static void Main()
        {
            /// <summary>
            /// Instanciamos plug
            /// </summary>
            
            Plug plug = new Plug("1");
            Adapter adapter = new Adapter(plug);
            ISmartDevice Plug = adapter;
            Console.WriteLine(Plug.GetStatus());
            Plug.On();

            /// <summary>
            /// Instanciamos bulb
            /// </summary>

            Bulb bulb = new Bulb("1");
            Console.WriteLine(bulb.GetStatus());
            bulb.On();

            /// <summary>
            /// Instanciamos washing machine
            /// </summary>

            WashingMachine washingMachine = new WashingMachine("1");
            Console.WriteLine(washingMachine.GetStatus());
            washingMachine.On();
            
        }
    }
}