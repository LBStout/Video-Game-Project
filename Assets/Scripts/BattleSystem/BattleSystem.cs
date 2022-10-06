using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum BattleState{
    Start,
    PlayerAction,
    PlayerMove,
    EnemyMove,
    Busy
}

public class BattleSystem : MonoBehaviour
{
    public static BattleSystem instance;
    public BattleUnit playerUnit1, playerUnit2, playerUnit3;
    public BattleUnit enemyUnit1, enemyUnit2, enemyUnit3;
    public BattleUnit currentMonsterStats, currentEnemyMonsterStats;
    [SerializeField] BattleHUD playerHud;
    [SerializeField] BattleHUD enemyHud;
    [SerializeField] BattleDialogBox actionBox;

    BattleState state;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        StartCoroutine(SetUpBattle());
        currentMonsterStats = playerUnit1;
        currentMonsterStats.Fade();
        currentEnemyMonsterStats = enemyUnit1;
        currentEnemyMonsterStats.Fade();
    }

    public IEnumerator SetUpBattle()
    {
        playerUnit1.Setup();
        playerUnit2.Setup();
        playerUnit3.Setup();
        enemyUnit1.Setup();
        enemyUnit2.Setup();
        enemyUnit3.Setup();
        playerHud.SetData(playerUnit1.Pokemon);
        enemyHud.SetData(enemyUnit1.Pokemon);

        /*actionBox.SetDialog($" A wild {enemyUnit1.Pokemon.monBase.name} appears!\n" +
            $" A wild {enemyUnit2.Pokemon.monBase.name} appears!\n" +
            $" A wild {enemyUnit3.Pokemon.monBase.name} appears!"); */

        yield return new WaitForSeconds(1f);

        
        
    }

    public void ShowStats(BattleUnit monster)
    {
        playerHud.SetData(monster.Pokemon);
    }

    public void UpdateCurrentMonster(BattleUnit monster)
    {
        currentMonsterStats = monster;
    }

    public void ShowEnemyStats(BattleUnit monster)
    {
        enemyHud.SetData(monster.Pokemon);
    }

    public void UpdateCurrentEnemyMonster(BattleUnit monster)
    {
        currentEnemyMonsterStats = monster;
    }
}
