

public class ComparadorPesoAresta: IComparer<Aresta>{
    public int Compare(Aresta a, Aresta b){

        int peso_a = int.Parse(a.getRotulo());

        int peso_b = int.Parse(b.getRotulo());

        return peso_a.CompareTo(peso_b);
    }
}