using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultDice : Dice
{
    /* 
     * Throw default dice between 1 and 6
     */
    public override int BeginValue => 1;
    public override int EndValue => 6;
}
