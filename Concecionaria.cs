using System;
using System.Collections.Generic;

class Concecionaria:Veiculo {

  public string localização;
  public string gerente;
  public string ano;
  public string anoFundacao;
  public int carDisponiveis;
  
  List <Veiculo> carroDisponiveis = new List<Veiculo>();


  //Construtor Completo
  public Concecionaria(string loc,string ger,string a,string anoF,int carD){

    localização = loc;
    gerente = ger;
    ano = a;
    anoFundacao = anoF; 
    carDisponiveis = carD;
  }

  public void AdicionarCarro(Veiculo x){
    carroDisponiveis.Add(x);   
  }

  public void CalcularPortfolio (){
    for (int i = 0; i < carroDisponiveis.Count; i++)
        {
            valor += carroDisponiveis[i].valor;
    }
  }



}