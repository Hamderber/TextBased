using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonHandler : MonoBehaviour
{
    public RoomGenerator _roomGenerator = new RoomGenerator();
    public Room Room;
    public DescriptionBox _descriptionBox;

    public void NewRoom()
    {
        Room = _roomGenerator.GenerateNewRoom();
    }

    public void GetRoomDescription()
    {
        _descriptionBox.DescribeRoom(Room);
    }
}
