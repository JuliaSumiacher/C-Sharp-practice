using System.Threading.Tasks;

/*Análogamente a lo visto en este módulo. 
 * crea los métodos clases y propiedades , 
 * para crear el código lo mas asincronamente posible,  
 * que ponga como ejemplo hacer una receta de cocina
*/

namespace programacion_asincrona
{
    public class Papas { }

    public class Huevos { }

    public class Tortilla { }

    class Program
    {
        static async Task Main(string[] args)
        {
            Task<Papas> papasTask = FreirPapas(3);
            
            Huevos huevos = BatirHuevos(2);
            Console.WriteLine("Huevos listos");

            Papas papas = await papasTask;
            Console.WriteLine("Papas listas");

            Tortilla tortilla = await Cocinar(papas, huevos);
            Console.WriteLine("Tortilla cocinándose...");

            tortilla = DarVuelta(tortilla);
            Console.WriteLine("Tortilla lista");


        }

        public static Huevos BatirHuevos(int numHuevos)
        { 
            return new Huevos();
        }

        public static async Task<Papas> FreirPapas(int kgPapas)
        {
            return new Papas();
        }

        public static async Task<Tortilla> Cocinar(Papas papas, Huevos huevos)
        {
            return new Tortilla();
        }

        public static Tortilla DarVuelta(Tortilla tortilla)
        {
            return new Tortilla();
        }


    }

}
