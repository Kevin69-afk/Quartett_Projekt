using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_Quartett
{
    internal class Player
    {   
        bool[] hasCard = new bool[32];// gesamte Anzahl der Karten
        bool[] cardIsPassive = new bool[32];//Jede Karte als Passiv gesetzt werden 
        bool[] cardIsActive = new bool[32]; //Jede Karte als Aktiv gesetzt werden 
        public int currentActiveCard = 0; //Die aktuelle aktive Karte 

        public void AddCardAsPassive(int currentCard)
        {   // Karten passiv setzen
            hasCard[currentCard] = true;
            cardIsPassive[currentCard] = true;
            cardIsActive[currentCard] = false;
        }

        public void AddCardAsActive(int currentCard)
        {   // Karten aktiv setzen
            hasCard[currentCard] = true;
            cardIsPassive[currentCard] = false;
            cardIsActive[currentCard] = true;
        }

        public void SetNextCardAsActive()
        {// Die nächste Karte als aktiv setzen
            if (GetAmountOfTotalCards() > 0) 
            {
                for (int i = currentActiveCard + 1; i < 33; i++)
                {
                    if (i == 32) i = 0;

                    if (hasCard[i])
                    {
                        currentActiveCard = i;
                        return;
                    }
                }
            }
        }

        public void RemoveCard(int currentCard)
        {   // Karten zurück nehmen 
            hasCard[currentCard] = false;
            cardIsPassive[currentCard] = false;
            cardIsActive[currentCard] = false;
        }

        public void SetAllCardsToActive()
        {   // Karten als aktive Karten setzen
            for (int i = 0; i < cardIsPassive.Length; i++)
            {
                if (hasCard[i] && cardIsPassive[i])
                {
                    cardIsPassive[i] = false;
                    cardIsActive[i] = true;
                }
            }
        }

        public int GetAmountOfTotalCards()
        {   // Erhalten der Anzahl der gesamten Karten
            int amount = 0;
            for(int i = 0; i < hasCard.Length; i++)
            {
                if (hasCard[i])
                    amount++;
            }
            return amount;
        }

        public int GetAmountOfActiveCards()
        {   // Erhalten der Anzahl aktiver Karten 
            int amount = 0;
            for (int i = 0; i < hasCard.Length; i++)
            {
                if (hasCard[i] && cardIsActive[i])
                    amount++;
            }
            return amount;
        }

        public int GetAmountOfPassiveCards()
        {   // Erhalten der Anzahl passiver Karten 
            int amount = 0;
            for (int i = 0; i < hasCard.Length; i++)
            {
                if (hasCard[i] && cardIsPassive[i])
                    amount++;
            }
            return amount;
        }
    }
}
