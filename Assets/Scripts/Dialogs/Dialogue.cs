using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public bool isDestroyable;
    public bool isMissionNeed;
   
    public GameObject gameObjectWithMission;
    public string name;

    [TextArea(3, 10)]
    public string[] sentences;
}
    
