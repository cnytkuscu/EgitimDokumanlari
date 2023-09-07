namespace AsenkronikMimari
{
    public class AsenkronikMimari
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Carp(int sayi1, int sayi2)
        {
            Thread.Sleep(10000);
            Console.WriteLine($"Carpim : {sayi1 * sayi2}");
        }

        public Task<int> CarpAsync(int sayi1, int sayi2)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                return sayi1 * sayi2;
            });
        }
    }

}