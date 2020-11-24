using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Flags]
public enum EquipSlots
{
    None = 0,
  Primary = 1 << 0,   // usually a weapon (gun, etc)
  Secondary = 1 << 1,  // usually a pistol, but could be another gun
  Head = 1 << 2,    // helmet, hat, etc
  Body = 1 << 3,    // body armor
  Accessory = 1 << 4  // ring, belt, etc
}
