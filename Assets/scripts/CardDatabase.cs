using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardlist = new List<Card>();

    void Awake()
    {
        cardlist.Add(new Card(0, "None", 0, 0, "None"));
        cardlist.Add(new Card(1, "Human", 2, 1, "This is a human card with basic attributes."));
        cardlist.Add(new Card(2, "Elf", 3, 3, "This is a elf card with basic attributes."));
        cardlist.Add(new Card(3, "Dwarf", 4, 4, "This is a dwarf card with basic attributes."));
        cardlist.Add(new Card(4, "Troll", 5, 5, "This is a troll card with basic attributes."));
    }
}