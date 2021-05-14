using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public List<Texture2D> Texture2Ds = new List<Texture2D>();
    public GameObject SplashScreen;

    private void Awake()
    {
        Instance = this;
        //gameObject.transform.GetChild(i).gameObject.AddComponent<ButtonSplashScreenAction>()
    }

    public void SetTextureOnPause()
    {
        SplashScreen.SetActive(true);
    }

    public void SetTextureOnPlay()
    {
        SplashScreen.SetActive(false);
    }

    public static ChangeMaterial Instance;

}
