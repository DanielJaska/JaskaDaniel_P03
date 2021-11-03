using UnityEngine;
using UnityEngine.UI;

public class PlayerTurnGameState : GameState
{
    [SerializeField] Text _playerTurnTextUI = null;
    [SerializeField] Button _playerAttackButtonUI = null;

    int _playerTurnCount = 0;

    [SerializeField] Entity target;

    public override void Enter()
    {
        Debug.Log("Player Turn ...Entering");
        _playerTurnTextUI.gameObject.SetActive(true);
        _playerAttackButtonUI.gameObject.SetActive(true);

        _playerTurnCount++;
        _playerTurnTextUI.text = "Player Turn: " + _playerTurnCount.ToString();
        StateMachine.Input.PressedCancel += OnPressedCancel;
    }

    public override void Exit()
    {
        _playerTurnTextUI.gameObject.SetActive(false);
        _playerAttackButtonUI.gameObject.SetActive(false);
        StateMachine.Input.PressedCancel -= OnPressedCancel;

        Debug.Log("Player Turn Exiting...");
    }

    public void OnPressedConfirm()
    {
        target.TakeDamage(UnityEngine.Random.Range(1, 4));
        if (target.currentHealth > 0)
        {
           StateMachine.ChangeState<EnemyTurnState>();
        }
       
    }

    public void OnPressedCancel()
    {
        StateMachine.ChangeState<SetupGameState>();
    }
}
