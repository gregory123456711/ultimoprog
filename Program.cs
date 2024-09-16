using System;
using System.Collections.Generic;

class Gimnasio
{
    class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
    }

    static void Main(string[] args)
    {
        List<Cliente> clientes = new List<Cliente>();
        int opcion;

        do
        {
            Console.WriteLine("\n*** Registro de clientes del Gimnasio ***");
            Console.WriteLine("1. Dar de alta un cliente");
            Console.WriteLine("2. Mostrar detalles de un cliente");
            Console.WriteLine("3. Listar clientes");
            Console.WriteLine("4. Buscar cliente (Nombre)");
            Console.WriteLine("5. Dar de baja un cliente");
            Console.WriteLine("6. Modificar un cliente");
            Console.WriteLine("7. Salir");
            Console.Write("Selecciona una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    DarAltaCliente(clientes);
                    break;
                case 2:
                    MostrarDetallesCliente(clientes);
                    break;
                case 3:
                    ListarClientes(clientes);
                    break;
                case 4:
                    BuscarClientePorNombre(clientes);
                    break;
                case 5:
                    DarBajaCliente(clientes);
                    break;
                case 6:
                    ModificarCliente(clientes);
                    break;
                case 7:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida, intenta de nuevo.");
                    break;
            }
        } while (opcion != 7);
    }

    static void DarAltaCliente(List<Cliente> clientes)
    {
        Cliente nuevoCliente = new Cliente();
        Console.Write("Ingresa el ID del cliente: ");
        nuevoCliente.ID = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el nombre del cliente: ");
        nuevoCliente.Nombre = Console.ReadLine();
        Console.Write("Ingresa la edad del cliente: ");
        nuevoCliente.Edad = int.Parse(Console.ReadLine());
        Console.Write("Ingresa el teléfono del cliente: ");
        nuevoCliente.Telefono = Console.ReadLine();

        clientes.Add(nuevoCliente);
        Console.WriteLine("Cliente agregado exitosamente.");
    }

    static void MostrarDetallesCliente(List<Cliente> clientes)
    {
        Console.Write("Ingresa el ID del cliente: ");
        int id = int.Parse(Console.ReadLine());
        Cliente cliente = clientes.Find(c => c.ID == id);

        if (cliente != null)
        {
            Console.WriteLine($"\nDetalles del cliente {cliente.ID}:");
            Console.WriteLine($"Nombre: {cliente.Nombre}");
            Console.WriteLine($"Edad: {cliente.Edad}");
            Console.WriteLine($"Teléfono: {cliente.Telefono}");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    static void ListarClientes(List<Cliente> clientes)
    {
        Console.WriteLine("\nLista de clientes:");
        foreach (Cliente cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.ID}, Nombre: {cliente.Nombre}, Edad: {cliente.Edad}, Teléfono: {cliente.Telefono}");
        }
    }

    static void BuscarClientePorNombre(List<Cliente> clientes)
    {
        Console.Write("Ingresa el nombre del cliente: ");
        string nombre = Console.ReadLine();
        Cliente cliente = clientes.Find(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

        if (cliente != null)
        {
            Console.WriteLine($"\nDetalles del cliente {cliente.ID}:");
            Console.WriteLine($"Nombre: {cliente.Nombre}");
            Console.WriteLine($"Edad: {cliente.Edad}");
            Console.WriteLine($"Teléfono: {cliente.Telefono}");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    static void DarBajaCliente(List<Cliente> clientes)
    {
        Console.Write("Ingresa el ID del cliente a eliminar: ");
        int id = int.Parse(Console.ReadLine());
        Cliente cliente = clientes.Find(c => c.ID == id);

        if (cliente != null)
        {
            clientes.Remove(cliente);
            Console.WriteLine("Cliente eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    static void ModificarCliente(List<Cliente> clientes)
    {
        Console.Write("Ingresa el ID del cliente a modificar: ");
        int id = int.Parse(Console.ReadLine());
        Cliente cliente = clientes.Find(c => c.ID == id);

        if (cliente != null)
        {
            Console.Write("Ingresa el nuevo nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.Write("Ingresa la nueva edad del cliente: ");
            cliente.Edad = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el nuevo teléfono del cliente: ");
            cliente.Telefono = Console.ReadLine();

            Console.WriteLine("Cliente modificado exitosamente.");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }
}
