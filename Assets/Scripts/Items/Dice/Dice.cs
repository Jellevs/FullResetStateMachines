using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Dice : Item
{
    public abstract int BeginValue { get; }
    public abstract int EndValue { get; }

    public int ThrowDice()
    {
        return Random.Range(BeginValue, EndValue + 1);
    }
}
