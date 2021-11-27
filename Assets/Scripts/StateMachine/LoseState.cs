using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseState : GameState
{
    [SerializeField] Text end_txt;

    bool _activated = false;

    public override void Enter()
    {
        end_txt.text = "You Lose";
        end_txt.gameObject.SetActive(true);

        //_playerTurnCount++;
        //_playerTurnTextUI.text = "Player Turn: " + _playerTurnCount.ToString();
        //StateMachine.Input.PressedConfirm += OnPressedConfirm;
        //StateMachine.Input.PressedCancel += OnPressedCancel;
        Debug.Log("Lose");
        _activated = true;
        //StateMachine.Input.PressedRight += OnPressedRight;
    }

    public override void Tick()
    {
        if (_activated == false)
        {
            _activated = true;
            //StateMachine.ChangeState<PlayerTurnGameState>();
        }
    }

    public override void Exit()
    {
        _activated = false;
        end_txt.gameObject.SetActive(false);
        //StateMachine.Input.PressedCancel -= OnPressedCancel;
        //_playerTurnTextUI.gameObject.SetActive(false);
        //StateMachine.Input.PressedConfirm -= OnPressedConfirm;
        //StateMachine.Input.PressedRight -= OnPressedRight;
        Debug.Log("Player Lose State Exiting...");
    }

    //public void OnPressedCancel()
    //{
    //    StateMachine.ChangeState<SetupGameState>();
    //}

    //public void OnPressedRight()
    //{
    //    StateMachine.ChangeState<SetupGameState>();
    //}
}
