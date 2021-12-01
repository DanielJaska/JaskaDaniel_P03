using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealState : EntityState
{
    [SerializeField] Text _stateTextUI = null;
    [SerializeField] Entity _target = null;

    [SerializeField] AudioClip audioClip;

    public override void Enter()
    {
        PlayerEntity.skillPoints -= 2;
        Debug.Log("Player Attacks");
        _stateTextUI.text = "Player Attacks";
        //StateMachine.ChangeState<PlayerTurnGameState>();
        //_activated = true;
        _target.Heal(-5);
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
