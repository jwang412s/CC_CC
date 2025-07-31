using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public Card displayCard = new Card();
    public int displayId;

    public int id;
    public string cardName;
    public int power;
    public int toughness;
    public string cardDescription;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI toughnessText;
    public TextMeshProUGUI descriptionText;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;
    void Start()
    {
        numberOfCardsInDeck = PlayerDeck.deckSize;
        displayCard = CardDatabase.cardList[displayId];

        id = displayCard.id;
        cardName = displayCard.cardName;
        power = displayCard.power;
        toughness = displayCard.toughness;
        cardDescription = displayCard.cardDescription;

        nameText.text = "" + cardName;
        powerText.text = ""  + power;
        toughnessText.text = "" + toughness;
        descriptionText.text = "" + cardDescription;
    }

    void Update()
    {
        Hand = GameObject.Find("Hand");
        if (this.transform.parent == Hand.transform)
        {
            cardBack = false;
        }
        staticCardBack = cardBack;

        if (this.tag == "Clone")
        {
            displayCard = PlayerDeck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            PlayerDeck.deckSize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }
    }
}
