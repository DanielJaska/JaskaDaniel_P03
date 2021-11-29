using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEntity : Entity
{
    public static int skillPoints = 0;
    [SerializeField] Text spText = null;

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

    public void Heal(int value)
    {
        base.TakeDamage(value);
        stateMachine.ChangeState<EnemyTurnState>();
    }

    public void AddSP()
    {
        skillPoints += 1;
        spText.text = skillPoints.ToString();
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(1f);
        stateMachine.ChangeState<PlayerTurnGameState>();
    }
}
