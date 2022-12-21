//--------------------------------------------------------------------------------
// <copyright file="TrainTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using NUnit.Framework;
using AdapterExample;

namespace Tests
{

    public class DeviceTest
    {
    
        [SetUp]
        public void Setup()
        {
        
        }
        
        [Test]

        /// <summary>
        /// Testeamos el adapter (CASO ON)
        /// </summary>
        public void OnTest()
        {
            Plug plug = new Plug("1");
            ISmartDevice Plug = new Adapter(plug);

            Plug.On();
            Assert.AreEqual(Plug.GetStatus(), "on");
        }

        /// <summary>
        /// Testeamos el adapter (CASO OFF)
        /// </summary>

        [Test]
        public void OffTest()
        {
            Plug plug = new Plug("2");
            ISmartDevice Plug = new Adapter(plug);
            
            Plug.Off();
            Assert.AreEqual(Plug.GetStatus(), "off");
        }
    }

}

