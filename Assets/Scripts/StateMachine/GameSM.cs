using UnityEngine;

public class GameSM : StateMachine
{
    [SerializeField] InputController _input;
    public InputController Input => _input;

    // Start is called before the first frame update
    void Start()
    {
        ChangeState<SetupGameState>();
    }
}
