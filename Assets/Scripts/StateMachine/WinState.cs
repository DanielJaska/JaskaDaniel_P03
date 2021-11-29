using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinState : GameState
{
    [SerializeField] Text end_txt;

    bool _activated = false;

    public override void Enter()
    {
        end_txt.text = "You Win";
        end_txt.gameObject.SetActive(true);

        //_playerTurnCount++;
        //_playerTurnTextUI.text = "Player Turn: " + _playerTurnCount.ToString();
        //StateMachine.Input.PressedConfirm += OnPressedConfirm;
        //StateMachine.Input.PressedCancel += OnPressedCancel;
        Debug.Log("Win");
        //_activated = true;
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
        //_playerTurnTextUI.gameObject.SetActive(false);
        //StateMachine.Input.PressedConfirm -= OnPressedConfirm;
        //StateMachine.Input.PressedCancel -= OnPressedCancel;
        //end_txt.gameObject.SetActive(false);
        //Debug.Log("Player Win State Exiting...");
        //_activated = false;
        //StateMachine.Input.PressedRight -= OnPressedRight;
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
