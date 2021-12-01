using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEntity : Entity
{
    public static int skillPoints = 0;
    [SerializeField] Text spText = null;
    [SerializeField] AudioClip audioClip;

    public override void TakeDamage(int value)
    {
        base.TakeDamage(value);
        AudioHelper.PlayClip2D(audioClip, 1f);
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
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(0.1f);
            image.enabled = !image.enabled;
        }
        image.enabled = true;
        stateMachine.ChangeState<PlayerTurnGameState>();
    }
}
