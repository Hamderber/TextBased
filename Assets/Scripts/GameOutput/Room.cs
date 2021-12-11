using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    public string roomContents;

    public Room(bool debug)
    {
        if (debug)
        {
            roomContents = Random.Range(-10, 10).ToString();
        }
    }

    public Room(int seed)
    {
        //do something
    }
    public string DescribeRoom()
    {
        return roomContents;
    }
}
