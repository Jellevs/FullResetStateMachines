using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTurnState : State
{
    public override void Enter()
    {
        Debug.Log("It's " + GameController.GameInstance.ActivePlayerList[GameController.GameInstance.currentPlayerIndex].name + " turn!");
    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameController.GameInstance.ThrowDice();
        }
    }
    public override void Exit()
    {

    }
}
