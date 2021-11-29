using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CleaveState : EntityState
{
    [SerializeField] Text _stateTextUI = null;
    [SerializeField] Entity _target = null;

    public override void Enter()
    {
        PlayerEntity.skillPoints -= 4;
        Debug.Log("Player Attacks");
        _stateTextUI.text = "Player Attacks";
        //StateMachine.ChangeState<PlayerTurnGameState>();
        //_activated = true;
        _target.TakeDamage(Random.Range(5, 8));
    }

    public override void Tick()
    {

    }

    public override void Exit()
    {
        Debug.Log("Player Attacks End");
    }
}
