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
            Plug plug = new Plug("1");

            Adapter adapter = new Adapter(plug);
            ISmartDevice Plug = adapter;

            Console.WriteLine(Plug.GetStatus());
            Plug.On();
            
        }
    }
}