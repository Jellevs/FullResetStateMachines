using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTile : Tile
{
    private readonly int _starsValue = 1;
    public override bool ActivateOnPass => true;

    public override void ActivateTile(Player player)
    {
        player.Stars += _starsValue;
    }
}
