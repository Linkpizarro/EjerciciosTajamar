using MvcTablasAzure.Models;
using MvcTablasAzure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTablasAzure.Controllers
{
    public class ClientesController : Controller
    {
        RepositoryTablaAzure repo;
        public ClientesController()
        {
            this.repo = new RepositoryTablaAzure();
        }

        public ActionResult Index()
        {
            List<Cliente> clientes = repo.GetClientes();
            return View(clientes);
        }

        [HttpPost]
        public ActionResult Index(String empresa)
        {
            List<Cliente> clientes = repo.GetClientesEmpresa(empresa);
            return View(clientes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            repo.CrearCliente(cliente.Empresa, cliente.IdCliente, cliente.Nombre, cliente.Apellidos);
            return RedirectToAction("Index");
        }

        public ActionResult Details(String empresa,String idcliente)
        {
            Cliente cliente = repo.BuscarCliente(empresa, idcliente);
            return View(cliente);
        }

        public ActionResult Edit(String empresa, String idcliente)
        {
            Cliente cliente = repo.BuscarCliente(empresa, idcliente);
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            repo.ModificarCliente(cliente.Empresa, cliente.IdCliente, cliente.Nombre, cliente.Apellidos);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String empresa,String idcliente)
        {
            repo.EliminarCliente(empresa, idcliente);
            return RedirectToAction("Index");

        }
    }
}