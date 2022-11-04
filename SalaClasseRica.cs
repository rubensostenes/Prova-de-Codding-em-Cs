public class SalaClasseRica{

    public SalaClasseRica(int cadeirasConfort, string cartaz, int andarShopping, string comidas) 
    {
        cadeirasConfort = cadeirasConfort;
        cartaz = cartaz;
        comidas = comidas;
        andarShopping = andarShopping;
   
    }
    
    public int cadeirasConfort{get; set;}
    public int andarShopping{get; set;}
    public string cartaz{get; set;}
    public string comidas{get; set;}

    public void Andar(SalaClasseRica A){
        Console.WriLine("As cadeiras da Rica é melhor que existe no cinema...");
    }

    public virtual void desfrutar(SalaClasseRica A){
        Console.WriteLine("é muto bom sair em familia...");
    }
}