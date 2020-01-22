using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginCombat : MonoBehaviour
{
    public static bool combatstarted; 

    public GameObject musicplayer;

    public GameObject combatbarholder;

    // Start is called before the first frame update
    void Start()
    {
        if(combatstarted){
        loadmusic();
        loadwavelength();
        CheckClicks.checkingclicks();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadmusic(){
        this.musicplayer.SetActive(true);
    }

    public void loadwavelength(){
      combatbarholder.SetActive(true);
    }
}
