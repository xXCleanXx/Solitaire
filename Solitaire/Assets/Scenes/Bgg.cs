using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using neXn.Lib.Playingcards;
using neXn.Lib.Playingcards.Classes;

public class Bgg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Deck d = new();
        d.Create(new neXn.Lib.Playingcards.Models.CardOptions() { Decktype = neXn.Lib.Playingcards.Models.Card.Decktypes.FourColor, IncludeJokers = true });
        d.Shuffle();
        var s = d.Carddeck.Any(x => x.Value == "A");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
