 namespace blackJack
 {
    public class Card
    {
        // This stores the value (Ace - King) as a string.
        public string stringVal;
        // This tracks the suit of the card as a string.
        public string suit;
        // This tracks the number of the card, from 1 (Ace) to 13 (King). This does not equal how many points the card is worth.
        public int val;
        // This tracks how much each card is worth for scoring purposes.  Aces = 11, and if the Ace RealVal needs to be 1, this is handled in the scoring logic.
        public int realVal;
        //This tracks to see if the card was dealt face up or face down.  Defalts to false, for face UP.
        public bool faceDown = false;

        public Card(string anzug, int num){
            // Takes a string that corresponds to the suit and assigns that value to suit. (Anzug is German for suit)
            suit = anzug;
            // The card constructor is being passed a value from 0-12, 
            // so that we can pull the stringValue from the sV array, below.  
            // This means the actual number of the card is 1 higher.
            val = num + 1;
            // This table allows the constructor to convert the 0-12 into the string corresponding to the card.
            string[] sV = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            // Looks up the passed number (num) on the table (sV), and assigns that string to stringVal.
            stringVal = sV[num];
            // This if/else tree takes the val of the card and derives the RealValue.
            // Aces are worth 11
            if (val == 1)
            {
                realVal = 11;
            }
            // Cards larger than 10 are valued at 10
            else if (val > 10)
            {
                realVal = 10;
            }
            // Everything else is at face value.
            else
            {
                realVal = val;
            }
        }
        // Referencing cards as strings will display them in "Ace of Spades" format.
        public override string ToString()
        {
            return stringVal + " of " + suit;
        }
    }
}