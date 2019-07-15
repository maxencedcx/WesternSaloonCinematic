using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MyTimeline : MonoBehaviour
{
    PlayableDirector playableDirector;

    void Start()
    {
        Cursor.visible = false;
        playableDirector = GetComponent<PlayableDirector>();
        playableDirector.Play();
    }
}
