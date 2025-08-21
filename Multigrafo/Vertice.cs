public class Vertice{
    protected List<Aresta> arestas_in;
    protected List<Aresta> arestas_out;
    protected List<Aresta> arestas;

    protected bool visitado;
    protected Object rotulo;

    public Vertice(Object r){
        rotulo = r;
        arestas_in = new List<Aresta>();
        arestas_out = new List<Aresta>();
        arestas = new List<Aresta>();
        visitado = false;
    }

    public Object getRotulo() {
        return rotulo;
    }

    public void setRotulo(Object r) {
        rotulo = r;
    }
    public bool getVisita() {
        return visitado;
    }
    public void setVisita() {
        visitado = true;
    }

    public List<Aresta> arestasIn(){
        return arestas_in;
    }

    public List<Aresta> arestasOut(){
        return arestas_out;
    }

    public List<Aresta> getArestas(){
        return arestas;
    }
    
    public void setAresta(Aresta a){
        arestas.Add(a);
    }

    public void setArestaIn(Aresta a){
        arestas_in.Add(a);
    }

    public void setArestaOut(Aresta a){
        arestas_out.Add(a);
    }

    public void removerAresta(Aresta a){

        if(a != null){
            
            if(arestas.Contains(a))
                arestas.Remove(a);
            
            else if(arestas_in.Contains(a))
                arestas_in.Remove(a);

            else if(arestas_out.Contains(a))
                arestas_out.Remove(a);
        }

    }

    public bool ehIncidente(Aresta a){
            
        if(arestas.Contains(a) || arestas_in.Contains(a) || arestas_out.Contains(a))
            return true;
        
        return false;

    }

    public bool seEhArestaIn(Aresta a){
            
        if(arestas_in.Contains(a))
            return true;
        
        return false;

    }

    public bool seEhArestaOut(Aresta a){
            
        if(arestas_out.Contains(a))
            return true;
        
        return false;

    }

    public bool seEhArestaSemDirecao(Aresta a){
            
        if(arestas.Contains(a))
            return true;
        
        return false;

    }

    public override string ToString() {
        
        return rotulo.ToString();
    }

}


