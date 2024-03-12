public interface Seguro
    {
        void seguroParticular();
    }

    public class SeguroCarro : Seguro
    {
        public void seguroParticular()
        {
            Console.WriteLine("Seguro específico para carros");
        }
    }