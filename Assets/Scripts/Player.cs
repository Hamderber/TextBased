using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : EntityBase
{
    private PlayerData _playerData;
    private void Start()
    {
        PlayerDataManager.Instance.LoadPlayerData("Player initialization");
        _playerData = PlayerDataManager.Instance.Data;
        Health = _playerData.PlayerHealth;
        MaxHealth = _playerData.PlayerMaxHealth;
        PhysicalResistance = _playerData.PlayerArmor;
        MagicRestistance = _playerData.PlayerMagicRestistance;
        Speed = _playerData.PlayerSpeed;
    }

    public void ReloadPlayerData(string source)
    {
        PlayerDataManager.Instance.LoadPlayerData(source);
    }
    public void SavePlayerData(string source)
    {
        PlayerDataManager.Instance.SavePlayerData(source);
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
