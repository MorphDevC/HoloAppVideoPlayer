using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class setLenguage : MonoBehaviour
{
    // Start is called before the first frame update
    public Languages[] languages;
    public TextMesh Header;
    public TextMesh Description;
    public TextMesh SlideDescription;
    public TextMesh Congratulations;
    public TextMesh PassText;


         void Start()
    {
        if (PlayerPrefs.HasKey("lang"))
        {
            int index = PlayerPrefs.GetInt("lang");
            CurrentLanguage(index);
        }

    }


         public void CurrentLanguage(int index)
    {
        Header.text = languages[index].Header;
        Description.text = languages[index].Description;
        SlideDescription.text = languages[index].SlideDescription;
        Congratulations.text = languages[index].Congratulations;
        PassText.text = languages[index].PassText;
        PlayerPrefs.SetInt("lang", index);
    }
}
