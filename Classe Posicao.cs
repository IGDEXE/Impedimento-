using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imp
{
    class Posicao
    {
        //Posição dos jogadores no campo
        public int PxAtk = 150, //Posição eixo X jogador de ataque  
                   PxDef = 250,//Posição eixo X jogador de defesa
                   PyAtk = 200,//Posição eixo Y jogador de ataque
                   PyDef = 150,//Posição eixo Y jogador de defesa
                   PxiAtk,//Posição limite inicial eixo X jogador de ataque
                   PxiDef,//Posição limite inicial eixo X jogador de defesa
                   PyiAtk,//Posição limite inicial eixo Y jogador de ataque
                   PyiDef;//Posição limite inicial eixo Y jogador de defesa
        //Tamanho jogador
        public int PFxAtk = 0,//Posição final eixo X jogador de ataque
                   PFxDef = 0,//Posição final eixo X jogador de defesa
                   PFyAtk = 0,//Posição final eixo Y jogador de ataque
                   PFyDef = 0;//Posição final eixo Y jogador de defesa
        //Tamanho do campo
        public int CompC = 100,//Comprimento campo
                   LargC = 60;//Largura campo
        //Movimentação jogador
        public int MOVy,//Movimento eixo Y
                   MOVx;//Movimento eixo X
        //Indicadores
        public int IndYatk,//Indicador (em estimativa de metros) da distância (da linha de fundo) do jogador de ataque
                   IndYdef,//Indicador (em estimativa de metros) da distância (da linha de fundo) do jogador de defesa
                   Area,//Área do campo
                   DisAtk,//Distancia da linha de fundo, jogador de ataque
                   DisDef;//Distancia da linha de fundo, jogador de defesa
        //Bola
        public int Bx = 300,//Posição bola no eixo X
                   By = 400,//Posição bola no eixo Y
                   Bxf,//Posição limite final no eixo X
                   Byf,//Posição limite final no eixo Y
                   Bxi,//Posição limite inicial no eixo X
                   Byi,//Posição limite inicial no eixo Y
                   BMOV;//Movimento bola
        //Definir limite bola
        public int BxN1,//Posição do início do campo para a bola no eixo X
                   BxN2,//Posição do final do campo para a bola no eixo X
                   ByN1,//Posição do início do campo para a bola no eixo Y
                   ByN2;//Posição do final do campo para a bola no eixo Y
    }
}
