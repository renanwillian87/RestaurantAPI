namespace Model
{
    public class Item : Base
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPorItem { get; set; }
        public int Quantidade { get; set; }
    }
}