using System.Collections.Generic;

namespace blackJack {
    public class Player {
        public string name;
        public List<Card> hand;
        public bool isDealer;
        public double wins;
        public Player (string n) {
            // do the other end of the hand creation. Set hand to be a list of strings
            hand = new List<Card> ();
            // name is n
            name = n;
            //set isDealer to false by default
            isDealer = false;
            wins = 0.0;
        }
        // function that runs the dealer logic. return the dealers score or - for a bust
        public void dealerRound (Table table, Turn MyTurn) {
            Player dealer = table.PlayerList[0];
            int inGame = 0;
            // did the player bust? && is you a dealer??
            foreach (Player player in table.PlayerList) {
                // skip dealer.
                if (player == dealer) {
                    continue;
                }
                int busted = MyTurn.checkTotal (player);
                if (busted > 0) {
                    inGame = inGame + 1;
                }
            }

            if (inGame > 0) {
                // this is the score that will be messed with
                dealer.hand[0].faceDown=false;
                MyTurn.showTable (table);
                // show total

                int score = MyTurn.checkTotal (dealer);
                while (score < 16) {
                    dealer.Draw (table.deckName);
                    score = MyTurn.checkTotal (dealer);
                    if (score == -1) {
                        break;
                    }
                    MyTurn.showTable (table);
                }
                return;
            }
        }
        public void Draw (Deck gameDeck) {
            Card drawn = gameDeck.Deal ();
            System.Console.WriteLine (this.name + " has drawn the " + drawn.ToString ());
            hand.Add (drawn);
        }
        public void SecretDraw (Deck gameDeck) {
            Card drawn = gameDeck.Deal ();
            System.Console.WriteLine (this.name + " has drawn a card");
            hand.Add (drawn);
        }
        public Card Discard (int idx) {
            if (idx<hand.Count - 1 && idx> 0) {
                Card theCard = hand[idx];
                hand.RemoveAt (idx);
                return theCard;
            } else { return null; }
        }

    }

}