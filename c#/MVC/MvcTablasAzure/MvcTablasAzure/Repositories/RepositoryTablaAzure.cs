using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using MvcTablasAzure.Models;

namespace MvcTablasAzure.Repositories
{
    public class RepositoryTablaAzure
    {
        CloudTable tabla;

        public RepositoryTablaAzure()
        {
            String keys =
                CloudConfigurationManager.GetSetting("StorageConnectionString");
            CloudStorageAccount account =
                CloudStorageAccount.Parse(keys);
            CloudTableClient client = account.CreateCloudTableClient();
            this.tabla = client.GetTableReference("clientesazure");
            this.tabla.CreateIfNotExists();
        }

        public void CrearCliente(String empresa, String idcliente
            ,String nombre, String apellidos)
        {
            //CREAMOS EL OBJETO ENTITY
            Cliente cli = new Cliente();
            //ALMACENAMOS LA EMPRESA Y, A LA VEZ, SU PARTITION KEY
            cli.Empresa = empresa;
            //REALIZAMOS LO MISMO CON IDCLIENTE Y ROWKEY
            cli.IdCliente = idcliente;
            cli.Nombre = nombre;
            cli.Apellidos = apellidos;
            //CREAMOS LA OPERACION PARA LA TABLA
            TableOperation operation = TableOperation.Insert(cli);
            //LAS OPERACIONES SE EJECUTAN SOBRE LA TABLA
            this.tabla.Execute(operation);
        }

        //PARA BUSCAR CLIENTES POR SU "ID", DEBEMOS HACERLO
        //POR SU PARTITION KEY Y SU ROW KEY
        public Cliente BuscarCliente(String partitionkey
            , String rowkey)
        {
            //PARA BUSCAR POR KEY, SE HACE CON TABLEOPERATION
            TableOperation operation =
                TableOperation.Retrieve<Cliente>(partitionkey, rowkey);
            //EL RESULTADO DE RETRIEVE ES UN TableResult
            TableResult result = this.tabla.Execute(operation);
            if (result.Result == null)
            {
                return null;
            }
            else
            {
                Cliente cli = result.Result as Cliente;
                return cli;
            }
        }

        public void ModificarCliente(String empresa,String idCliente,String nombre,String apellido)
        {
            Cliente cliente = this.BuscarCliente(empresa, idCliente);
            if(cliente != null)
            {
                cliente.Nombre = nombre;
                cliente.Apellidos = apellido;
                TableOperation operation = TableOperation.Replace(cliente);
                this.tabla.Execute(operation);
            }
        }
        
        public void EliminarCliente(String partitionkey,String rowkey)
        {
            Cliente cliente = this.BuscarCliente(partitionkey, rowkey);
            if(cliente != null)
            {
                TableOperation operation = TableOperation.Delete(cliente);
                this.tabla.Execute(operation);
            }
        }

        public List<Cliente> GetClientesEmpresa(String empresa)
        {
            TableQuery<Cliente> query = new TableQuery<Cliente>();
            List<Cliente> clientes = this.tabla.ExecuteQuery(query).Where(x => x.Empresa == empresa).ToList();
            return clientes;
        }

        public List<Cliente> GetClientes()
        {
            TableQuery<Cliente> query = new TableQuery<Cliente>();
            List<Cliente> clientes = this.tabla.ExecuteQuery(query).ToList();
            return clientes;
        }
    }
}