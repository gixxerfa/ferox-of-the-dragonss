using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class läxa2 : MonoBehaviour
{
    public List<pokedex> pokemon = new List<pokedex>();

    public void Start()
    {
        Crustle crustle = new Crustle();
        Snivy snivy = new Snivy();
        Pansage pansage = new Pansage();
        Pansear pansear = new Pansear();
        Papour panpour = new Papour();
        Kadabra kadabra = new Kadabra();

        pokemon.Add(crustle);
        pokemon.Add(snivy);
        pokemon.Add(kadabra);
        pokemon.Add(panpour);
        pokemon.Add(pansear);
        pokemon.Add(pansage);
    }

}



