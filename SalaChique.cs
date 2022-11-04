public class SalaChique{

    public int andarShopping{get; set;}
     public string comidas{get; set;}
    public string cartaz{get; set;}



    public SalaChique(int andarShopping, string comidas, string cartaz) 
    {
        andarShopping = andarShopping;
        comidas = comidas;
        cartaz = cartaz;
   
    }

    public override void Deitar(SalaChique A){
        Console.WriLine("Deitar aqui é ótimo...");
    }

        public override void Deitar(SalaChique B){
        Console.WriLine("Deitar aqui é ótimo...");
    }
}