using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public static List<Card> staticDeck = new List<Card>();
    public List<Card> playerDeck = new List<Card>();
    public int x;
    public int deckSize;
    public static int staticDeckSize;

    public GameObject cardInDeck;

    public GameObject cardToHand;
    public GameObject[] Clones;
    public GameObject Hand;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(0, 3);
            playerDeck.Add(CardDatabase.cardList[x]);
        }

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = playerDeck;
        if (deckSize < 1)
        {
            cardInDeck.SetActive(false);
        }
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1f);
        for (int i = 0; i <= 4; i++)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(cardToHand, transform.position, transform.rotation);
        }
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
