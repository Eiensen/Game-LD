using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatheringMetalls : MonoBehaviour
{
    public Text ironCountText;
    private int ironCount = 0;


    private void Update()
    {
        ironCountText.text = IronCount.ToString();
    }


    public int IronCount 
    { 
        get { return ironCount; }
        set { ironCount = value; }
    }

}
