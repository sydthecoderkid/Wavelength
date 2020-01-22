using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CombatScreen : MonoBehaviour
{ 
    public TextMeshProUGUI text;
    public GameObject textholder;
    public GameObject button;
    
    private string enemyname;


    // Start is called before the first frame update
    void Start(){
        loadnames();

    }

    // Update is called once per frame
    void Update()
    {
             text.faceColor = UnityEngine.Color.blue;
             if(ProgressBar.wavelengthdone){
                 button.SetActive(true);
                 textholder.SetActive(true);
                 
                 
             }
        
    }

    private void loadnames(){
        if(CurrentScene.lastscene.Equals("Road#1")){
            enemyname = "Bradley";
        }

        text.text = enemyname + "'s Wavelength";
    }
}
