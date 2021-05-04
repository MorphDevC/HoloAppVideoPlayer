using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        //gameObject.transform.GetChild(0).gameObject.AddComponent<ButtonControl>().Index=0;
        int templength = gameObject.transform.childCount;


        for (int i = 0; i < templength; i++)
        {
            gameObject.transform.GetChild(i).gameObject.AddComponent<ButtonControl>().Index=i;

            
        }

    }

 
    
}
