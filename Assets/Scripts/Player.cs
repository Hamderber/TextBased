using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerData _playerData;
    private void Start()
    {
        PlayerDataManager.Instance.LoadPlayerData("Player initialization");
        _playerData = PlayerDataManager.Instance.Data;
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
