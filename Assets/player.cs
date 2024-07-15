using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class player : MonoBehaviour
{
    private VideoPlayer play;
    // Start is called before the first frame update
    void Start()
    {
        play = GetComponent<VideoPlayer>();
    }

    public void playing()
    {
        play.Play();
    }

    public void pausing()
    {
        play.Pause();
    }
}
