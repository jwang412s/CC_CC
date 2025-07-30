using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int power;
    public int toughness;
    public string cardDescription;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Power, int Toughness, string CardDescription) 
    {
        id = Id;
        cardName = CardName;
        power = Power;
        toughness = Toughness;
        cardDescription = CardDescription;
    }
}
