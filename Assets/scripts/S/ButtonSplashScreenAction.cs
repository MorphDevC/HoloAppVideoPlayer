using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine.UI;

public class ButtonSplashScreenAction : MonoBehaviour
{
    public int Index;

    private void Start()
    {
        gameObject.GetComponent<ButtonConfigHelper>().OnClick.AddListener(ChangeSplashScreenImg);
    }

    public void ChangeSplashScreenImg()
    {
        ChangeMaterial.Instance.SplashScreen.SetActive(true);
        ChangeMaterial.Instance.SplashScreen.GetComponent<MeshRenderer>().material.mainTexture =ChangeMaterial.Instance.Texture2Ds[Index];
    }
}
