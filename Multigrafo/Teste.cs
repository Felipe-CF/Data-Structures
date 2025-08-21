using System;
using System.Collections;
using System.Collections.Generic;
namespace Multigrafo;

class Teste
{
    static void Main(string[] args)
    {
        Grafo grafo = new Grafo();

        Vertice v1 = grafo.inserirVertice(1);
        Vertice v2 = grafo.inserirVertice(2);
        Vertice v3 = grafo.inserirVertice(3);
        Vertice v4 = grafo.inserirVertice(4);
        Vertice v5 = grafo.inserirVertice(5);
        Vertice v6 = grafo.inserirVertice(6);


        Aresta a1 = grafo.inserirAresta(v1, v2, 7, 7);
        Aresta a2 = grafo.inserirAresta(v2, v3, 5, 5);
        Aresta a3 = grafo.inserirAresta(v3, v5, 2, 2);
        Aresta a4 = grafo.inserirAresta(v3, v4, 8, 8);
        Aresta a5 = grafo.inserirAresta(v4, v5, 2, 2);
        Aresta a6 = grafo.inserirAresta(v6, v1, 8, 8);
        Aresta a7 = grafo.inserirAresta(v2, v6, 3, 3);
        Aresta a8 = grafo.inserirAresta(v6, v3, 6, 6);
        Aresta a9 = grafo.inserirAresta(v6, v5, 3, 3);


        List<Aresta> arestas = Kruskal.arvoreGeradoraMinima(grafo);

        int i = 0;

    }
}
