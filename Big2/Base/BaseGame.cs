using Big2.Models;

namespace Big2.Base
{
    public abstract class BaseGame<T> where T : Card
    {
        protected Deck<T> deck;

        protected IList<Player> players;

        protected IDictionary<Player, Card> playCards = new Dictionary<Player, Card>();

        protected BaseGame()
        {
        }

        public void JoinPlayers(IList<Player> players)
        {
            this.players = players;

            for (var i = 0; i < players.Count; i++)
            {
                players[i].Order = i;
                players[i].Hand.Cards.Clear();
            }
        }

        public void Start()
        {
            this.DrawCard();

            while (this.TakesATurn()) ;

            Finish();
        }

        public abstract void DrawCard();


        public abstract bool TakesATurn();


        public abstract void Finish();
    }
}
