using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum battlestate { start, playerturn, enemyturn, won, lost}

public class battlecontroll : MonoBehaviour
{

    public battlestate state;
    public GameObject playerprefab;
    public GameObject enemyprefab;

    public Transform PLayerBattleStation;
    public Transform EnemyBattleStation;

    void Start()
    {
        state = battlestate.start;
        StartCoroutine(setupBattle());
    }




    public IEnumerator setupBattle()
    {
        Instantiate(playerprefab, PLayerBattleStation);
        Instantiate(enemyprefab, EnemyBattleStation);

        yield return new WaitForSeconds(2f);
        
        state = battlestate.playerturn;
        PLayerturn();
    }

    public void PLayerturn()
    {

    }
















}
