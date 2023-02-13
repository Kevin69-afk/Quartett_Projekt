using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_Quartett
{
    internal class Player
    {
        bool[] hasCard = new bool[32];
        bool[] cardIsPassive = new bool[32];
        bool[] cardIsActive = new bool[32];
        public int currentActiveCard = 0;

        public void AddCardAsPassive(int currentCard)
        {
            hasCard[currentCard] = true;
            cardIsPassive[currentCard] = true;
            cardIsActive[currentCard] = false;
        }

        public void AddCardAsActive(int currentCard)
        {
            hasCard[currentCard] = true;
            cardIsPassive[currentCard] = false;
            cardIsActive[currentCard] = true;
        }

        public void SetNextCardAsActive()
        {
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
        {
            hasCard[currentCard] = false;
            cardIsPassive[currentCard] = false;
            cardIsActive[currentCard] = false;
        }

        public void SetAllCardsToActive()
        {
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
        {
            int amount = 0;
            for(int i = 0; i < hasCard.Length; i++)
            {
                if (hasCard[i])
                    amount++;
            }
            return amount;
        }

        public int GetAmountOfActiveCards()
        {
            int amount = 0;
            for (int i = 0; i < hasCard.Length; i++)
            {
                if (hasCard[i] && cardIsActive[i])
                    amount++;
            }
            return amount;
        }

        public int GetAmountOfPassiveCards()
        {
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
