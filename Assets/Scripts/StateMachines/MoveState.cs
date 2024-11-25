using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
    private GameController controller = GameController.GameInstance;
    public override void Enter()
    {

    }
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (controller.ActivePlayerList[controller.currentPlayerIndex].Move(Direction.LEFT))
            {
                controller.DecrementRoll();
                if (controller.DiceRoll != 0)
                {
                    Debug.Log(controller.DiceRoll);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (controller.ActivePlayerList[controller.currentPlayerIndex].Move(Direction.RIGHT))
            {
                controller.DecrementRoll();
                if (controller.DiceRoll != 0)
                {
                    Debug.Log(controller.DiceRoll);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (controller.ActivePlayerList[controller.currentPlayerIndex].Move(Direction.UP))
            {
                controller.DecrementRoll();
                if (controller.DiceRoll != 0)
                {
                    Debug.Log(controller.DiceRoll);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (controller.ActivePlayerList[controller.currentPlayerIndex].Move(Direction.DOWN))
            {
                controller.DecrementRoll();
                if (controller.DiceRoll != 0)
                {
                    Debug.Log(controller.DiceRoll);
                }

            }
        }
    }
    public override void Exit()
    {

    }
}
