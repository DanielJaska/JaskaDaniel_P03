using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEntity : Entity
{
    public override void TakeDamage(int value)
    {
        base.TakeDamage(value);
        if (currentHealth <= 0)
        {
            stateMachine.ChangeState<WinState>();
        }
        else
        {
            StartCoroutine(timer());
        }
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(1f);
        stateMachine.ChangeState<EnemyTurnState>();
    }
}
