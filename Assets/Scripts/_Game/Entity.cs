using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Entity : MonoBehaviour
{
    [SerializeField] int _maxHealth = 10;
    public int currentHealth = 10;

    [SerializeField] protected StateMachine stateMachine;
    public Text healthText;


    public virtual void TakeDamage(int value)
    {
        currentHealth = Mathf.Clamp(currentHealth - value, 0, _maxHealth);

        UpdateHealth();
        
    }

    public void Heal(int value)
    {
        TakeDamage(value);
        stateMachine.ChangeState<EnemyTurnState>();
    }

    public virtual void UpdateHealth()
    {
        healthText.text = currentHealth.ToString() + "/" + _maxHealth.ToString();
    }
}
