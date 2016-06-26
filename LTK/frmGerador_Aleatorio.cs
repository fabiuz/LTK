using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTK
{
    public partial class frmGerador_Aleatorio : Form
    {
        public frmGerador_Aleatorio()
        {
            InitializeComponent();

            // Vamos preencher a lista conforme o tipo do jogo.
            jogo_aposta = new Dictionary<string, string[]>()
            {
                {
                    "QUINA", new string[] {"com 5 números.", "com 6 números.", "com 7 números."}
                },
                {
                    "MEGASENA",
                    new string[]
                    {
                        "com 6 números.",  "com 7 números.",  "com 8 números.", "com 9 números.",
                        "com 10 números.", "com 11 números.", "com 12 números.", "com 13 números.",
                        "com 14 números.", "com 15 números."
                    }
                },
                {
                    "LOTOFACIL",
                    new string[]
                    {
                        "com 15 números.", "com 16 números.", "com 17 números.", "com 18 números."
                    }
                },
                {
                    "LOTOMANIA", new string[] {"com 50 números." }
                },
                {
                    "DUPLASENA",
                    new string[]
                    {
                        "com 6 números.",  "com 7 números.",  "com 8 números.", "com 9 números.",
                        "com 10 números.", "com 11 números.", "com 12 números.", "com 13 números.",
                        "com 14 números.", "com 15 números."
                    }
                },
                {
                    "INTRALOT_MINAS_5", new string[] {"com 5 números." }
                },
                {
                    "INTRALOT_LOTO_MINAS", new string[] {"com 6 números." }
                },
                {
                    "INTRALOT_KENO_MINAS",
                    new string[] {
                        "com 1 número.", "com 2 números.", "com 3 números.", "com 4 números.", "com 5 números.",
                        "com 6 números.", "com 7 números.", "com 8 números.", "com 9 números.", "com 10 números.",
                        "com 20 números."}
                }
            };

            // Carregar o limite de cada jogo.
            jogo_limite_inferior_superior = new Dictionary<string, int[]>
            {
                // Os ítens no arranjo numérico corresponde a:
                // Limite inferior, Limite Superior e Quantidade de bolas do jogo.

                { "QUINA",                  new int[] {1, 80, 80 } },
                { "MEGASENA",               new int[] {1, 60, 60 } },
                { "LOTOFACIL",              new int[] {1, 25, 25 } },
                { "LOTOMANIA",              new int[] {0, 99, 100} },
                { "DUPLASENA",              new int[] {1, 50, 50 } },
                { "INTRALOT_MINAS_5",       new int[] {1, 34, 34 } },
                { "INTRALOT_LOTO_MINAS",    new int[] {1, 38, 38 } },
                { "INTRALOT_KENO_MINAS",    new int[] {1, 80, 80 } }
            };
        }

        readonly static string[] strJogos=  {
            "QUINA", "MEGASENA", "LOTOFACIL", "LOTOMANIA", "DUPLASENA",
            "INTRALOT_MINAS_5", "INTRALOT_LOTO_MINAS", "INTRALOT_KENO_MINAS"};

        static Dictionary<string, string[]> jogo_aposta = null;

        static Dictionary<string, int[]> jogo_limite_inferior_superior = null;


        private void frmGerador_Aleatorio_Load(object sender, EventArgs e)
        {
            cmbJogo_Tipo.Items.AddRange(strJogos.ToArray());
            cmbJogo_Tipo.SelectedIndex = 0;

            cmbAposta_com.Items.AddRange(jogo_aposta["QUINA"].ToArray());
            cmbAposta_com.SelectedIndex = 0;

            // Vamos preencher o controle 'cmbAposta_Quantidade'.
            for(var iA = 1; iA <= 1000; iA++)
            {
                cmbAposta_Quantidade.Items.Add(iA + " jogo(s).");
            }

            // Vamos preencher o controle 'cmbAposta_Quantidade'.
            //for (var iA = 5000; iA <= 5000000; iA += 5000)
            //{
            //    cmbAposta_Quantidade.Items.Add(iA + " jogo(s).");
            //}

            cmbAposta_Quantidade.SelectedIndex = 0;
        }

        private void cmbJogo_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Quando o usuário seleciona um outro jogo, devemos atualizar o controle 'cmbJogo_com' pois,
            // cada jogo tem uma quantidade de números que devemos jogar.
            string strJogo_Selecionado = cmbJogo_Tipo.Text.ToUpper();

            // Vamos verificar se o jogo selecionado existe, isto geralmente, não ocorre mas por precaução.
            if (!jogo_aposta.Keys.Contains(strJogo_Selecionado))
            {
                MessageBox.Show("ERRO", "Jogo" + strJogo_Selecionado + " inexistente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vamos atualizar o controle.
            cmbAposta_com.Items.Clear();
            cmbAposta_com.Items.AddRange(jogo_aposta[strJogo_Selecionado].ToArray());
            cmbAposta_com.SelectedIndex = 0;

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // Quando o usuário clicar em gerar iremos gerar a quantidade de números aleatórios.
            string strJogo = cmbJogo_Tipo.Text.ToUpper();

            // Vamos pegar o número que está no texto, somente.
            // Vamos retirar as palavras: 'com' e 'números.'
            // Em seguida, retirar os espaços.
            string strJogo_Aposta_com = cmbAposta_com.Text;

            strJogo_Aposta_com = strJogo_Aposta_com.Replace("com", "").Replace("número", "");
            strJogo_Aposta_com = strJogo_Aposta_com.Replace(".", "").Replace("(s)", "").Replace("s", "");
            
            string strJogo_Quantidade = cmbAposta_Quantidade.Text.Replace("(s)", "").Replace("jogo", "").Replace(".", "").Trim();

            // Vamos verificar se o jogo existe.
            if (!jogo_aposta.Keys.Contains(strJogo))
            {
                MessageBox.Show("ERRO", "Jogo" + strJogo + " inexistente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iJogo_Aposta_com = 0;
            int iJogo_Quantidade = 0;
            try
            {
                iJogo_Aposta_com = int.Parse(strJogo_Aposta_com);
                iJogo_Quantidade = int.Parse(strJogo_Quantidade);
            }
            catch (System.Exception exc)
            {
                MessageBox.Show("Erro: " + exc.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Desativa o controle enquanto executamos a função.
            btnGerar.Enabled = false;

            // Vamos pegar o limite inferior e superior do jogo.
            int jogo_limite_inferior = jogo_limite_inferior_superior[strJogo][0];
            int jogo_limite_superior = jogo_limite_inferior_superior[strJogo][1];
            int jogo_quantidade_de_itens = jogo_limite_inferior_superior[strJogo][2];

            // Acrescentado em 09/05/2016.
            // Se a lista abaixo, não existisse a medida que íamos localizando um novo número aleatório
            // o loop iria demora achar o próximo número, principalmente, se houvesse somente um único número
            // faltando.
            List<int> listaNumeros = new List<int>();
            for (var i = jogo_limite_inferior; i <= jogo_limite_superior; i++)
                listaNumeros.Add(i);

            
            // Vamos criar um arranjo do tipo bool, para guardar o status de cada bola
            // Devemos considerar a quantidade de ítens maior que 1 pois, os arranjos C#
            // são baseados em 0, e se a menor bola do jogo é 1, não podemos definir o arranjo
            // igual a 25, pois em c#, isto indica índices de 0 a 24, então devemos considerar
            // igual a 26.

            bool[] bNumero_ja_sorteado = new bool[jogo_quantidade_de_itens + 1];


            int numero_aleatorio = 0;
            Random gerador_aleatorio = new Random();

            // Conta a quantidade de números aleatórios já encontrados, quando está variável
            // exceder a quantidade de números que existe no jogo, quer dizer, que todos os números
            // foram sorteados. Então, se a quantidade de números que há no jogo não é divisível pela
            // quantidade de números apostados, o jogo, possívelmente, ficaria faltando número. Entretanto,
            // iremos reinicializar a variável 'bNumero_ja_sorteado' para indicar que nenhum número ainda
            // foi encontrado e em seguida, iremos pegar os números do concurso atual e indicar 

            int qt_de_numeros_aleatorios = 0;
            int[,] jogo_aleatorio = new int[iJogo_Quantidade, iJogo_Aposta_com];

            
            for (var iA = 0; iA < iJogo_Quantidade; iA++)
            {
                int iB = 0;
                
                while(iB < iJogo_Aposta_com)
                {
                    // A variável 'listaNumeros' guarda todos os números que ainda não foi selecionado.
                    int indiceNumero = gerador_aleatorio.Next(listaNumeros.Count);
                    numero_aleatorio = listaNumeros[indiceNumero];

                    // Remove o número.
                    listaNumeros.RemoveAt(indiceNumero);

                    //numero_aleatorio = gerador_aleatorio.Next(jogo_limite_inferior, jogo_limite_superior + 1);

                    // Se o número já foi sorteado continue.
                    if (bNumero_ja_sorteado[numero_aleatorio])
                    {
                        continue;
                    }
                    else
                    {
                        bNumero_ja_sorteado[numero_aleatorio] = true;
                        jogo_aleatorio[iA, iB] = numero_aleatorio;

                        iB++;

                        qt_de_numeros_aleatorios++;


                        // Se a quantidade de números aleatórios já encontrados é maior que
                        // a quantidade de números que existe no jogo, quer dizer, que todos os números
                        // já foram sorteados, devemos resetar a variável bNumero_ja_sorteado
                        // Se a quantidade de números que compõe o jogo dividido pela quantidade de números apostados
                        // é diferente de zero, então devemos pegar todos os números da linha atual e definir
                        // como true no arranjo.
                        if(qt_de_numeros_aleatorios == jogo_quantidade_de_itens)
                        {
                            qt_de_numeros_aleatorios = 0;

                            for (var uIndice = jogo_limite_inferior; uIndice <= jogo_limite_superior; uIndice++)
                            {
                                bNumero_ja_sorteado[uIndice] = false;

                                // Vamos adicionar todos os números, na lista.
                                listaNumeros.Add(uIndice);
                            }

                            // if iB ainda é menor que iJogo_Aposta_com, então, devemos pegar cada número 
                            // já processado e definir como true na variável bNumero_ja_sorteado.
                            if (iB < iJogo_Aposta_com)
                            {
                                qt_de_numeros_aleatorios = 0;
                                for(var iC = 0; iC <= iB; iC++)
                                {
                                    bNumero_ja_sorteado[jogo_aleatorio[iA, iC]] = true;
                                    qt_de_numeros_aleatorios++;

                                    // Devemos retirar da lista de números, os números já sorteados.
                                    var uIndice = listaNumeros.IndexOf(jogo_aleatorio[iA, iC]);
                                    if (uIndice != -1)
                                        listaNumeros.RemoveAt(uIndice);
                                }
                            }
                        }
                    }
                }

                // Ordenar números.
                for(var uA = 0; uA < iJogo_Aposta_com; uA++)
                {
                    int uNumero_Anterior = jogo_aleatorio[iA, uA];
                    int uNumero_Proximo;
                    for(var uB = uA + 1; uB < iJogo_Aposta_com; uB++)
                    {
                        uNumero_Proximo = jogo_aleatorio[iA, uB];
                        if(uNumero_Proximo< uNumero_Anterior)
                        {
                            jogo_aleatorio[iA, uA] = uNumero_Proximo;
                            jogo_aleatorio[iA, uB] = uNumero_Anterior;
                            uNumero_Anterior = jogo_aleatorio[iA, uA];
                        }
                    }
                }
            }

            // Detectar números repetidos.
            // Se houver números repetidos, guardar em uma lista.

            //List<int> linhas_repetidas = new List<int>();
            Dictionary<int, List<int>> linha_repetida = new Dictionary<int, List<int>>();

            for(var uA = 0; uA < iJogo_Quantidade; uA++)
            {
                for(var uB = uA + 1; uB < iJogo_Quantidade; uB++)
                {
                    int numeros_repetidos = 0;
                    for(var uC = 0; uC < iJogo_Aposta_com; uC++)
                    {
                        if (jogo_aleatorio[uA, uC] == jogo_aleatorio[uB, uC])
                            numeros_repetidos++;
                        else
                            break;                        
                    }
                    // Achou número repetido guarda na lista.
                    if (numeros_repetidos == iJogo_Aposta_com)
                    {
                        if (linha_repetida.ContainsKey(uA))
                        {
                            linha_repetida[uA].Add(uB);
                        }
                        else
                        {
                            linha_repetida.Add(uA, new List<int>() { uB });
                        }
                    }
                }
            }


            // Agora, vamos criar nosso grade de jogos.

            grJogos.Rows.Clear();

            // 2 colunas adicional:
            // 1 para o nome do jogo.
            // 1 para observação.
            grJogos.ColumnCount = iJogo_Aposta_com+3;

            grJogos.RowCount = iJogo_Quantidade;

            // Vamos colocar o cabeçalho.
            grJogos.Columns[0].Name = "JOGO_TIPO";
            grJogos.Columns[1].Name = "JOGO_SEQ";
            grJogos.Columns[2].Name = "OBSERVACAO";

            // Vamos colocar o nome das colunas.
            for(var iA = 0; iA < iJogo_Aposta_com; iA++)
            {
                grJogos.Columns[iA + 3].Name = "B" + (iA + 1).ToString();
            }


            
            for(var iA = 0; iA < iJogo_Quantidade; iA++)
            {
                grJogos.Rows[iA].Cells[0].Value = strJogo;
                grJogos.Rows[iA].HeaderCell.Value = iA;

                // Indica a sequência do jogo:
                grJogos.Rows[iA].Cells[1].Value = iA + 1;

                if (linha_repetida.ContainsKey(iA))
                {
                    string strTexto = "";
                    foreach(var repetidos in linha_repetida[iA])
                    {
                        strTexto += repetidos.ToString() + ", ";
                    }
                    grJogos.Rows[iA].Cells[1].Value = "<REPETIU=LINHA-" + strTexto + ">";
                }
               

                for(var iB = 0; iB < iJogo_Aposta_com; iB++)
                {
                    grJogos.Rows[iA].Cells[iB + 3].Value = jogo_aleatorio[iA, iB];
                }
            }

            grJogos.AutoResizeColumns();
            btnGerar.Enabled = true;


        }

        private void Gerar_Numeros_Aleatorio()
        {

        }



        private void grJogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bgLtk_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }



}
