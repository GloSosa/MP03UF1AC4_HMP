internal class Program
{
    private static void Main(string[] args)
    {
        //EJERCICIO 1
        // int butacasL = 0;
        // int butacasO = 0;

        // int[][] salaCine = {
        //     new int[] {1,1,1},
        //     new int[] {1,0,1,1},
        //     new int[] {0,0,1,1,1},
        //     new int[] {1,1,1,1,1},
        //     new int[] {0,1,0,1,1},
        // };
        // for (int i = 0; i < 5; i++)
        // {
        //     for (int j = 0; j < salaCine[i].Length; j++)
        //     {
        //         if (salaCine[i][j] == 1)
        //         {
        //             butacasL++;
        //         }
        //         else
        //         {
        //             butacasO++;
        //         }
        //     }
        // }
        // Console.WriteLine("Butacas libres: " + butacasL);
        // Console.WriteLine("Butacas ocupados: " + butacasO);

        //Ejercicio 2
        // int habiDisp = 0;
        // bool bucle = true;
        // int reservaFil;
        // int reservaCol;

        // string[][] hotel = {
        //     new string[] {"O","X","X","X","X"},
        //     new string[] {"X","X","X","O","X"},
        //     new string[] {"X","X","X","X","X"},
        //     new string[] {"X","O","X","X","X"},
        //     new string[] {"X","X","X","X","X"},
        //     new string[] {"O","X","X","X","X"},
        //     new string[] {"X","O","X","X"},
        //     new string[] {"X","X","X"}
        // };

        // while (bucle == true)
        // {
        //     Console.WriteLine("Escribe un numero del 1-4: 1-Muestra habitaciones disponibles  2-Reservar habitaciones  3-Modificar o borrar reserva  4-Salir");
        //     int numero = int.Parse(Console.ReadLine());

        //     switch (numero)
        //     {
        //         case 1:
        //             habiDisp = 0;
        //             for (int i = 0; i < hotel.Length; i++)
        //             {
        //                 for (int j = 0; j < hotel[i].Length; j++)
        //                 {
        //                     if (hotel[i][j] == "O")
        //                         habiDisp++;
        //                 }
        //             }
        //             Console.WriteLine("Habitaciones libres: " + habiDisp);
        //             break;

        //         case 2:
        //             Console.WriteLine("Selecciona fila: ");
        //             reservaFil = Convert.ToInt32(Console.ReadLine());
        //             Console.WriteLine("Selecciona columna: ");
        //             reservaCol = Convert.ToInt32(Console.ReadLine());

        //             if (hotel[reservaFil][reservaCol] == "O")
        //             {
        //                 Console.WriteLine("La habitacion seleccionada esta disponible.");
        //                 hotel[reservaFil][reservaCol] = "X";
        //             }
        //             else
        //             {
        //                 Console.WriteLine("La habitacion seleccionada no esta disponible.");
        //             }
        //             break;

        //         case 3:
        //             Console.WriteLine("Modificar reserva: ");
        //             Console.WriteLine("1) Cambiar habitacion");
        //             Console.WriteLine("2) Cancelar reserva");
        //             int opcion = Convert.ToInt32(Console.ReadLine());

        //             if (opcion == 1)
        //             {
        //                 Console.WriteLine("Fila habitacion: ");
        //                 reservaFil = Convert.ToInt32(Console.ReadLine());
        //                 Console.WriteLine("Columna habitacion: ");
        //                 reservaCol = Convert.ToInt32(Console.ReadLine());
        //                 Console.WriteLine("Introduce una nueva fila: ");
        //                 int modFila = Convert.ToInt32(Console.ReadLine());
        //                 Console.WriteLine("Introduce una nueva columna: ");
        //                 int modColumna = Convert.ToInt32(Console.ReadLine());

        //                 if (hotel[reservaFil][reservaCol] == "X")
        //                 {
        //                     Console.WriteLine("La habitacion no está reservada.");
        //                 }
        //                 else
        //                 {
        //                     Console.WriteLine("Cambio realizado con éxito!");
        //                     hotel[reservaFil][reservaCol] = "X";
        //                     hotel[modFila][modColumna] = "O";
        //                 }
        //             }
        //             else if (opcion == 2)
        //             {
        //                 Console.WriteLine("Introduce la fila de la habitacion: ");
        //                 reservaFil = Convert.ToInt32(Console.ReadLine());
        //                 Console.WriteLine("Columna de tu habitacion: ");
        //                 reservaCol = Convert.ToInt32(Console.ReadLine());

        //                 if (hotel[reservaFil][reservaCol] == "O")
        //                 {
        //                     Console.WriteLine("Reserva cancelada.");
        //                     hotel[reservaFil][reservaCol] = "X";
        //                 }
        //                 else
        //                 {
        //                     Console.WriteLine("La habitación está libre.");
        //                 }
        //             }
        //             break;

        //         case 4:
        //             bucle = false;
        //             break;

        //         default:
        //             break;
        //     }
        // }
        //Ejercicio 3

        //         int[,] ventas = {
        // { 10, 5, 8, 12 },
        // { 7, 15, 20, 10 },
        // { 5, 3, 6, 8 },
        // { 12, 8, 10, 18 },
        // { 6, 10, 15, 7 }
        // };

        //         int totalVentas = 0;

        //         for (int i = 0; i < 5; i++)
        //         {
        //             for (int j = 0; j < 4; j++)
        //             {
        //                 totalVentas += ventas[i, j];
        //             }
        //         }

        //         Console.WriteLine("El valor total de las ventas es de: " + totalVentas);

        //         for (int i = 0; i < 5; i++)

        //         {
        //             int ventasXseccion = 0;

        //             for (int j = 0; j < 4; j++)
        //             {
        //                 ventasXseccion += ventas[i, j];
        //             }
        //             Console.WriteLine("Ventas en seccion " + (i + 1) + ": " + ventasXseccion);
        //         }

        bool[,] asistencia = {
{ true, false, true, true, false },
{ true, true, true, true, true },
{ false, false, true, true, false },
{ true, true, true, false, true },
{ true, false, true, false, true }
};

        int posEstudiante = 0;
        int diaSemana;

        Console.Write("Fila alumno: ");
        posEstudiante = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dia de la semana: ");
        diaSemana = Convert.ToInt32(Console.ReadLine());

        if (asistencia[posEstudiante, diaSemana] == true)
        {
            Console.WriteLine("Ese dia fue a clase");
        }
        else
        {
            Console.WriteLine("Ese dia no fue a clase.");
        }

    }
}

