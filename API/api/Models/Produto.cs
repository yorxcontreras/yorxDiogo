namespace api.Models;

public class Produto
{

    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }

    public string? Id {get; set;}
    public string? Nome {get; set;}
    public double Preco {get; set;}

    public int Quantidade {get; set;}

    public DateTime CriadoEm { get; set; }

    // private double preco;

    // public double getPreco()
    // {
    //     return preco;
    // }
    // public void setPreco(double preco){
    //     this.preco = preco * 3;
    // }
}
