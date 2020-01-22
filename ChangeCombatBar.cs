using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCombatBar : MonoBehaviour
{

    
    public GameObject combatbar1;

    public GameObject combatbar2;
    public GameObject combatbar3;
    public GameObject combatbar4;
    
    // Start is called before the first frame update

  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
      if(CheckClicks.misses >= 2){
          combatbar1.SetActive(true);
      }
      if(CheckClicks.misses >= 4){
          combatbar2.SetActive(true);
      }
      if(CheckClicks.misses >= 6){
          combatbar3.SetActive(true);
      }
      if(CheckClicks.misses >= 8){
          combatbar4.SetActive(true);
      }
    }


}
