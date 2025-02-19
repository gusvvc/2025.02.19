namespace aula-03;

class Televisao

public Televisao(float tamanho)
{
    Tamanho = tamanho;

}
{
    //Get=permite seja executada a leitura do valor atual da porpriedade
    //set=permite que seja atribuido um valor para a propriedade
    
    //propriedades e metodos 

public float Tamanho { get; private set; } 

public int Resolucao { get; set; }

public int Volume { get; set; }

public int Canal { get; set; }

public bool Estado { get; set; }
}