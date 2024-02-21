using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum battlestate { start, playerturn, enemyturn, won, lost}

public class battlecontroll : Healthhh
{

    public battlestate state;

    Unit playerunit;
    Unit enemyunit;
    

    

    void Start()
    {
        state = battlestate.start;
        StartCoroutine(setupBattle());
    }




    public IEnumerator setupBattle()
    {
      

        

        yield return new WaitForSeconds(2f);
        
        state = battlestate.playerturn;
        PLayerturn();
    }

   IEnumerator PlayerAtack()
    {
         
       
        yield return new WaitForSeconds(2f);

    }
    IEnumerator enemyturn()
    {
        yield return new WaitForSeconds(1f);
        


    }
    
    public void PLayerturn()
    {

    }
    public void OnAttackButton()
    {
        if (state != battlestate.playerturn)
            return;

        StartCoroutine(PlayerAtack());

    }
















}
