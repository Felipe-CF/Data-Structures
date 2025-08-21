public class Aresta{
    protected Object rotulo;
    protected Vertice vertice_in;
    protected Vertice vertice_out;

    public int peso;
    

    public Aresta(Object r){
        rotulo = r;
        vertice_in = vertice_out = null;
    }
    public Aresta(Vertice v1, Vertice v2, Object r){
        rotulo = r;
        vertice_in = v2;
        vertice_out = v1;
    }
    public Vertice verticeIn(){
        return vertice_in;
    }
    public Vertice verticeOut(){
        return vertice_out;
    }

    public string getRotulo() {
        return rotulo.ToString();
    }
    public void setRotulo(Object r) {
        rotulo = r;
    }

    public void setVerticeIn(Vertice v) {
        vertice_in = v;
    }
    public void setVerticeOut(Vertice v) {
        vertice_out = v;
    }

    public bool seIncide(Vertice v) {
        if (Object.ReferenceEquals(v ,vertice_in) || Object.ReferenceEquals(v ,vertice_out))
            return true;
        
        return false;
        
    }

    
    public List<Vertice> vertices(){
        if (vertice_in == null)
            return null;

        List<Vertice> vertices = new List<Vertice>();

        vertices.Add(vertice_in);

        vertices.Add(vertice_out);

        return vertices;
    }
    public override string ToString() {
        return $"{vertice_out} - {rotulo.ToString()} - {vertice_in}";
    }
}


