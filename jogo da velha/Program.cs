
class Program
{
    static char jogadorAtual = 'X';
    static char[] espacos = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static bool termino = false;
    static bool trocar = true;
    
    static void Jogo()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine(" {0}  | {1}  | {2} ", espacos[0], espacos[1], espacos[2]) ;
        Console.WriteLine(" -------------");
        Console.WriteLine(" {0}  | {1}  | {2} ", espacos[3], espacos[4], espacos[5]);
        Console.WriteLine(" -------------");
        Console.WriteLine(" {0}  | {1}  | {2} ", espacos[6], espacos[7], espacos[8]);
    }

    static void trocarJogador()
    {
        if (jogadorAtual == 'X')
        {
            jogadorAtual = 'O';
        }
        else
        {
            jogadorAtual = 'X';
        }
    }

    static void verificar()
    {
        if (espacos[0] == espacos[1] && espacos[1] == espacos[2] ||
            espacos[3] == espacos[4] && espacos[4] == espacos[5] ||
            espacos[6] == espacos[7] && espacos[7] == espacos[8] ||
            espacos[0] == espacos[4] && espacos[4] == espacos[8] ||
            espacos[2] == espacos[4] && espacos[4] == espacos[6] ||
            espacos[0] == espacos[3] && espacos[3] == espacos[6] ||
            espacos[1] == espacos[4] && espacos[4] == espacos[7] ||
            espacos[2] == espacos[5] && espacos[5] == espacos[8]

            )
        {
            Jogo();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("O JOGADOR {0} GANHOU !!! ", jogadorAtual);
            termino = true;
        }else
            if (espacos[0] != '1' && espacos[1] != '2' && espacos[2] != '3' && espacos[3] != '4' && espacos[4] != '5'
                && espacos[5] != '6' && espacos[6] != '7' && espacos[7] != '8' && espacos[8] != '9')
        {
            Jogo();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("VELHA !!! ");
            termino = true;
        }

    }

    static void Main(string[] args)
    {
        int linha;
        int coluna;
        Console.WriteLine("-- Jogo da velha --");
        Console.ResetColor();
        do
        {
            if(trocar == true)
            {
                Jogo();
            }
            Console.WriteLine("");
            if(jogadorAtual == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine("Vez do jogador {0}", jogadorAtual);
            Console.ResetColor();
            do
            {
                Console.Write("Linha -> ");
                linha = int.Parse(Console.ReadLine());
                if (linha > 3 || linha <= 0)
                {
                    Console.WriteLine("Número Inválido");
                }
            } while (linha > 3 || linha <= 0);

            do
            {
                Console.Write("Coluna -> ");
                coluna = int.Parse(Console.ReadLine());
                if (coluna > 3 || coluna <= 0)
                {
                    Console.WriteLine("Número Inválido");
                }
            } while (coluna > 3 || coluna <= 0);

            if (linha == 1)
            {
                if (espacos[linha + coluna - 2] == 'X' || espacos[linha + coluna - 2] == 'O')
                {
                    Console.WriteLine("Espaço já escolhido");
                    trocar = false;
                }
            }
            {
                if (linha == 2)
                {
                    if (espacos[linha + coluna] == 'X' || espacos[linha + coluna] == 'O')
                    {
                        Console.WriteLine("Espaço já escolhido");
                        trocar = false;
                    }
                }
                else if (linha == 3)
                {
                    if (espacos[linha + coluna + 2] == 'X' || espacos[linha + coluna + 2] == 'O')
                    {
                        Console.WriteLine("Espaço já escolhido");
                        trocar = false;
                    }
                }
                
                    
                 if (linha == 1)
                {
                    if (espacos[linha + coluna - 2] != 'X' && espacos[linha + coluna - 2] != 'O')
                    {
                        espacos[linha + coluna - 2] = jogadorAtual;
                        trocar = true;
                    }
                }
                else if (linha == 2)
                {
                    if (espacos[linha + coluna] != 'X' && espacos[linha + coluna] != 'O')
                    {
                        espacos[linha + coluna] = jogadorAtual;
                        trocar = true;
                    }
                }
                else if (linha == 3)
                {
                    if (espacos[linha + coluna + 2] != 'X' && espacos[linha + coluna + 2] != 'O')
                    {
                        espacos[linha + coluna + 2] = jogadorAtual;
                        trocar = true;
                    }
                }
            }
            if(trocar == true)
            {
                verificar();
                trocarJogador();
            }
        } while (termino == false);
        Console.ReadKey();
    }
 }
        



                
         

      

