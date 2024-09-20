//Escreva um programa que leia o nome e o preço de 10 produtos. Logo após realizar o cadastro dos produtos, pedir para o usuário digitar um valor, no qual deverá ser realizada uma pesquisa e exibir apenas os produtos que possuem preço até o valor digitado pelo usuário.

using System;



class Vetor{

    static double[] LerValor(double[] valores){
        

        for (int i=0; i < valores.Length ; i++){
            Console.WriteLine($"Digite um Valor :     | {i+1,4} / {valores.Length}");
            valores[i] = Convert.ToDouble(Console.ReadLine());

        }
        return valores;

    }
    static double LerValorUsuario(){
        
        Console.WriteLine($"Digite um Valor A Ser Pesquisado :  ");
        return Convert.ToDouble(Console.ReadLine());

    }
    static void Pesquisa(double valor , double[] produtos){
        
        for(int i = 0 ; i < produtos.Length ; i++){
            if(produtos[i] == valor) Console.WriteLine($"Produtos Encontrados : {produtos[i]}");
                
        }

    }


    static void Main(string[] args){


        double [] produtos = new double[10];
        
        LerValor(produtos);
        double valorpesquisa = LerValorUsuario();
        Pesquisa(valorpesquisa , produtos);


    }
 




}