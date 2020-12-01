using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechAbilityPower : BaseAbilityPower
{
    public int level;
    protected override int GetBaseAttack()
    {
        return GetComponentInParent<Stats>()[StatTypes.AAT];
    }
    protected override int GetBaseDefense(Unit target)
    {
        return target.GetComponent<Stats>()[StatTypes.ADF];
    }
    protected override int GetPower()
    {
        return level;
    }
}
