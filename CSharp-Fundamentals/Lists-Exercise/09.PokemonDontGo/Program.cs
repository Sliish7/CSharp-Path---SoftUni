namespace _09.PokemonDontGo
{
    internal class Program
    {
        static void Main()
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int result = 0;

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int currValue = 0;

                if (index < 0)
                {
                    index = 0;
                    currValue = pokemons[index];
                    result += pokemons[index];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if (index > pokemons.Count - 1)
                {
                    index = pokemons.Count - 1;
                    currValue = pokemons[index];
                    result += pokemons[index];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    currValue = pokemons[index];
                    result += pokemons[index];
                    pokemons.RemoveAt(index);
                }

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= currValue)
                    {
                        pokemons[i] += currValue;
                    }
                    else
                        pokemons[i] -= currValue;
                }
            }
            Console.WriteLine(result);
        }
    }
}