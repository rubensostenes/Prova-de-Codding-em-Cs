public class SalaClasseMedia: SalaPadrao{

    public SalaClasseMedia(int andarShopping, int numero, int qtdCadeiras) 
    {
    
        andarShopping = andarShopping;
        numero = numero;
        qtdCadeiras = qtdCadeiras;
   
    }

    public int andarShopping{get; set;}
    public int qtdCadeiras{get; set;}
    public int numero{get; set;}

    public override void Sentar(SalaClasseMedia A){
        base.Sentar();
        Console.WriLine("Sentar nas cadeiras da Meda é melhor que as da Padrao...");
    }


}