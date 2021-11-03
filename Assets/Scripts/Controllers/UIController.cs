using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Text _enemyThinkingTextUI = null;

    private void OnEnable()
    {
        EnemyTurnState.EnemyTurnBegan += OnEnemyTurnBegan;
        EnemyTurnState.EnemyTurnEnded += OnEnemyTurnEnded;

    }

    private void OnDisable()
    {
        EnemyTurnState.EnemyTurnBegan -= OnEnemyTurnBegan;
        EnemyTurnState.EnemyTurnEnded -= OnEnemyTurnEnded;

    }

    private void Start()
    {
        _enemyThinkingTextUI.gameObject.SetActive(false);
    }

    void OnEnemyTurnBegan()
    {
        _enemyThinkingTextUI.gameObject.SetActive(true);
    }

    void OnEnemyTurnEnded()
    {
        _enemyThinkingTextUI.gameObject.SetActive(false);
    }
}
