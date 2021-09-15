using System;

class Nacional:Veiculo {

  protected override void definirValorVeiculo (double  CustoFixo){
      valor = CustoFixo * 1.5 + 0.2*CustoFixo + CustoFixo/10;
  }
  
}