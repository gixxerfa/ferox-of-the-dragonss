using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum battlestate { start, playerturn, enemyturn, won, lost}

public class battlecontroll : Healthhh
{

    public battlestate state;
    public Button OnAttackButto;

    Unit playerunit;
    Unit enemyunit;
  public test ts;
    public player PL;

    

    void Start()
    {
        hp = maxhp;
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
        ts.Hurt();
        state = battlestate.enemyturn;
       StartCoroutine( enemyturn());

    }
    IEnumerator enemyturn()
    {
        if (state == battlestate.enemyturn)
            
        //TakeDamage(5);
        
        yield return new WaitForSeconds(2f);
        PL.PlayerHurt();
        PLayerturn();

    }
    
    public void PLayerturn()
    {
        state = battlestate.playerturn;
        OnAttackButton();
    }
    public void OnAttackButton()
    {
        if (state != battlestate.playerturn)
            return;

        StartCoroutine(PlayerAtack());

    }
















}
