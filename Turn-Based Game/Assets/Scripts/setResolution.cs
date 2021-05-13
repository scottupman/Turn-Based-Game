using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution((int)Screen.width, (int)Screen.height, true);
    }
}
