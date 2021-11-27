using UnityEngine;
using UnityEngine.UI;

public class PlayerTurnGameState : GameState
{
    
    [SerializeField] Button _playerAttackButtonUI = null;

    public static int _playerTurnCount = 0;

    [SerializeField] EntityState player;

    public override void Enter()
    {
        player.StateMachine.ChangeState<BeginTurnState>();
        //Debug.Log("Player Turn ...Entering");
        //_playerTurnTextUI.gameObject.SetActive(true);
        //_playerAttackButtonUI.gameObject.SetActive(true);

        //_playerTurnCount++;
        //_playerTurnTextUI.text = "Player Turn: " + _playerTurnCount.ToString();
        //StateMachine.Input.PressedCancel += OnPressedCancel;
        //StateMachine.Input.PressedRight += OnPressedRight;

    }

    public override void Exit()
    {
        //_playerTurnTextUI.gameObject.SetActive(false);
        //_playerAttackButtonUI.gameObject.SetActive(false);
        //StateMachine.Input.PressedCancel -= OnPressedCancel;
        //StateMachine.Input.PressedRight -= OnPressedRight;

        //Debug.Log("Player Turn Exiting...");
    }

    //public void OnPressedConfirm()
    //{
    //    target.TakeDamage(UnityEngine.Random.Range(1, 4));
    //    if (target.currentHealth > 0)
    //    {
    //       StateMachine.ChangeState<EnemyTurnState>();
    //    }
       
    //}

    //public void OnPressedRight()
    //{
    //    StateMachine.ChangeState<SetupGameState>();
    //}

    //public void OnPressedCancel()
    //{
    //    Application.Quit();
    //}
}
