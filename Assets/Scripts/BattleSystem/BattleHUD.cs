using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] TMP_Text HPText;
    [SerializeField] TMP_Text MPText;
    [SerializeField] TMP_Text Attack;
    [SerializeField] TMP_Text Defense;
    [SerializeField] TMP_Text MagAttack;
    [SerializeField] TMP_Text MagDefense;
    [SerializeField] Image monImage;

    public void SetData(Monster monster)
    {
        HPText.text = monster.MaxHP.ToString();
        MPText.text = monster.MaxMP.ToString();
        Attack.text = monster.Attack.ToString();
        Defense.text = monster.Defense.ToString();
        MagAttack.text = monster.MagAttack.ToString();
        MagDefense.text = monster.MagDefense.ToString();
        monImage.sprite = monster.Sprite;
    }

    public void UpdateStatsHud(int direction)
    {

        BattleSystem.instance.currentMonsterStats.UnFade();

        if (direction == 1)
        {
            if (BattleSystem.instance.currentMonsterStats == BattleSystem.instance.playerUnit1)
            {
                BattleSystem.instance.ShowStats(BattleSystem.instance.playerUnit2);
                BattleSystem.instance.UpdateCurrentMonster(BattleSystem.instance.playerUnit2);
                BattleSystem.instance.currentMonsterStats.Fade();
            }
            else if (BattleSystem.instance.currentMonsterStats == BattleSystem.instance.playerUnit2)
            {
                BattleSystem.instance.ShowStats(BattleSystem.instance.playerUnit3);
                BattleSystem.instance.UpdateCurrentMonster(BattleSystem.instance.playerUnit3);
                BattleSystem.instance.currentMonsterStats.Fade();
            }
            else if (BattleSystem.instance.currentMonsterStats == BattleSystem.instance.playerUnit3)
            {
                BattleSystem.instance.ShowStats(BattleSystem.instance.playerUnit1);
                BattleSystem.instance.UpdateCurrentMonster(BattleSystem.instance.playerUnit1);
                BattleSystem.instance.currentMonsterStats.Fade();
            }
        }

        if (direction == 0)
        {
            if (BattleSystem.instance.currentMonsterStats == BattleSystem.instance.playerUnit1)
            {
                BattleSystem.instance.ShowStats(BattleSystem.instance.playerUnit3);
                BattleSystem.instance.UpdateCurrentMonster(BattleSystem.instance.playerUnit3);
                BattleSystem.instance.currentMonsterStats.Fade();
            }
            else if (BattleSystem.instance.currentMonsterStats == BattleSystem.instance.playerUnit3)
            {
                BattleSystem.instance.ShowStats(BattleSystem.instance.playerUnit2);
                BattleSystem.instance.UpdateCurrentMonster(BattleSystem.instance.playerUnit2);
                BattleSystem.instance.currentMonsterStats.Fade();
            }
            else if (BattleSystem.instance.currentMonsterStats == BattleSystem.instance.playerUnit2)
            {
                BattleSystem.instance.ShowStats(BattleSystem.instance.playerUnit1);
                BattleSystem.instance.UpdateCurrentMonster(BattleSystem.instance.playerUnit1);
                BattleSystem.instance.currentMonsterStats.Fade();
            }
        }
    }


    public void UpdateEnemyStatsHud(int direction)
    {

        BattleSystem.instance.currentEnemyMonsterStats.UnFade();

        if (direction == 1)
        {
            if (BattleSystem.instance.currentEnemyMonsterStats == BattleSystem.instance.enemyUnit1)
            {
                BattleSystem.instance.ShowEnemyStats(BattleSystem.instance.enemyUnit3);
                BattleSystem.instance.UpdateCurrentEnemyMonster(BattleSystem.instance.enemyUnit3);
                BattleSystem.instance.currentEnemyMonsterStats.Fade();
            }
            else if (BattleSystem.instance.currentEnemyMonsterStats == BattleSystem.instance.enemyUnit3)
            {
                BattleSystem.instance.ShowEnemyStats(BattleSystem.instance.enemyUnit2);
                BattleSystem.instance.UpdateCurrentEnemyMonster(BattleSystem.instance.enemyUnit2);
                BattleSystem.instance.currentEnemyMonsterStats.Fade();
            }
            else if (BattleSystem.instance.currentEnemyMonsterStats == BattleSystem.instance.enemyUnit2)
            {
                BattleSystem.instance.ShowEnemyStats(BattleSystem.instance.enemyUnit1);
                BattleSystem.instance.UpdateCurrentEnemyMonster(BattleSystem.instance.enemyUnit1);
                BattleSystem.instance.currentEnemyMonsterStats.Fade();
            }
            Debug.Log(BattleSystem.instance.currentEnemyMonsterStats);
        }

        if (direction == 0)
        {
            if (BattleSystem.instance.currentEnemyMonsterStats == BattleSystem.instance.enemyUnit1)
            {
                BattleSystem.instance.ShowEnemyStats(BattleSystem.instance.enemyUnit2);
                BattleSystem.instance.UpdateCurrentEnemyMonster(BattleSystem.instance.enemyUnit2);
                BattleSystem.instance.currentEnemyMonsterStats.Fade();
            }
            else if (BattleSystem.instance.currentEnemyMonsterStats == BattleSystem.instance.enemyUnit2)
            {
                BattleSystem.instance.ShowEnemyStats(BattleSystem.instance.enemyUnit3);
                BattleSystem.instance.UpdateCurrentEnemyMonster(BattleSystem.instance.enemyUnit3);
                BattleSystem.instance.currentEnemyMonsterStats.Fade();
            }
            else if (BattleSystem.instance.currentEnemyMonsterStats == BattleSystem.instance.enemyUnit3)
            {
                BattleSystem.instance.ShowEnemyStats(BattleSystem.instance.enemyUnit1);
                BattleSystem.instance.UpdateCurrentEnemyMonster(BattleSystem.instance.enemyUnit1);
                BattleSystem.instance.currentEnemyMonsterStats.Fade();
            }
            Debug.Log(BattleSystem.instance.currentEnemyMonsterStats);
        }
    }
}
