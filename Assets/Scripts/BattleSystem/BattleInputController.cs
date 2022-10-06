using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BattleInputController : MonoBehaviour
{
    [SerializeField] BattleHUD playerHud;
    [SerializeField] BattleHUD enemyHud;

    public void CycleLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            playerHud.UpdateStatsHud(0);
        }
        
    }

    public void CycleRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            playerHud.UpdateStatsHud(1);
        }
        
    }

    public void CycleLeftEnemy(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            enemyHud.UpdateEnemyStatsHud(1);
        }

    }

    public void CycleRightEnemy(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            enemyHud.UpdateEnemyStatsHud(0);
        }

    }
}
