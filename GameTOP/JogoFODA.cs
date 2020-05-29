using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador __jogadorA;

        private readonly iJogador __jogadorB;

        public JogoFODA(iJogador _jogadorA, iJogador _jogadorB)
        {
            __jogadorA = _jogadorA;
            __jogadorB = _jogadorB;
        }

        public void IniciarJogo()
        {
            System.Console.Write(__jogadorA.Corre());
            System.Console.Write(__jogadorA.Chuta());
            System.Console.Write(__jogadorA.Passe());
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write(__jogadorB.Corre());
            System.Console.Write(__jogadorB.Chuta());
            System.Console.Write(__jogadorB.Passe());
        }
    }

}