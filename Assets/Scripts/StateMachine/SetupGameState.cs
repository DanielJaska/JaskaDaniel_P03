using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupGameState : GameState
{
    [SerializeField] int _startingValue = 10;
    [SerializeField] int _numberOfPlayers = 2;

    [SerializeField] Entity[] entities;

    bool _activated = false;

    public override void Enter()
    {
        Debug.Log("Setup: ...Entering");
        Debug.Log("Creating" + _numberOfPlayers + " players.");
        Debug.Log("Creating starting value " + _startingValue + " value.");
        PlayerTurnGameState._playerTurnCount = 0;
        foreach(Entity entity in entities)
        {
            entity.currentHealth = _startingValue;
            entity.UpdateHealth();
        }

        //StateMachine.ChangeState<PlayerTurnGameState>();
        //_activated = true;
    }

    public override void Tick()
    {
        if(_activated == false)
        {
            _activated = true;
            StateMachine.ChangeState<PlayerTurnGameState>();
        }
    }

    public override void Exit()
    {
        _activated = false;
        Debug.Log("Setup: Exiting...");
    }
}
