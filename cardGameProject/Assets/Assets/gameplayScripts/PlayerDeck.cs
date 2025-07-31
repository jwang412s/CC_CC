using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> playerDeck = new List<Card>();
    public int x;
    public int deckSize;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, 3);
            playerDeck.Add(CardDatabase.cardList[x]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shuffle()
    {
        for (int i = 0; i < playerDeck.Count; i++)
        {
            int j = Random.Range(0, playerDeck.Count);
            Card temp = playerDeck[i];
            playerDeck[i] = playerDeck[j];
            playerDeck[j] = temp;
        }
    }
}
