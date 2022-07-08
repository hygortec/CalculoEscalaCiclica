using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoEscalaSiclica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool resuldado = VerificaSeTrabalhaNaDataAtual(Convert.ToDateTime(txtDataBase.Text), Convert.ToDateTime(txtDataAtual.Text), Convert.ToInt32(txtTrabalha.Text),
                Convert.ToInt32(txtFolga.Text), true);
            if (resuldado)
                lbnStatus.Text = "Status: Trabalha";
            else
                lbnStatus.Text = "Status: Folga";

        }

        public bool VerificaSeTrabalhaNaDataAtual(DateTime _dataBase, DateTime _dataAtual, int _diasTrabalho, int _diasFolga, bool _iniciaTrabalhando)
        {
            try
            {
                _dataBase = _dataBase.AddDays(-1);
                int tamanhoEscala = _diasTrabalho + _diasFolga;
                int qtdDias = _dataAtual.Subtract(_dataBase).Days;
                int qtdEscalas = qtdDias / tamanhoEscala;

                if (qtdEscalas == 0)//Se não for uma divisão inteira então quer dizer que ele não completeu sua escala
                {
                    DateTime ultimoDiaTrabalhoEscala = _dataBase.AddDays(_diasTrabalho);

                    if (_dataAtual <= ultimoDiaTrabalhoEscala)
                        return true;
                    //else if (ultimoDiaTrabalhoEscala.AddDays(_diasFolga) <= _dataAtual)
                    //    return true;
                    else
                        return false;
                }

                int qtdDiasTrabalhados = qtdEscalas * tamanhoEscala;
                DateTime dataParametro = _dataBase.AddDays(qtdDiasTrabalhados);

                if (dataParametro <= _dataAtual)
                {
                    DateTime ultimoDiaTrabalhoEscala = dataParametro.AddDays(-_diasFolga);
                    if (_dataAtual <= ultimoDiaTrabalhoEscala)
                        return true;
                    else if (_dataAtual > dataParametro)
                    {
                        if (_dataAtual <= dataParametro.AddDays(_diasTrabalho))
                            return true;
                        else
                            return false;
                    }                        
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtTrabalha_Leave(object sender, EventArgs e)
        {
            lbnStatus.Text = "Status:";
        }

        private void txtFolga_Leave(object sender, EventArgs e)
        {
            txtTrabalha_Leave(null, null);
        }

        private void txtDataBase_Leave(object sender, EventArgs e)
        {
            txtTrabalha_Leave(null, null);
        }

        private void txtDataAtual_Leave(object sender, EventArgs e)
        {
            txtTrabalha_Leave(null, null);
        }

        private void btnAddDia_Click(object sender, EventArgs e)
        {
            txtDataAtual.Text = Convert.ToDateTime(txtDataAtual.Text).AddDays(1).ToString();
            btnCalcular_Click(null, null);
        }
    }
}
