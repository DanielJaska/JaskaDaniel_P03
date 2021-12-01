using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackState : EntityState
{
    [SerializeField] Text _stateTextUI = null;
    [SerializeField] Entity _target = null;

    [SerializeField] AudioClip audioClip = null;

    public override void Enter()
    {
        Debug.Log("Player Attacks");
        _stateTextUI.text = "Player Attacks";
        //StateMachine.ChangeState<PlayerTurnGameState>();
        //_activated = true;
        _target.TakeDamage(Random.Range(1, 4));
        AudioHelper.PlayClip2D(audioClip, 1f);
    }

    public override void Tick()
    {

    }

    public override void Exit()
    {
        Debug.Log("Player Attacks End");
    }
}
