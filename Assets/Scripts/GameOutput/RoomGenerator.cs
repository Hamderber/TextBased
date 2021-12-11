using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator
{
    public Room GenerateNewRoom(int seed)
    {
        Room room = new Room(seed);
        return room;
    }
    public Room GenerateNewRoom()
    {
        Room room = new Room(true);
        return room;
    }
}
