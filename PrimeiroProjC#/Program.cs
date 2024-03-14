
using PrimeiroProjC_;
using PrimeiroProjC_.tabuleiro;
using PrimeiroProjC_.xadrez;
using tabuleiro;
using xadrez;

namespace PrimeiroProjC {
    class Program
{
    static void Main(string[] args)
    {
            PosicaoXadrez pos = new PosicaoXadrez('c', 1);


            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
    }
}
}