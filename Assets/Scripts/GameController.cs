using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController GameInstance;  // Singleton instance of the game
    private State currentState;

    public static Dice dice;    // The instance of the dice
    public int DiceRoll;
    public List<Player> ActivePlayerList;
    public int currentPlayerIndex { get; private set; } = 0;

    private void Awake()
    {
        GameInstance = this;

    }

    private void Start()
    {
        currentState = new StartTurnState();
        currentState.Enter();
        dice = new DefaultDice();
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Update();
    }

    public void DecrementRoll()
    {
        DiceRoll--;
        if (DiceRoll <= 0)
        {
            ActivePlayerList[currentPlayerIndex].ActivateTile();
            EndOfTurn();
        }
    }
    public void ChangeState(State newState)
    {
        // Exit the current state
        currentState.Exit();

        // Assign the new state and enter it
        currentState = newState;
        currentState.Enter();
    }

    public void EndOfTurn()
    {
        currentPlayerIndex = (currentPlayerIndex + 1) % ActivePlayerList.Count;
        ChangeState(new StartTurnState());
        UIManager.UIInstance.RefreshUI();
        CameraController.CameraInstance.SwitchPlayer(ActivePlayerList[currentPlayerIndex].transform);   // Switch camera to new player

    }
    public void ThrowDice()
    {
        DiceRoll = dice.ThrowDice();
        print(DiceRoll);
        currentState.Exit();
        currentState = new MoveState();
        currentState.Enter();
        
    }
}

public enum Direction
{
    LEFT = 0,
    UP = 1,
    RIGHT = 2,
    DOWN = 3
}