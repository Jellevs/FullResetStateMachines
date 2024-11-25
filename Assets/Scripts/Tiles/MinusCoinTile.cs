using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusCoinTile : Tile
{
    private readonly int _coinValue = -3;
    
    public override void ActivateTile(Player player)
    {
        player.Coins += _coinValue;
    }
}
