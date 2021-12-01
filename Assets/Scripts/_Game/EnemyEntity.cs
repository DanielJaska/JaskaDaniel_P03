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
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(0.1f);
            image.enabled = !image.enabled;
        }
        image.enabled = true;
        stateMachine.ChangeState<EnemyTurnState>();
    }
}
