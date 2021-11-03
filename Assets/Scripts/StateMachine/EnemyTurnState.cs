using UnityEngine;
using System;
using System.Collections;

public class EnemyTurnState : GameState
{
    public static event Action EnemyTurnBegan;
    public static event Action EnemyTurnEnded;

    [SerializeField] float _pauseDuration = 1.5f;

    [SerializeField] Entity target;

    public override void Enter()
    {
        Debug.Log("Enemy Turn: ...Enter");
        EnemyTurnBegan?.Invoke();

        StartCoroutine(EnemyThinkingRoutine(_pauseDuration));
    }

    public override void Exit()
    {
        Debug.Log("Enemy Turn: Exiting...");
    }

    IEnumerator EnemyThinkingRoutine(float pauseDuration)
    {
        Debug.Log("Enemy thinking...");
        yield return new WaitForSeconds(pauseDuration);

        Debug.Log("Enemy performs action");
        target.TakeDamage(UnityEngine.Random.Range(1, 4));
        EnemyTurnEnded?.Invoke();
        if (target.currentHealth > 0)
        {
            StateMachine.ChangeState<PlayerTurnGameState>();
        }
        
    }
}
