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
    /// <summary>
    ///     Guarda todas as informações referente a úm único jogo.
    /// </summary>
    internal struct JogoInfo
    {
        public JogoInfo(string jogoTipo, int menorBola, int maiorBola, int quantidadeBola, int[] bolasApostadas)
        {
            this.jogoTipo = jogoTipo;
            this.menorBola = menorBola;
            this.maiorBola = maiorBola;
            this.quantidadeBola = quantidadeBola;
            this.bolasApostadas = bolasApostadas;
        }

        public string jogoTipo { get; set; }
        public int menorBola { get; set; }
        public int maiorBola { get; set; }
        public int quantidadeBola { get; set; }
        public int[] bolasApostadas { get; set; }

    }
    public partial class frmGerador_Aleatorio : Form
    {
        private JogoInfo[] jogoInfo;

        private void InicializarJogoInfo()
        {
            jogoInfo = new JogoInfo[]
            {
                new JogoInfo("QUINA", 1, 80, 80, new int [] {5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }),
                new JogoInfo("MEGASENA", 1, 60, 60, new int [] {6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }),
                new JogoInfo("LOTOFACIL", 1, 25, 25, new int [] {15, 16, 17, 18}),
                new JogoInfo("LOTOMANIA", 0, 99, 100, new int[] {50 }),
                new JogoInfo("DUPLASENA", 1, 50, 50, new int[] {6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }),
                new JogoInfo("INTRALOT_MINAS_5", 1, 34, 34, new int[] {5 }),
                new JogoInfo("INTRALOT_LOTO_MINAS", 1, 38, 38, new int[] {6 }),
                new JogoInfo("INTRALOT_KENO_MINAS", 1, 80, 80, new int[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })
            };
        }

        /// <summary>
        /// 
        /// </summary>
        public frmGerador_Aleatorio()
        {
            InitializeComponent();

            // Instancia e cria a informação de cada jogo.
            InicializarJogoInfo();
        }
        
        private void frmGerador_Aleatorio_Load(object sender, EventArgs e)
        {
            // Preenche com o nome dos jogos.
            for (var uA = 0; uA < jogoInfo.Length; uA++)
                cmbJogo_Tipo.Items.Add(jogoInfo[uA].jogoTipo);
            cmbJogo_Tipo.SelectedIndex = 0;

            // Preenche a caixa de combinação 'cmbAposta_com' relativo ao primeiro jogo.
            for (var uA = 0; uA < jogoInfo[0].bolasApostadas.Length;uA++)
                cmbAposta_com.Items.Add(jogoInfo[0].bolasApostadas[uA]);
            cmbAposta_com.SelectedIndex = 0;

            // Vamos preencher o controle 'cmbAposta_Quantidade'.
            for (var iA = 1; iA <= 1000; iA++)
            {
                cmbAposta_Quantidade.Items.Add(iA);
            }

            cmbAposta_Quantidade.SelectedIndex = 0;
        }

        /// <summary>
        ///     Toda vez que o controle 'cmbJogo_Tipo' altera, devemos atualizar o controle 'cmbAposta_com'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbJogo_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // O índice é baseado em zero.
            // Se não há nada selecionado, -1 é retornado.
            // O que geralmente, nunca ocorrerá pois este evento indica isso.
            int indiceSelecionado = cmbJogo_Tipo.SelectedIndex;
            
            // Só altera se índice esta dentro do intervalo, geralmente, sempre irá funcionar.
            if(indiceSelecionado > 0 && indiceSelecionado < jogoInfo.Length)
            {

                cmbAposta_com.Items.Clear();

                // Cada jogo tem a quantidade míníma e máxima para jogar.
                // Então, se o jogo altera devemos alterar apropriadamente.
                for (var uA = 0; uA < jogoInfo[indiceSelecionado].bolasApostadas.Length; uA++)
                    cmbAposta_com.Items.Add(jogoInfo[indiceSelecionado].bolasApostadas[uA]);
                cmbAposta_com.SelectedIndex = 0;
                cmbAposta_Quantidade.SelectedIndex = 0;
            }            
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // Guardar o nome do jogo escolhido.
            string strJogo = cmbJogo_Tipo.Text.ToUpper();

            // Pega a quantidade de números apostados para o jogo.
            int iJogo_Aposta_com = int.Parse(cmbAposta_com.Text);
            int iJogo_Quantidade = int.Parse(cmbAposta_Quantidade.Text);

            // Desativa o controle enquanto executamos a função.
            btnGerar.Enabled = false;

            // Vamos pegar o índice selecionado, o índice selecionado refere-se ao jogo escolhido.
            int indiceSelecionado = cmbJogo_Tipo.SelectedIndex;
            int jogo_limite_inferior = jogoInfo[indiceSelecionado].menorBola;
            int jogo_limite_superior = jogoInfo[indiceSelecionado].maiorBola;
            int jogo_quantidade_de_itens = jogoInfo[indiceSelecionado].quantidadeBola;

            // Acrescentado em 09/05/2016.
            // Se a lista abaixo, não existisse a medida que íamos localizando um novo número aleatório
            // o loop iria demora achar o próximo número, principalmente, se houvesse somente um único número
            // faltando.
            List<int> listaNumeros = new List<int>();

            // Guarda números pares.
            List<int> listaNumerosPares = new List<int>();

            // Guarda números impares.
            List<int> listaNumerosImpares = new List<int>();


            for (var i = jogo_limite_inferior; i <= jogo_limite_superior; i++)
            {
                listaNumeros.Add(i);

                // Vamos adicionar o número à lista apropriada conforme se é par ou impar.
                if (i % 2 == 0)
                    listaNumerosPares.Add(i);
                else
                    listaNumerosImpares.Add(i);
            }


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

                while (iB < iJogo_Aposta_com)
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
                        if (qt_de_numeros_aleatorios == jogo_quantidade_de_itens)
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
                                for (var iC = 0; iC <= iB; iC++)
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
                for (var uA = 0; uA < iJogo_Aposta_com; uA++)
                {
                    int uNumero_Anterior = jogo_aleatorio[iA, uA];
                    int uNumero_Proximo;
                    for (var uB = uA + 1; uB < iJogo_Aposta_com; uB++)
                    {
                        uNumero_Proximo = jogo_aleatorio[iA, uB];
                        if (uNumero_Proximo < uNumero_Anterior)
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

            for (var uA = 0; uA < iJogo_Quantidade; uA++)
            {
                for (var uB = uA + 1; uB < iJogo_Quantidade; uB++)
                {
                    int numeros_repetidos = 0;
                    for (var uC = 0; uC < iJogo_Aposta_com; uC++)
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
            grJogos.ColumnCount = iJogo_Aposta_com + 3;

            grJogos.RowCount = iJogo_Quantidade;

            // Vamos colocar o cabeçalho.
            grJogos.Columns[0].Name = "JOGO_TIPO";
            grJogos.Columns[1].Name = "JOGO_SEQ";
            grJogos.Columns[2].Name = "OBSERVACAO";

            // Vamos colocar o nome das colunas.
            for (var iA = 0; iA < iJogo_Aposta_com; iA++)
            {
                grJogos.Columns[iA + 3].Name = "B" + (iA + 1).ToString();
            }



            for (var iA = 0; iA < iJogo_Quantidade; iA++)
            {
                grJogos.Rows[iA].Cells[0].Value = strJogo;
                grJogos.Rows[iA].HeaderCell.Value = iA;

                // Indica a sequência do jogo:
                grJogos.Rows[iA].Cells[1].Value = iA + 1;

                if (linha_repetida.ContainsKey(iA))
                {
                    string strTexto = "";
                    foreach (var repetidos in linha_repetida[iA])
                    {
                        strTexto += repetidos.ToString() + ", ";
                    }
                    grJogos.Rows[iA].Cells[1].Value = "<REPETIU=LINHA-" + strTexto + ">";
                }


                for (var iB = 0; iB < iJogo_Aposta_com; iB++)
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
