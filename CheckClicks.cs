using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CheckClicks : MonoBehaviour
{

public static ProgressBar progressBar;
    public float time = 0;

     public float time2 = 0;

    public float songbpm;

    public float songbps;
    public static int misses;

    public static bool miss;
    public static int succesess;
    
    public int clicks;

    public float timetoclick;

    public float timebetweenclicks;

    




    // Start is called before the first frame updat
    
    void Start()
    {
       this.songbps =   this.songbpm /60;
       this.songbps = Mathf.Round(songbps);
       timetoclick = 1/songbps;
       timebetweenclicks += Time.deltaTime;
       

    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;
        timebetweenclicks += Time.deltaTime;
        if(BeginCombat.combatstarted){
        checkingclicks();
        }

        
    } 

    public void checkingclicks(){
        if(Input.GetMouseButtonDown(0)){
            if(timebetweenclicks > 0.2f){
            timebetweenclicks = 0;
           
             clicks++;
            }
            else{
                Debug.Log("miss- too fast!");
            miss = true;
            misses++;
            clicks = 0;
            time = 0;
            }
        }
      
        if(time > timetoclick && time < 1 && clicks == songbps){
            Debug.Log("hit!");
            time = 0;
            clicks =0;
            succesess++;
        }
        else if (time > 1 && Input.GetMouseButtonDown(0) || time == 1 && clicks != songbps ){
             Debug.Log("miss");
            miss = true;
            misses++;
            clicks = 0;
            time = 0;
        }
    }


 
}
