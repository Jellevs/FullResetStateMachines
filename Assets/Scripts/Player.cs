using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public Tile CurrentTile;
    private List<Item> _inventory;
    private readonly int _moveSpeed = 2;

    private int _coins = 0;
    private int _stars = 0;

    public void Awake()
    {
        _inventory = new List<Item>();
    }

    public int Coins
    {
        get { return _coins; }
        set
        {
            if (value < 0)
            {
                _coins = 0;
            }
            else
            {
                _coins = value;
            }
        }
    }

    /*
    * Set and get the Stars for the current player
    */
    public int Stars
    {
        get { return _stars; }
        set
        {
            _stars = value;
        }
    }


    public void ActivateTile()
    {
        CurrentTile.ActivateTile(this);
    }

    public bool Move(Direction direction)
    {
        Tile NewTile = CurrentTile.NextTile(direction);     // Select the next tile

        if (NewTile == null)    // Checks if player can moves to the next tile
        {
            return false;
        }

        CurrentTile = NewTile;

        if (CurrentTile.ActivateOnPass)
        {
            ActivateTile();
            GameController.GameInstance.DiceRoll++;
        }


        //gameObject.transform.DOMove(CurrentTile.transform.position, _moveSpeed);    // Move to the new tile
        Vector3 targetPosition = new Vector3(NewTile.transform.position.x,
                                          1,
                                          NewTile.transform.position.z);

        gameObject.transform.DOMove(targetPosition, _moveSpeed);    // Move to the new tile

        return true;
    }

}
