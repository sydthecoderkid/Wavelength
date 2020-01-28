using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginCombat : MonoBehaviour
{
    public static bool combatstarted; 

    public GameObject musicplayer;

    public GameObject combatbarholder;

    public GameObject wavelength;

    public GameObject wave; 

    public static bool effectrun;

       public GameObject progressbar;
    // Start is called before the first frame update
    void Start()
    {
        if(combatstarted){
        loadmusic();
        loadwavelength();
        }
    }

    // Update is called once per frame
    void Update()
    {
     if(DisplayDialogue.engagecombat && !combatstarted){
         loadeffect();
     }   
    }

    public void loadmusic(){
        this.musicplayer.SetActive(true);
    }

    public void loadwavelength(){
      combatbarholder.SetActive(true);
      wavelength.SetActive(true);
      progressbar.SetActive(true);
      wave.SetActive(false);
    }

    public void loadeffect(){
        wave.SetActive(true);
        effectrun= true;
    }
    
    
}
