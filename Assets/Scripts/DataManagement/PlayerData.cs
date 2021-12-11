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
    public bool PlayerGenderFemale { get; private set; }
    public float PlayerArmor { get; private set; }//calculation calls this physical resistance not armor
    public float PlayerMagicRestistance { get; private set; }
    public float PlayerLuck { get; private set; }
    public List<GameObject> PlayerInventory = new List<GameObject>();

    public PlayerData()
    {
        PlayerHealth = 10f;
        PlayerMaxHealth = 10f;
        PlayerArmor = 0f;
        PlayerMagicRestistance = 0f;
        PlayerLuck = 1f;
        PlayerSpeed = 1f;
        PlayerExperience = 0;
        PlayerName = "Steve";
        PlayerGenderMale = true;
        PlayerGenderFemale = false;
    }
    /// <summary>
    /// 0=M,1=F,2=M/F,3=none
    /// </summary>
    /// <param name="genderIndex"></param>
    public void SetPlayerGender(int genderIndex)
    {
        if (genderIndex == 0)
        {
            PlayerGenderMale = true;
            PlayerGenderFemale = false;
        }
        else if (genderIndex == 1)
        {
            PlayerGenderMale = false;
            PlayerGenderFemale = true;
        }
        else if (genderIndex == 2)
        {
            PlayerGenderMale = true;
            PlayerGenderFemale = true;
        }
        else
        {
            PlayerGenderMale = false;
            PlayerGenderFemale = false;
        }
    }

    public void SetPlayerName(string name)
    {
        PlayerName = name;
    }
}
