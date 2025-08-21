using System;
using System.Collections.Generic;
namespace Multigrafo;

public class Kruskal{
    public static List<Aresta> arvoreGeradoraMinima(Grafo g){

        List<Aresta> arestas = g.GetArestas();

        arestas.Sort((a, b) => a.peso.CompareTo(b.peso)); // ordenar as arestas pelo peso

        Dictionary<Vertice, int> mapaVertices = new Dictionary<Vertice, int>(); // mapeio os vertices para referenciar o conjunto

        List<Vertice> vertices = g.getVertices();

        int i = 0;

        foreach(Vertice v in vertices) // cada vértice recebe um indice referente ao conjunto
            mapaVertices.Add(v, i++);

        List<int> conjuntoVertice = new List<int>(); // conjunto em que cada vértice faz parte
        List<int> conjuntoTamanho = new List<int>(); // tamanho de cada conjunto

        for(i = 0; i < vertices.Count; i++){
            conjuntoVertice.Add(i);
            conjuntoTamanho.Add(1);
        }

        List<Aresta> arvoreMinima = new List<Aresta>();

        foreach(Aresta aresta in arestas){
            Vertice a = aresta.verticeIn();

            Vertice b = aresta.verticeOut();

            int conjuntoA = mapaVertices[a];

            int conjuntoB = mapaVertices[b];

            if(conjuntoVertice[conjuntoA] != conjuntoVertice[conjuntoB]){
                if(conjuntoTamanho[conjuntoA] >= conjuntoTamanho[conjuntoB]){
                    conjuntoVertice[conjuntoB] = conjuntoVertice[conjuntoA];
                    conjuntoTamanho[conjuntoA]++;
                }
                else{
                    conjuntoVertice[conjuntoA] = conjuntoVertice[conjuntoB];
                    conjuntoTamanho[conjuntoB]++;
                }

                arvoreMinima.Add(aresta);
            }

            i = 3;

            
        }

        return arvoreMinima;
    }
}




