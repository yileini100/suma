// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

        // Solicitar al usuario la cantidad de números a ingresar
        Console.WriteLine("Ingrese la cantidad de números a evaluar:");
        int n = Convert.ToInt32(Console.ReadLine());

        // Declarar un array para almacenar los números
        int[] numeros = new int[n];

        // Leer los números y almacenarlos en el array
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Ingrese el número " + (i + 1) + ":");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calcular la sumatoria de los números
        int sumatoria = 0;
        foreach (int numero in numeros)
        {
            sumatoria += numero;
        }


        if (sumatoria >= 100)
        {
            Console.WriteLine("La sumatoria es mayor o igual a 100.");
        }
    

