using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum battlestate { start, playerturn, enemyturn, won, lost}

public class battlecontroll : Healthhh
{

    public battlestate state;
    public Button OnAttackButto;
    public GameObject canvas;

    Unit playerunit;
    Unit enemyunit;
  public test ts;
    public player PL;

    

    void Start()
    {
        hp = maxhp;
    //  canvas = gameObject.findgameobjectwithTag("button");
        state = battlestate.start;
        StartCoroutine(setupBattle());
    }




    public IEnumerator setupBattle()
    {
      

        

        yield return new WaitForSeconds(2f);
        
        state = battlestate.playerturn;
        OnAttackButton();
    }

   IEnumerator PlayerAtack()
    {
        //tton MyButton = canvas.GetComponent<Button>();
      //MyButton.intera
       
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
        // PLayerturn();
        state = battlestate.playerturn;

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
