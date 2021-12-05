using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public float PlayerHealth { get; private set; }
    public float PlayerMaxHealth { get; private set; }
    public float PlayerSpeed { get; private set; }
    public int PlayerExperience { get; private set; }
    public string PlayerName { get; private set; }
    public bool PlayerGenderMale { get; private set; }
    public float PlayerArmor { get; private set; }
    public float PlayerEffectResistance { get; private set; }
    public float PlayerLuck { get; private set; }
    public List<GameObject> PlayerInventory = new List<GameObject>();

    public PlayerData()
    {
        PlayerHealth = 10f;
        PlayerMaxHealth = 10f;
        PlayerSpeed = 1f;
        PlayerExperience = 0;
        PlayerName = "Steve";
        PlayerGenderMale = true;
    }

    /// <summary>
    /// true = male, false = female. There are only two genders as there should be #cancel_kevin
    /// </summary>
    public void SetPlayerGender(bool gender)
    {
        PlayerGenderMale = gender;
    }

    public void SetPlayerName(string name)
    {
        PlayerName = name;
    }
}
