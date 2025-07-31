using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "Energy Drone", 1, 1, "Whenever you sync, gain 2 energy"));
        cardList.Add(new Card(1, "Recycle Bot", 1, 1, "Whenever you sync, draw a card"));
        cardList.Add(new Card(2, "Modular Engine", 1, 1, "When this card is played, for each time you've synced this turn, gain 1 strike and 1 armor"));
        cardList.Add(new Card(3, "Nano Regenerator", 3, 3, "When this card is played, for each time you've synced this turn, gain 1 energy and 1 health"));
        
    }
}
