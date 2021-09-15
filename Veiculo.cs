using System;
using System.Collections.Generic;

class Veiculo {

  public string cor {get ; protected set;}
  public string marca{get ; protected set;}
  public string modelo{get ; protected set;}
  public double valor{get ; protected set;}
  public string anoFabri{get ; protected set;}
  public double custo_Fixo{get ; protected set;}

  //Construtor Completo
  public Veiculo (string cr,string ma,string mod,double vl, string aF, double cF ){

    cor = cr;
    marca = ma;
    modelo = mod;
    valor = vl;
    anoFabri = aF;
    custo_Fixo = cF;
  }
  
  protected virtual void definirValorVeiculo (double  CustoFixo){

    this.valor = CustoFixo;

  }

  //Mudar atributos
  public void mudarAtributos(string cr, string vl,double c){
    cor = cr;
    valor = vl;
    custo_Fixo = c;
  }

   public void mudarAtributos(string cr, string vl,double c,string ano){
    cor = cr;
    valor = vl;
    custo_Fixo = c;
    anoFabri = ano;
  }

  
}