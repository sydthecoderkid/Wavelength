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



    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
             text.faceColor = UnityEngine.Color.red;
             if(ProgressBar.wavelengthdone){
                 button.SetActive(true);
                 textholder.SetActive(true);
             }
        
    }
}
