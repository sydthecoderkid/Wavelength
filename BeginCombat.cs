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

    public static bool won;

    public static bool loss;

       public GameObject progressbar;
    // Start is called before the first frame update
    void Start()
    {
        if(combatstarted){
        loadmusic(true);
        loadwavelength(true);
        }
 
    }

    // Update is called once per frame
    void Update()
    {
     if(DisplayDialogue.engagecombat && !combatstarted && !CheckClicks.combatended){
         loadeffect(true);
     }   
      if(CheckClicks.combatended){
            loadmusic(false);
            loadwavelength(false);
            loadeffect(false);
            
        }
    }

    public void loadmusic(bool condition){
        this.musicplayer.SetActive(condition);
    }

    public void loadwavelength(bool condition){
      combatbarholder.SetActive(condition);
      wavelength.SetActive(condition);
      progressbar.SetActive(condition);
    }

    public void loadeffect(bool condition){
        wave.SetActive(condition);
        effectrun= true;
    }

    public static void winorloss(bool woncombat){
         if(woncombat){
             won = true;
         }
         else if (!woncombat){
             won = false;
         }
    }
    
    
}
