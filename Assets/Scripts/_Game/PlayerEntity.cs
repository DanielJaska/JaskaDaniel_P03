using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : Entity
{
    public override void TakeDamage(int value)
    {
        base.TakeDamage(value);
        if (currentHealth <= 0)
        {
            stateMachine.ChangeState<LoseState>();
        } else
        {
            StartCoroutine(timer());
        }
    }



    IEnumerator timer()
    {
        yield return new WaitForSeconds(1f);
        stateMachine.ChangeState<PlayerTurnGameState>();
    }
}
