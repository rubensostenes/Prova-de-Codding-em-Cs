public class SalaPadrao{

    public int qtdCadeiras{get; set;}
    public int numero{get; set;}
    public string localizacao{get; set;}


    public SalaPadrao(int qtdCadeiras, string localizacao, int numero) 
    {
        qtdCadeiras = qtdCadeiras;
        localizacao = localizacao;
        numero = numero;
    
    }

    public virtual void Sentar(SalaPadrao A){
        Console.WriteLine("É hOrrivel as cadeiras da padrao...");
    }

    public virtual void comer(SalaPadrao A){
        Console.WriteLine("é ate bom a comida da padrao...");
    }
}   