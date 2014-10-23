using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imp
{
    public partial class frmImpedimentoVisor : Form
    {
        public frmImpedimentoVisor()
        {
            InitializeComponent();
        }
        Posicao p = new Posicao();//Define 'p' como nome da classe onde estão nossas variaveis
        public void TMAtualiza_Tick(object sender, EventArgs e)//Componente 'Timer', atualiza-se a cada 't' segundos
        {   //Definir limite da bola
            p.Bxf = 594;
            p.Bxi = 111;
            p.Byf = 552;
            p.Byi = 123;
            p.BxN1 = 115;
            p.BxN2 = 590;
            p.ByN1 = 126;
            p.ByN2 = 549;
            //Movimento bola
            p.BMOV = 200 / p.CompC;
            //Definir movimento dos jogadores
            p.MOVx = 400/p.LargC;
            p.MOVy = 400/p.CompC;
            //Definir limite dos jogadores
            p.PxiAtk = 125;
            p.PxiDef = 125;
            p.PyiAtk = 133;
            p.PyiDef = 133;
            p.PFxAtk = 576;
            p.PFxDef = 576;
            p.PFyAtk = 533;
            p.PFyDef = 533;
            //Indicadores
            p.IndYatk = ((p.PyAtk - p.PyiAtk)/p.MOVy);//((posição atacante[Y] - Inicio do campo[Y])/Movimento[Y])
            p.IndYdef = ((p.PyDef - p.PyiDef) / p.MOVy);//((posição defensor[Y] - Inicio do campo[Y])/Movimento[Y])
            p.Area = (p.LargC * p.CompC);
            //Parametros
            lblCComp.Text = p.CompC.ToString();
            lblCLarg.Text = p.LargC.ToString();
            lblDAtk.Text = p.IndYatk.ToString();
            lblDDef.Text = p.IndYdef.ToString();
            //Posição atual
            PBoxP1.Location = new Point((p.PxAtk), (p.PyAtk));//((Posição atacante[X]),(Posição atacante[Y]))
            PBoxP2.Location = new Point((p.PxDef), (p.PyDef));//((Posição defensor[X]),(Posição defensor[Y]))
            PBoxBola.Location = new Point(p.Bx, p.By);//((Posição bola[X]),(Posição bola[Y]))
            lblCArea.Text = p.Area.ToString();
            //Impedimento
            p.DisAtk = (p.CompC - p.PyAtk);//Distancia Atacante = (Comprimento do campo - posição atacante)
            p.DisDef = (p.CompC - p.PyDef);//Distancia defensor = (Comprimento do campo - posição defensor)
            //Fora do campo eixo X
            if ((p.Bx == p.Bxi) || (p.Bx == p.Bxf))//((Posição bola[X] = Limite inicial do campo[X]) ou (Posição bola[X] = Limite final do campo[X]))
            {
                PBoxStatus.Image = Imp.Properties.Resources.titlenot;
            }
            //Fora do campo eixo Y
            if ((p.By == p.Byi) || (p.By == p.Byf))//((Posição bola[Y] = Limite inicial do campo[Y]) ou (Posição bola[Y] = Limite final do campo[Y]))
            {
                PBoxStatus.Image = Imp.Properties.Resources.titlenot;
            }
            //Função Impedimento
            if (((p.Bx >= p.BxN1) && (p.Bx <= p.BxN2)) && ((p.By >= p.ByN1) && (p.By <= p.ByN2)))
            {

                if ((p.PyDef - p.PyiDef) / p.MOVy <= 50)//((Posição defensor - limite inicial)/ Movimento[Y] <= 50m)
                {
                    if (p.DisAtk > p.DisDef)//(Distacia atacante > Distancia defensor)
                    {
                        PBoxStatus.Image = Imp.Properties.Resources.titleImp;
                    }
                    if (p.DisAtk <= p.DisDef)//(Distacia atacante <= Distancia defensor)
                    {
                        PBoxStatus.Image = Imp.Properties.Resources.titlenot;
                    }
                }
                if (((p.PyAtk - p.PyiAtk) / p.MOVy) >= 50)//((Posição atacante - limite inicial)/ Movimento[Y] >= 50m)
                {
                    PBoxStatus.Image = Imp.Properties.Resources.titlenot;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImpedimentoVisor_KeyDown(object sender, KeyEventArgs e)
        {
            //Verificar que teclas estão sendo utilizadas
            //Movimento horizontal
            if ((p.PxAtk >= p.PxiAtk) && (p.PxAtk <= p.PFxAtk) && (p.PxDef >= p.PxiDef) && (p.PxDef <= p.PFxDef))
            {
                if (e.KeyValue == 37)//Esquerda
                {
                    p.PxAtk = p.PxAtk - p.MOVy;
                }
                if (e.KeyValue == 39)//Direita
                {
                    p.PxAtk = p.PxAtk + p.MOVy;
                }
                if (e.KeyValue == 65)//A
                {
                    p.PxDef = p.PxDef - p.MOVy;
                }
                if (e.KeyValue == 68)//D
                {
                    p.PxDef = p.PxDef + p.MOVy;
                }
            }
            //Correção
            if (p.PxAtk < p.PxiAtk)
            {
                p.PxAtk = p.PxiAtk;
            }
            if (p.PxDef < p.PxiDef)
            {
                p.PxDef = p.PxiDef;
            }
            if (p.PxAtk > p.PFxAtk)
            {
                p.PxAtk = p.PFxAtk;
            }
            if (p.PxDef > p.PFxDef)
            {
                p.PxDef = p.PFxDef;
            }
            //Movimento vertical
            if ((p.PyAtk >= p.PyiAtk) && (p.PyAtk <= p.PFyAtk) && (p.PyDef >= p.PyiDef) && (p.PyDef <= p.PFyDef))
            {
                if (e.KeyValue == 38)//Cima
                {
                    p.PyAtk = p.PyAtk - p.MOVy;
                }
                if (e.KeyValue == 40)//Baixo
                {
                    p.PyAtk = p.PyAtk + p.MOVy;
                }
                if (e.KeyValue == 87)//W
                {
                    p.PyDef = p.PyDef - p.MOVy;
                }
                if (e.KeyValue == 83)//S
                {
                    p.PyDef = p.PyDef + p.MOVy;
                }
            }
            //Correção
            if (p.PyAtk < p.PyiAtk)
            {
                p.PyAtk = p.PyiAtk;
            }
            if (p.PyDef < p.PyiDef)
            {
                p.PyDef = p.PyiDef;
            }
            if (p.PyAtk > p.PFyAtk)
            {
                p.PyAtk = p.PFyAtk;
            }
            if (p.PyDef > p.PFyDef)
            {
                p.PyDef = p.PFyDef;
            }
            //Bola x
            if ((p.Bx >= p.Bxi) && (p.Bx <= p.Bxf))
            {
                if (e.KeyValue == 85)//U
                {
                    p.Bx = p.Bx - p.BMOV;
                }
                if (e.KeyValue == 73)//I
                {
                    p.Bx = p.Bx + p.BMOV;
                }
            }
            //Correção
            if (p.Bx < p.Bxi)
            {
                p.Bx = p.Bxi;
            }
            if (p.Bx > p.Bxf)
            {
                p.Bx = p.Bxf;
            }
            //Bola y
            if ((p.By >= p.Byi) && (p.By <= p.Byf))
            {
                if (e.KeyValue == 79)//O
                {
                    p.By = p.By - p.BMOV;
                }
                if (e.KeyValue == 80)//P
                {
                    p.By = p.By + p.BMOV;
                }
            }
            //Correção
            if (p.By < p.Byi)
            {
                p.By = p.Byi;
            }
            if (p.By > p.Byf)
            {
                p.By = p.Byf;
            }
        }

        private void lblCLarg_Click(object sender, EventArgs e)
        {
            txtLargura.Visible = true;
            txtLargura.Enabled = true;
            txtLargura.Focus();
        }

        private void lblCComp_Click(object sender, EventArgs e)
        {
            txtComprimento.Visible = true;
            txtComprimento.Enabled = true;
            txtComprimento.Focus();
        }

        private void txtLargura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                p.LargC = int.Parse(txtLargura.Text);
                
                if ((p.LargC >= 50) && (p.LargC <= 90))
                {
                    txtLargura.Visible = false;
                    txtLargura.Enabled = false;
                }
                if (p.LargC < 50)
                {
                    lblTxtVisor.Visible = true;
                    lblTxtVisor.Enabled = true;
                    txtLargura.Enabled = false;
                    lblTxtVisor.Text = "A largura de um campo não pode ser menor que 50 metros.";                   
                }
                if (p.LargC > 90)
                {
                    lblTxtVisor.Visible = true;
                    lblTxtVisor.Enabled = true;
                    txtLargura.Enabled = false;
                    lblTxtVisor.Text = "A largura de um campo não pode ser maior que 90 metros.";
                }
            }
        }

        private void txtComprimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                p.CompC = int.Parse(txtComprimento.Text);
                if ((p.CompC >= 90) && (p.CompC <= 120))
                {
                    txtComprimento.Visible = false;
                    txtComprimento.Enabled = false;    
                }
                if (p.CompC < 90)
                {
                    lblTxtVisor.Visible = true;
                    lblTxtVisor.Enabled = true;
                    txtComprimento.Enabled = false;
                    lblTxtVisor.Text = "O comprimento de um campo não pode ser menor que 90 metros.";
                }
                if (p.CompC > 120)
                {
                    lblTxtVisor.Visible = true;
                    lblTxtVisor.Enabled = true;
                    txtComprimento.Enabled = false;
                    lblTxtVisor.Text = "O comprimento de um campo não pode ser maior que 120 metros.";
                }
            }
        }

        private void lblTxtVisor_Click(object sender, EventArgs e)
        {
            if (lblTxtVisor.Text == "A largura de um campo não pode ser menor que 50 metros.")
            {
                txtLargura.Text = "50";
                txtLargura.Enabled = true;
                txtLargura.Focus();
            }
            if (lblTxtVisor.Text == "A largura de um campo não pode ser maior que 90 metros.")
            {
                txtLargura.Text = "90";
                txtLargura.Enabled = true;
                txtLargura.Focus();
            }
            if (lblTxtVisor.Text == "O comprimento de um campo não pode ser menor que 90 metros.")
            {
                txtComprimento.Text = "90";
                txtComprimento.Enabled = true;
                txtComprimento.Focus();
            }
            if (lblTxtVisor.Text == "O comprimento de um campo não pode ser maior que 120 metros.")
            {
                txtComprimento.Text = "120";
                txtComprimento.Enabled = true;
                txtComprimento.Focus();
            }
            lblTxtVisor.Visible = false;
            lblTxtVisor.Enabled = false;
        }
    }
}
