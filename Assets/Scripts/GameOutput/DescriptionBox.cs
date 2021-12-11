using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DescriptionBox : MonoBehaviour
{
    public TextMeshProUGUI TextFieldTMP;
    public DungeonHandler _dungeonHandler;
    public Animator animator;
    public void DescribeRoom(Room room)
    {
        animator.SetBool("IsOpen", true);
        TextFieldTMP.SetText(room.DescribeRoom());
    }
    public void ExitRoom()
    {
        animator.SetBool("IsOpen", false);
        TextFieldTMP.SetText("");
    }

    public void Awake()
    {
        animator.SetBool("IsOpen", false);
        _dungeonHandler.NewRoom();
        DescribeRoom(_dungeonHandler.Room);
    }

}
