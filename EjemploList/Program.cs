namespace EjemploList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<String> listaPersonas;
            listaPersonas = new List<string>();

            Console.WriteLine($"Capacidad: {listaPersonas.Capacity} ");
            Console.WriteLine("La lista esta vacia. Todavia no se han agreagado parametros");
            

            //Adicion De 3 Elementos en la lista
            listaPersonas.Add( "Pedro" );
            listaPersonas.Add("Alex");
            listaPersonas.Add("Ana");
            
            Console.WriteLine("\nCapacidad:" + listaPersonas.Capacity );
            Console.WriteLine("numElementos:" + listaPersonas.Count);

            //Mostrar el contenido de la lista
            //Console.WriteLine("\nMostramos el contenido de la lista");


            //FOR
            //for (int i = 0; i < listaPersonas.Count; i++)
            //{
            //    Console.WriteLine(listaPersonas[i]);
            //}

            //FOR-EACH --> Para CADA 
            Console.WriteLine("\nCon FOREACH");
            //MostrarLista(listaPersonas);


            //Insertar una persona donde yo quiera, ya que con el ADD se añade al final

            listaPersonas.Insert(0, "Felipe");  //--> Inserto a Felipe en la primera posicion (0);
            listaPersonas.Insert(3, "Yolanda");
            MostrarLista(listaPersonas);

            //Actualizamos la vista a estos valores
            Console.WriteLine("\nCapacidad:" + listaPersonas.Capacity);
            Console.WriteLine("numElementos:" + listaPersonas.Count);

            listaPersonas.TrimExcess();//Limpieza de exceso de memoria 

            Console.WriteLine("\nLIMPIEZA DE EXCESO DE MEMORIA");
            Console.WriteLine("Capacidad:" + listaPersonas.Capacity);
            Console.WriteLine("numElementos:" + listaPersonas.Count);

            //Eliminamos a Ana
            Console.WriteLine("\nA la verga la ANA");
            listaPersonas.Remove("Ana");
            Console.WriteLine();
            MostrarLista(listaPersonas);
            Console.WriteLine("Capacidad:" + listaPersonas.Capacity);
            Console.WriteLine("numElementos:" + listaPersonas.Count);

            //Ordenar la lista 
            Console.WriteLine();
            Console.WriteLine("Ordenados");
            listaPersonas.Sort();//Ordenado ASCENDENTEMENTE
            MostrarLista(listaPersonas);

            //DARLE LA VUELTA A LA LISTA SEGUN COMO ESTE 
            Console.WriteLine();
            Console.WriteLine("Vuelta a la lista");
            listaPersonas.Reverse();
            MostrarLista(listaPersonas);



        }

        private static void MostrarLista(List<string> lista)
        {
            foreach (string persona in lista)
            //Para cada      persona en la listaPersonas
            {
                Console.WriteLine($"\t{persona}"); //-->Imprime por pantalla cada persona
            }
        }


    }
}