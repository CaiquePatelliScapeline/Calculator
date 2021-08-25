using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage {
        // Variaveis
        double num1, num2, resultado;
        int operac;
        string conta;
        bool verificaN1 = false;
        bool verificaN2 = false;
        bool pont = false;
        bool pontN1 = false;
        bool pontN2 = false;
        bool negativo = true;
        bool calculou = false;
        bool subtraiu = false;

        // Botão Limpar
        public void limpar(object sender, EventArgs e) {
            try {
                num1 = 0;
                num2 = 0;
                operac = 0;
                resultado = 0;
                verificaN1 = false;
                verificaN2 = false;
                pont = false;
                pontN1 = false;
                pontN2 = false;
                //negativo = false;
                calculou = false;
                subtraiu = false;
                conta = "";
                lblResultado.Text = "";
                lblResultadoTop.Text = "";
                lblResultadoBot.Text = "";
            } catch {
                Erro("Erro no botão Limpar");
            }

        }

        // Botão Calcular
        public void calcular(object sender, EventArgs e) {
            try {
                if ((verificaN1 == true) && (operac != 0) && (verificaN2 == true)) {
                    if (pont == true) {
                        conta = lblResultado.Text + "0";

                        Atualiza();
                    }

                    lblResultadoTop.Text = "";
                    lblResultado.Text = lblResultadoBot.Text;
                    lblResultadoBot.Text = "";

                    calculou = true;
                    operac = 0;
                    verificaN1 = true;
                    //negativo = false;
                    verificaN2 = false;
                    pontN1 = true;
                    pont = false;
                    pontN2 = false;
                    subtraiu = false;
                }
            } catch {
                Erro("Erro no botão Calcular");
            }
        }

        // Botões de Operação
        public void adicao(object sender, EventArgs e) {
            try {
                if (verificaN1 == true) {
                    Completar();

                    conta = lblResultado.Text + " + ";
                    operac = 1;

                    Atualiza();

                    lblResultadoTop.Text = lblResultado.Text;
                    lblResultado.Text = " ";

                    conta = "";
                }
            } catch {
                Erro("Erro nos botões de Operação");
            }
        }

        public void subtracao(object sender, EventArgs e) {
            try {
                if ((verificaN1 == true) && (subtraiu == false)) {
                    Completar();

                    conta = lblResultado.Text + " - ";
                    operac = 2;

                    Atualiza();

                    lblResultadoTop.Text = lblResultado.Text;
                    lblResultado.Text = "";

                    conta = "";
                    subtraiu = true;
                } else if ((negativo == false) || (calculou == true)) {
                    lblResultado.Text = "";
                    conta = lblResultado.Text + " - ";
                    lblResultado.Text = conta;

                    Atualiza();

                    negativo = true;
                    calculou = false;
                }
            } catch {
                Erro("Erro nos botões de Operação");
            }
        }

        public void multiplicacao(object sender, EventArgs e) {
            try {
                if (verificaN1 == true) {
                    Completar();

                    num1 = Convert.ToDouble(lblResultado.Text);
                    conta = lblResultado.Text + " * ";
                    operac = 3;

                    Atualiza();

                    lblResultadoTop.Text = lblResultado.Text;
                    lblResultado.Text = "";

                    conta = "";
                }
            } catch {
                Erro("Erro nos botões de Operação");
            }
        }

        public void divisao(object sender, EventArgs e) {
            try {
                if (verificaN1 == true) {
                    Completar();

                    conta = lblResultado.Text + " / ";
                    operac = 4;

                    Atualiza();

                    lblResultadoTop.Text = lblResultado.Text;
                    lblResultado.Text = "";
                    conta = "";
                }
            } catch {
                Erro("Erro nos botões de Operação");
            }
        }

        // Botões de Numero e o ponto
        public void numZero(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "0";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }

        public void numUm(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "1";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }

        public void numDois(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "2";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }

        public void numTres(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "3";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }

        public void numQuatro(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "4";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }

        public void numCinco(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "5";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }

        public void numSeis(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "6";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }

        public void numSete(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "7";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }

        public void numOito(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "8";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }

        public void numNove(object sender, EventArgs e) {
            try {
                if (pont == true) {
                    pont = false;
                }

                if (calculou == true) {
                    calculou = false;
                    lblResultado.Text = "";
                }

                conta = lblResultado.Text + "9";
                verificaN1 = true;

                if (operac != 0) {
                    verificaN2 = true;
                }

                Atualiza();
            } catch {
                Erro("Erro nos botões de Número");
            }
        }
        public void numPonto(object sender, EventArgs e) {
            try {
                if (pontN1 == false) {
                    if ((verificaN1 == false) || (calculou == true)) {
                        conta = lblResultado.Text + "0.";

                        verificaN1 = true;
                        calculou = false;
                    } else if ((verificaN1 == true) && (calculou == false)) {
                        conta = lblResultado.Text + ".";
                    }

                    pontN1 = true;
                    pont = true;
                } else if (pontN2 == false) {
                    if ((operac != 0) && (verificaN2 == false)) {
                        verificaN2 = true;

                        conta = lblResultado.Text + "0.";
                    } else if ((operac != 0) && (verificaN2 == true)) {
                        conta = lblResultado.Text + ".";
                    }

                    pontN2 = true;
                    pont = true;
                }

                Atualiza();
            } catch {
                Erro("Erro no botão Ponto");
            }
        }

        //Funções
        public void Atualiza() {
            try {
                lblResultado.Text = conta;

                if ((verificaN1 == true) && (operac != 0) && (verificaN2 == true)) {
                    num2 = Convert.ToDouble(lblResultado.Text);

                    switch (operac) {
                        case 1:     //Adição
                            resultado = num1 + num2;
                            break;
                        case 2:     //Subtração
                            resultado = num1 - num2;
                            break;
                        case 3:     //Multiplicação
                            resultado = num1 * num2;
                            break;
                        case 4:     //Divisão
                            resultado = num1 / num2;
                            break;
                        default:
                            break;
                    }

                    lblResultadoBot.Text = "" + resultado;
                }
            } catch {
                //Erro(Erro na função Atualizar);
            }
        }

        public void Completar() {
            try {
                if (pont == true) {
                    conta = lblResultado.Text + "0";

                    Atualiza();

                }

                num1 = Convert.ToDouble(lblResultado.Text);
            } catch {
                Erro("Erro na função Completar");
            }
        }

        private async void Erro(string message) {
            await DisplayAlert("Alerta", $"{message}", "OK");
        }

        public MainPage() {
            InitializeComponent();
        }
    }
}
