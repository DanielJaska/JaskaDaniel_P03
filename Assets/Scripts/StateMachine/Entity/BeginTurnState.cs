using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginTurnState : EntityState
{
    [SerializeField] Text _stateTextUI = null;
    [SerializeField] GameObject Options = null;

    public override void Enter()
    {
        Debug.Log("Player Turn Start Begin");
        _stateTextUI.text = "Select Option";
        //StateMachine.ChangeState<PlayerTurnGameState>();
        //_activated = true;
        Options.SetActive(true);
    }

    public override void Tick()
    {

    }

    public override void Exit()
    {
        Options.SetActive(false);
        StateMachine.ChangeState<AttackState>();
        Debug.Log("Player Turn Start End");
    }
}
