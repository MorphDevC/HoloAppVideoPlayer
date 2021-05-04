using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    private int _index;

    public int Index { get => _index; set => _index = value; }


    public void Start()
    {

        Debug.Log(gameObject.name + " " + Index);

        switch (Index)
        {
            case 1:
                gameObject.GetComponent<Button>().onClick.AddListener(kek);
                break;
        }
    }
    public void kek()
    {

    }

    
    private void OnMouseDown()
    {
        Debug.Log(Index);
    }
}
    