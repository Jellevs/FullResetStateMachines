using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * ItemStore Tile which does activate on pass
 */
public class StoreTile : Tile
{
    public override bool ActivateOnPass => true;

    public override void ActivateTile(Player player)    // Activate the Item Store tile which gets called in the Player
    {
        UIManager.UIInstance.EnterStoreUIState();
    }

}
