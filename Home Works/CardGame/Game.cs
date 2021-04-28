using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Game
    {
        private int countCardsInDeck = 36;
        private int playersCount = 2;
        public List<Player> players = new List<Player>();
        public List<Karta> deckOfKards = new List<Karta>();
        Random random = new Random();

        public Game()
        {
            for (int i = 0; i < playersCount; i++)
            {
                players.Add(new Player());
            }
            deckOfKards = CreateDeckOfKards();
            DistributionOfCards(deckOfKards);
            while(Moves()) { }
        }

        public List<Karta> CreateDeckOfKards()
        {
            int suitCount = countCardsInDeck / 4;
            for (int i = 0; i < suitCount; i++)
            {
                deckOfKards.Add(new Karta((CardType)i, (CardSuit)0));
                deckOfKards.Add(new Karta((CardType)i, (CardSuit)1));
                deckOfKards.Add(new Karta((CardType)i, (CardSuit)2));
                deckOfKards.Add(new Karta((CardType)i, (CardSuit)3));
            }
            deckOfKards.Sort((type, suit) => random.Next(-10, 10));
            return deckOfKards;
        }

        public void DistributionOfCards(List<Karta> deckPlayer)
        {
            for (int j = 0; j < playersCount; j++)
            {
                for (int i = 0; i < deckPlayer.Count / 2; i++)
                {
                    players[j].karts.Add(deckPlayer[i]);
                }
            }
        }

        public bool Moves()
        {
            Console.WriteLine("Ход игроков:");         
            Console.WriteLine("игрок\tкол-во карт\tход картой");

            int maxType = -1;
            Player playerMax = null;
            Stack<Karta> cardStack = new Stack<Karta>();

            for (int i = 0; i < players.Count; i++)
            {
                Player player = players[i];

                if (player.karts.Count > 0)
                {
                    Karta card = player.karts[random.Next(player.karts.Count)];
                    Console.WriteLine($"{i}\t{player.karts.Count}\t\t{card}");
                    player.karts.Remove(card);
                    if ((int)card.type > maxType)
                    {
                        maxType = (int)card.type;
                        playerMax = player;
                    }
                    cardStack.Push(card);
                }
            }
            playerMax.karts.AddRange(cardStack);
            Console.WriteLine($"Забрал игрок {players.IndexOf(playerMax)}.");
            Console.WriteLine("------------------------------------------------");

            if (playerMax.karts.Count == countCardsInDeck)
            {
                Console.WriteLine($"Победил игрок номер {players.IndexOf(playerMax)}");
                return false;
            }
            return true;         

            

            //Stack<Karta> cardQueuePlayer1 = new Stack<Karta>();
            //Stack<Karta> cardQueuePlayer2 = new Stack<Karta>();
            //Player player1 = players[0];
            //Player player2 = players[1];
            //do
            //{
            //    if (player1.karts.Count > 0)
            //    {
            //        Karta card1 = player1.karts[random.Next(player1.karts.Count)];
            //        Karta card2 = player2.karts[random.Next(player2.karts.Count)];
            //        int compare = Compare(card1, card2);
            //        if (compare == 1 || compare == 0)
            //        {
            //            cardQueuePlayer1.Push(card1);
            //            cardQueuePlayer1.Push(card2);
            //            Console.WriteLine($"Карты забрал игрок 1");
            //        }
            //        else if (compare == -1)
            //        {
            //            cardQueuePlayer2.Push(card1);
            //            cardQueuePlayer2.Push(card2);
            //            Console.WriteLine($"Карты забрал игрок 2");
            //        }
            //    }
            //} while (cardQueuePlayer1.Count == countCardsInDeck || cardQueuePlayer2.Count == countCardsInDeck);
            //if (cardQueuePlayer1.Count == countCardsInDeck)
            //{
            //    Console.WriteLine("Победил 1 игрок");
            //    return false;
            //}

            //else if (cardQueuePlayer2.Count == countCardsInDeck)
            //{
            //    Console.WriteLine("Победил 2 игрок");
            //    return false;
            //}
            //return false;

        }


        public void Print()
        {
            foreach(var item in deckOfKards)
            {
                Console.WriteLine($"{item}");
            }
        }

        //public int Compare(Karta x, Karta y)
        //{
        //    if (x is Karta && y is Karta)
        //    {
        //        Karta player1 = x as Karta;
        //        Karta player2 = y as Karta;

        //        if (player1.type > player2.type)
        //        {
        //            return 1;
        //        }
        //        else if (player1.type < player2.type)
        //        {
        //            return -1;
        //        }
        //        return 0;
        //    }
        //    throw new NotImplementedException();
        //}
    }
    
}
