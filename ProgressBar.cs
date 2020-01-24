using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    public GameObject progressbar;
    private float time;

    public float positionx;

    public float positiony;

    public float endbound;

    public AudioSource musicwave;

    public static bool wavelengthdone;

    public Animator failanim;

    public float holdpositon;

public bool changedcolor;
    public float timer2;
    // Start is called before the first frame update
    void Start()
    { 
         holdpositon = positionx;
         failanim= this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer2 += Time.deltaTime;
          progressbar.transform.position = new Vector2(positionx, positiony);

        time += Time.deltaTime;
        if(musicwave.isPlaying){
        positionx += 0.006f;
        }
        if(positionx >= endbound){
            positionx =  holdpositon;
            wavelengthdone = true;
        }

        if(CheckClicks.miss){
            onmiss();
        }
        if( changedcolor == true && timer2 >= 0.2f){
          progressbar.GetComponent<SpriteRenderer>().color = Color.yellow;
          changedcolor = false;
        }
    }

       public void onmiss(){
           progressbar.GetComponent<SpriteRenderer>().color = Color.red;
        this.failanim.Play("Progressbarfailanim ");
        timer2 = 0;
        changedcolor = true;
        CheckClicks.miss = false;
        
    }

    
}
