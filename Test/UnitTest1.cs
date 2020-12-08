using System;
using System.Collections.Generic;
using ControlDeCalidad.AccesoADatos;
using ControlDeCalidad.Dominio.Entidades;
using ControlDeCalidad.Dominio.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private List<Modelo> modelos = new List<Modelo>();
        public List<Usuario> Usuarios = new List<Usuario>();

        [TestMethod]
        public void AgregarParPrimera()
        {
            Defectos defe1 = new Defectos("N/A");
            Unidad uniizq = new Unidad("izquierdo", defe1);
            Unidad unider = new Unidad("derecho", defe1);
            Par par1 = new Par(uniizq, unider);

            OrdenProduccion op1 = new OrdenProduccion();
            op1.AgregarParPrimera(par1);
        }

        [TestMethod]
        public void AgregarParSegunda()
        {
            Defectos defe2 = new Defectos("suela despegada");
            Unidad uniizq = new Unidad("izquierdo", defe2);
            Unidad unider = new Unidad("derecho", defe2);
            Par par2 = new Par(uniizq, unider);

            OrdenProduccion op2 = new OrdenProduccion();
            op2.AgregarParPrimera(par2);
        }

        [TestMethod]
        public void AgregarSupCal()
        {
            SupCalidad sc = new SupCalidad(123, 1111111, "Fransisco", "Vicente", "fvicente", "123");
            OrdenProduccion op3 = new OrdenProduccion();

            op3.AgregarSupervisorCalidad(sc);
        }

        [TestMethod]
        public void Userlogin()
        {
            //Usuario us = new Usuario("IvanaSC", "123");
            RepositorioUsuario repouser = new RepositorioUsuario();

            Assert.IsTrue(repouser.Login("IvanaC", "123"));
            Console.WriteLine("Se logro loguear el usuario.");
        }

        [TestMethod]
        public void AgregarLineaDeTrabajo()
        {
            SupLinea sl = new SupLinea(45564, 25778963, "Mariela", "Ferrer", "MarielaSL", "123");
            OrdenProduccion op4 = new OrdenProduccion();

            op4.AgregarLinea(sl);
        }
    }
}

