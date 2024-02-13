using System;


class Empleado
{
   
    public string? Nombre { get; set; }
    public decimal Salario { get; set; }
    

    
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Salario: {Salario}");
        
    }
}


class Gerente : Empleado
{
   
    public string? Cargo { get; set; }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Cargo: {Cargo}");
    }
}


class Trabajador : Empleado
{
    
    public string? Departamento { get; set; }

   
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Tipo de trabajo: {Departamento}");
    }
}

class Program
{
    static void Main()
    {
        
      

        Gerente gerente = new Gerente
        {
            Nombre = "Ana Gómez",
            Salario = 80000,
            Cargo = "Gerente de Finanzas"
        };

        Trabajador trabajador = new Trabajador
        {
            Nombre = "Luis Rodríguez",
            Salario = 35000,
            Departamento = "Producción",
           
        };

        
        
        Console.WriteLine("\nInformación del gerente:");
        gerente.MostrarInformacion();

        Console.WriteLine("\nInformación del trabajador:");
        trabajador.MostrarInformacion();
    }
}

