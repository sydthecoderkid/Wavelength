using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    private GameObject progressbar;
    private float time;

    private float position;

    public AudioSource musicwave;

    public static bool wavelengthdone;
    // Start is called before the first frame update
    void Start()
    { 
        progressbar = this.gameObject;
        position = -0.99f;
    }

    // Update is called once per frame
    void Update()
    {
          transform.position = new Vector2(position, -0.094f);
        time += Time.deltaTime;
        if(musicwave.isPlaying){
        position += 0.006f;
        }
        if(position >= 1.6f){
            position = -0.99f;
            wavelengthdone = true;
        }
    }
}
