using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Card : MonoBehaviour
{
    public int id;
    public string name;
    public int cost;
    public int power;
    public string cardDescription;
    public Card()
    {

    }
    
    public Card(int id, string name, int cost, int power, string cardDescription)
    {
        this.id = id;
        this.name = name;
        this.cost = cost;
        this.power = power;
        this.cardDescription = cardDescription;
    }
}