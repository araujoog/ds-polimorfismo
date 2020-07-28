using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPolimorfismo
{
        abstract class empregado
        {
            private string Nome;
            private string Sobrenome;
            private string CPF;

            public void setNome(string Nome)
            {
                this.Nome = Nome;
            }
            public string getNome()
            {
                return this.Nome;
            }

            public void setSobrenome(string Sobrenome)
            {
                this.Sobrenome = Sobrenome;
            }
            public string getSobrenome()
            {
                return this.Sobrenome;
            }

            public void setCPF(string CPF)
            {
                this.CPF = CPF;
            }
            public string getCPF()
            {
                return this.CPF;
            }

            public virtual double vencimento(double valor)
            {
                valor = 0;
                return valor;
            }
        }

        class assalariado : empregado {
            private double Salario;

            public void setSalario(double Salario)
            {
                this.Salario = Salario;
            }
            public double getSalario()
            {
                return this.Salario;
            }

            public override double vencimento(double valor)
            {
                valor = 1000;
                return valor;
            }
        }

        class comissionado : empregado {
            private double TotalVenda;
            private double taxaComissao;

            public void setTotalVenda(double TotalVenda)
            {
                this.TotalVenda = TotalVenda;
            }
            public double getTotalVenda()
            {
                return this.TotalVenda;
            }

            public void setTaxaComissao(double taxaComissao)
            {
                this.taxaComissao = taxaComissao;
            }
            public double getTaxaComissao()
            {
                return this.taxaComissao;
            }

            public override double vencimento(double valor)
            {
                valor = 100;
                return valor;
            }
        }

        class horista : empregado {
            private double precoHora;
            private double horasTrabalhadas;

            public void setPrecoHora(double precoHora)
            {
                this.precoHora = precoHora;
            }
            public double getPrecoHora()
            {
                return this.precoHora;
            }

            public void setHorasTrabalhadas(double horasTrabalhadas)
            {
                this.horasTrabalhadas = horasTrabalhadas;
            }
            public double getHorasTrabalhadas()
            {
                return this.horasTrabalhadas;
            }

            public override double vencimento(double valor)
            {
                valor = 10;
                return valor;
            }
        }
}
