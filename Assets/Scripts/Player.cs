using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : EntityBase
{
    private PlayerData _playerData;
    public int Experience { get; private set; }
    public float Luck { get; private set; }
    private void Start()
    {
        PlayerDataManager.Instance.LoadPlayerData("Player initialization");
        InvokeRepeating("AutoSavePlayerData", 30f, 30f);
        _playerData = PlayerDataManager.Instance.Data;
        Health = _playerData.PlayerHealth;
        MaxHealth = _playerData.PlayerMaxHealth;
        PhysicalResistance = _playerData.PlayerArmor;
        MagicRestistance = _playerData.PlayerMagicRestistance;
        Speed = _playerData.PlayerSpeed;
        Experience = _playerData.PlayerExperience;
        Luck = _playerData.PlayerLuck;
    }

    public void ReloadPlayerData(string source)
    {
        PlayerDataManager.Instance.LoadPlayerData(source);
    }
    public void SavePlayerData(string source)
    {
        PlayerDataManager.Instance.SavePlayerData(source);
    }
    private void AutoSavePlayerData()
    {
        _playerData.SetPlayerData(Health, MaxHealth, PhysicalResistance, MagicRestistance, Speed, Experience, Luck);
        PlayerDataManager.Instance.SavePlayerData("autosave");
    }
    
    public void SetPlayerGender(int genderIndex)
    {
        _playerData.SetPlayerGender(genderIndex);
    }

    public void RenamePlayer(string name)
    {
        _playerData.SetPlayerName(name);
    }
}
