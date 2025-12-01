namespace PtccAsp.net.Models
{
    public class CadastroProduto
    {
        public int ?IdProduto { get; set; }  
        public string ?NomeProduto { get; set; }  
        public string ?Categoria { get; set; }
        public decimal Preco { get; set; }  
    }
}