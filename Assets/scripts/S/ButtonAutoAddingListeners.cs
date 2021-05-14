using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAutoAddingListeners : MonoBehaviour
{
    public GameObject VideoPlayerCrutch;
    public GameObject SplashScreen;
    private void Awake()
    {
        SplashScreen.SetActive(false);
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            gameObject.transform.GetChild(i).gameObject.AddComponent<ButtonSplashScreenAction>().Index = i;
        }
        
    }
}
