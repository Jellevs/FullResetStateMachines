using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusCoinTile : Tile
{
    private readonly int _coinValue = 5;
    
    public override void ActivateTile(Player player)
    {
        player.Coins += _coinValue;
    }
}
