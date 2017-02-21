using System;
namespace blackJack {
    public class Program {
        public static void Main (string[] args) {
            bool GameOn = true;
            int rounds = 1;
            Table MyTable = new Table (5);
            Player dealer = MyTable.PlayerList[0];
            while (GameOn == true) {
                // Deal each player up card
                foreach (Player player in MyTable.PlayerList) {
                    if (player == dealer) {
                        continue;
                    }
                    player.SecretDraw (MyTable.deckName);
                }
                // dealer draws a card and hides it.
                dealer.SecretDraw (MyTable.deckName);
                dealer.hand[0].faceDown = true;
                // deal each player a second card
                foreach (Player player in MyTable.PlayerList) {
                    if (player == dealer) {
                        continue;
                    }
                    player.SecretDraw (MyTable.deckName);
                }
                // deal the dealer a second card.
                dealer.SecretDraw (MyTable.deckName);

                // Check for Blackjacks
                Turn.showTable (MyTable);
                foreach (Player player in MyTable.PlayerList) {
                    if (Turn.checkBlackJack (player) == true) {
                        System.Console.WriteLine (player.name + " HAS BLACKJACK!!!");
                    }
                }
                System.Console.WriteLine ("Hit return to continue.");
                System.Console.ReadLine ();

                // each player takes a turn
                foreach (Player player in MyTable.PlayerList) {
                    // skip dealer unless he has blackjack, then it ends the player's turns.
                    if (player == dealer) {
                        if (Turn.checkBlackJack (player) == true) {
                            break;
                        }
                        continue;
                    }
                    // if the player has blackjack tell them and skip.
                    if (Turn.checkBlackJack (player) == true) {
                        Turn.showTable(MyTable);
                        System.Console.WriteLine (player.name + " HAS BLACKJACK!!!");
                        System.Console.WriteLine ("Hit return to continue.");
                        System.Console.ReadLine ();
                        continue;
                    }
                    // start hand loop
                    string choice = "";
                    while (choice != "STAND") {

                        // display all cards based upon their status
                        Console.Clear ();
                        Turn.showTable (MyTable);
                        // show total
                        System.Console.WriteLine (player.name + ": Your total is: " + Turn.checkTotal (player).ToString ());
                        // hit or stand
                        choice = Turn.hitOrStand (player);
                        if (choice == "HIT") {
                            player.Draw (MyTable.deckName);
                        }
                        // calculate new total
                        int playerVal = Turn.checkTotal (player);
                        if (playerVal < 0) {
                            System.Console.WriteLine (player.name + " BUSTED!");
                            System.Console.WriteLine ("Hit return to continue.");
                            System.Console.ReadLine ();
                            break;
                        }
                        System.Console.WriteLine ("Hit return to continue.");
                        System.Console.ReadLine ();
                        // repeat till stand or busted.
                    }
                }

                // dealer takes turn
                dealer.dealerRound (MyTable);
                // check winners
                System.Console.WriteLine ("Hit return to continue.");
                System.Console.ReadLine ();
                string results = Turn.checkWinner (MyTable);
                System.Console.WriteLine (results);
                System.Console.WriteLine("\n");
                foreach (Player player in MyTable.PlayerList) {
                    if (player == dealer) {
                        continue;
                    }
                    System.Console.WriteLine (player.name + "'s win percent is " + ((int) ((player.wins / rounds) * 100)).ToString () + "%");
                }
                // quit or continue
                //    query the player quit or continue
                System.Console.WriteLine ("Type 'Quit' to exit or anything else to continue");
                string playerQuit = System.Console.ReadLine ();
                if (playerQuit == "Quit") {
                    GameOn = false;
                }
                Turn.resetHand (MyTable);
                System.Console.Clear ();
                rounds = rounds + 1;
                if (rounds % 3 == 0) {
                    System.Console.WriteLine ("Shuffling");
                    MyTable.deckName.Reset ();
                }
                System.Console.WriteLine ("Hit return to continue.");
                System.Console.ReadLine ();
            }
        }
    }
}