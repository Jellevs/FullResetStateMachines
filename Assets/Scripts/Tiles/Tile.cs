using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile : MonoBehaviour
{
    [SerializeField] public Tile[] _tileList;  // List with all tiles
    public virtual bool ActivateOnPass => false;

    public Tile NextTile(Direction direction) => _tileList[(int)direction];     // returns the next Tile in the given direction

    public abstract void ActivateTile(Player player);
}
