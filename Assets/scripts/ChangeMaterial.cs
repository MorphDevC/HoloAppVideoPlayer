using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Texture[] Textures;
    public GameObject SplashScreen;
    private static int __tempTextIndex;

    private void Awake()
    {
        SplashScreen.SetActive(false);
    }

    public void ChangeSplashScreen()
    {
        SplashScreen.gameObject.SetActive(true);
        string tempString = gameObject.name.Remove(0,5);
        __tempTextIndex = Convert.ToInt32(tempString);
        SplashScreen.GetComponent<Material>().mainTexture = Textures[__tempTextIndex];
    }

    public void SplashScreenOnPlay()
    {
        SplashScreen.SetActive(false);
    }

    public void SplashScreenOnPause()
    {
        SplashScreen.SetActive(true);
        SplashScreen.GetComponent<Material>().mainTexture = Textures[__tempTextIndex];
    }
    
}
