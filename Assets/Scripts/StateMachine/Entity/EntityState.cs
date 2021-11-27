using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityState : State
{
    protected EntitySM _stateMachine;
    public EntitySM StateMachine { get { return _stateMachine; } private set { _stateMachine = value; } }

    private void Awake()
    {
        StateMachine = GetComponent<EntitySM>();
    }
}
