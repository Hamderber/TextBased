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
    public void SavePlayerData(string source)
    {
        PlayerDataManager.Instance.SavePlayerData(source);
    }
    public void SwapPlayerGender(bool gender)
    {
        _playerData.SetPlayerGender(gender);
    }

    public void RenamePlayer(string name)
    {
        _playerData.SetPlayerName(name);
    }
}
