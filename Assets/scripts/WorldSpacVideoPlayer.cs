using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using System.Linq;

public class WorldSpacVideoPlayer : MonoBehaviour
{
    public Renderer playButtonRenderer;
    public VideoClip[] videoClips;
    public GameObject[] Buttons;

    private VideoPlayer videoPlayer;
    private int videoClipIndex = 0;




    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer> ();

    }

    // Use this for initialization
    void Start () 
    {
        videoPlayer.targetTexture.Release ();
        videoPlayer.clip = videoClips [0];

       
        
    }

    // Update is called once per frame
    void Update () 
    {
        if (videoPlayer.isPlaying) 
        {
            SetCurrentTimeUI ();
            
        }
    }

    public void SetNextClip()
    {
        videoClipIndex++;

        

        videoPlayer.clip = videoClips [videoClipIndex];
        SetTotalTimeUI ();
        videoPlayer.Play ();

    }

   

    void SetCurrentTimeUI()
    {
        string minutes = Mathf.Floor ((int)videoPlayer.time / 60).ToString ("00");
        string seconds = ((int)videoPlayer.time % 60).ToString ("00");

       
    }

    void SetTotalTimeUI()
    {
        string minutes = Mathf.Floor ((int)videoPlayer.clip.length / 60).ToString ("00");
        string seconds = ((int)videoPlayer.clip.length % 60).ToString ("00");


    }

    double CalculatePlayedFraction()
    {
        double fraction = (double)videoPlayer.frame / (double)videoPlayer.clip.frameCount;
        return fraction;
    }
}
