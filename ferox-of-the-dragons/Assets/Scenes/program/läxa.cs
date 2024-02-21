using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class läxa : MonoBehaviour
{

    public List<pokedex> pokemon = new List<pokedex>();
    
    
    // Start is called before the first frame update
    void Start()
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


        foreach (pokedex pokedex in pokemon)
        {
            pokedex.entry();
        }
    }



}

public class pokedex
{
    public virtual void entry()
    {

        Debug.Log("shit");


    }

}
public class Crustle : pokedex
{
    public override void entry()
    {
        base.entry();
    }




}
public class Snivy : pokedex
{

    public override void entry()
    {
        base.entry();

    }




}
public class Pansear: pokedex
{
    public override void entry()
    {
        base.entry();

    }
}
public class Papour : pokedex
{
    public override void entry()
    {
        base.entry();

    }
}
public class Kadabra : pokedex
{
    public override void entry()
    {
        base.entry();

    }
}
public class Pansage : pokedex
{
    public override void entry()
    {
        base.entry();

    }
}
