using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Entity : MonoBehaviour
{
    public int currentHealth = 10;

    public bool isPlayer = false;

    [SerializeField] StateMachine stateMachine;
    public Text healthText;
    

    public void TakeDamage(int value)
    {
        currentHealth = Mathf.Clamp(currentHealth - value, 0, 10);
        
        healthText.text = currentHealth.ToString();
        

        if (currentHealth <= 0)
        {
            if (isPlayer == true)
            {
                stateMachine.ChangeState<LoseState>();
            } else
            {
                stateMachine.ChangeState<WinState>();
            }
        }
    }
}
