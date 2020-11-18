using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class DisplaySelectedButton : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public GameObject trianglePNG;

    void Start()
    {
        trianglePNG.SetActive(false);
    }

    public void OnSelect(BaseEventData eventData)
    {
        trianglePNG.SetActive(true);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        trianglePNG.SetActive(false);
    }
    
}
