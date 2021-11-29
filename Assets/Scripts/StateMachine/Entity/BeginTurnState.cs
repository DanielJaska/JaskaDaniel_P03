using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeginTurnState : EntityState
{
    [SerializeField] PlayerEntity player;
    [SerializeField] Text _stateTextUI = null;
    [SerializeField] GameObject Options = null;

    public override void Enter()
    {
        Debug.Log("Player Turn Start Begin");
        player.AddSP();
        _stateTextUI.text = "Select Option";
        //StateMachine.ChangeState<PlayerTurnGameState>();
        //_activated = true;

        if (PlayerEntity.skillPoints  >= 2)
        {
            Options.transform.GetChild(1).GetComponent<Button>().interactable = true;
        } else
        {
            Options.transform.GetChild(1).GetComponent<Button>().interactable = false;
        }

        if (PlayerEntity.skillPoints >= 4)
        {
            Options.transform.GetChild(2).GetComponent<Button>().interactable = true;
        }
        else
        {
            Options.transform.GetChild(2).GetComponent<Button>().interactable = false;
        }

        Options.SetActive(true);
    }

    public override void Tick()
    {

    }

    public void Choice(int index)
    {
        switch (index)
        {
            case 0:
                StateMachine.ChangeState<AttackState>();
                break;
            case 1:
                StateMachine.ChangeState<HealState>();
                break;
            case 2:
                StateMachine.ChangeState<CleaveState>();
                break;
        }
    }

    public override void Exit()
    {
        Options.SetActive(false);
        
        Debug.Log("Player Turn Start End");
    }
}
