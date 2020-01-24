using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckClicks : MonoBehaviour
{

public static ProgressBar progressBar;
    public static float time = 0;
    public static int misses;

    public static bool miss;
    public static int succesess;



    // Start is called before the first frame updat
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(BeginCombat.combatstarted){
        checkingclicks();
        }
    } 

    public static void checkingclicks(){
           if(Input.GetMouseButtonDown(0) && time > 0.3 && time <= 0.5f){
               Debug.Log("Hit!");
               succesess++;
                       time = 0;
        }
        else if(Input.GetMouseButtonDown(0) && time > 0.5f || Input.GetMouseButtonDown(0) && time < 0.3f){
            Debug.Log("Miss!");
            miss = true;
            misses++;
                    time = 0;
        }
    }
 
}
