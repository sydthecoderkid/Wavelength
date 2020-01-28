using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class DisplayDialogue : MonoBehaviour
{
    public  TextMeshProUGUI Dialog;
    private string empty;
    private string currentmessage;
    private string firstmessage;

    private string secondmessage;
    private string thirdmessage;
    private float time;
    private float secondtimer;
   private Scene scene;
    private int indexer;
    private int count = 0;
 
    private bool secondmessagedisplayed = false;
        public static bool engagecombat = false;
    private bool keepmessage = false;

    private bool dialogfinished = false;

     private bool switchmessage = false;

     private bool secondcharacter;

      private bool switchedcharacter = false;
      
     public static String currentscene;



     public GameObject textholder;
    float timetowrite;
    // Start is called before the first frame update
    void Start()
    {
     scene = SceneManager.GetActiveScene();
                currentscene = scene.name;
        this.loadmessages();
               keepmessage = false;
               dialogfinished = false;
               this.loadmessages();    
    }
    

    // Update is called once per frame
    void Update()
    {
         scene = SceneManager.GetActiveScene();
                currentscene = scene.name;
    if(BeginCombat.won){
               keepmessage = false;
               dialogfinished = false;
               switchmessage = false;
             count = 0;
             time = 0;
             secondtimer = 0;
               loadmessages();
               BeginCombat.won = false;
           }
      Dialog.text = empty;
     time += Time.deltaTime;
     secondtimer += Time.deltaTime;
     
     if(currentmessage != null){
     timetowrite = (0.09f * currentmessage.Length);
     }

     if(keepmessage && secondtimer >= timetowrite +2 && !dialogfinished && secondcharacter){ 
          empty = "";
           if(Dialog.text.Equals("")){
          Dialog.GetComponent<RectTransform>().localPosition = new Vector2(-115, 53);//Moves the text to Malcom
            switchedcharacter = true;
            count = 0;
            keepmessage = false;
             loadmessages();
           }
     }

if(currentmessage != null){
            indexer = currentmessage.Length;
}
     if(time >= 0.08 && currentmessage != null && !dialogfinished){
         displaytext();
         
     }
     if(dialogfinished && CheckClicks.combatended){
         WalkingScript.movementenabled = true;
     }
     if(secondtimer >= timetowrite +2 && !keepmessage){
         switchmessage = true;
     }
     if(secondtimer >= timetowrite +2 && keepmessage && engagecombat){
                  if(BeginCombat.effectrun){
        SceneManager.LoadScene("CombatScene");
       }
        CurrentScene.lastscene = currentscene;
     }

    }

    public void displaytext(){
        //this method is what makes the text look as though its being typed
        char[] holder;
      holder = currentmessage.ToCharArray(0,indexer); //Translates the given message into characters
      if(count != currentmessage.Length){
      empty += holder[count]; //Adds a character to the end of the displayed message
      count++;
      }
      if(switchmessage){
          nextmessage();
      }
             time = 0;
    }

    public void nextmessage(){
       empty = "";
       if(this.thirdmessage != null && secondmessagedisplayed == true){
           currentmessage = this.thirdmessage;
           keepmessage = true;
           
       }
        else if(this.thirdmessage == null && secondmessagedisplayed == true){
           currentmessage = this.secondmessage;
           keepmessage = true;
           dialogfinished = true; 
           if(!CheckClicks.combatended){
            engagecombat = true;
           }
       }
       else{
       currentmessage = this.secondmessage;
       secondmessagedisplayed = true;
       }
     indexer = currentmessage.Length;
          time = 0;
         secondtimer = 0;
          count = 0;
          switchmessage = false;


    }

    public void loadmessages(){
      if(currentscene.Equals("Kitchen")){
          this.firstmessage = "Malcom! There's a bully outside!";
           this.secondmessage= "He's saying that he wants to fight you!";
           this.thirdmessage = "Go outside and look!";
            this.currentmessage = this.firstmessage;
      }
      if(currentscene.Equals("Road#1") && !switchedcharacter && !engagecombat){
          this.firstmessage = "Sup Dweeb! Your stupid sister said you were around.";
          this.secondmessage = "I bet you thought it was real funny tripping me up yesterday, huh?";
          this.thirdmessage = "Jokes on you! Nobody messes with the Bradster! Put em' up!";
          WalkingScript.movementenabled = false;
          secondcharacter = true;
          this.currentmessage = this.firstmessage;

          
      }
       if(currentscene.Equals("Road#1") && switchedcharacter && !engagecombat && !BeginCombat.won){
           Dialog.faceColor = UnityEngine.Color.red;
          this.firstmessage = "Fine Bradley. Let's fight!";
          this.secondmessage = "Synthesizing wavelengths!";
          this.thirdmessage = null;
          this.currentmessage = this.firstmessage;
          count = 0;
          time = 0;
          secondtimer = 0;
          
      }
        if(currentscene.Equals("Road#1") && BeginCombat.won){
           Dialog.faceColor = UnityEngine.Color.red;
            Dialog.GetComponent<RectTransform>().localPosition = new Vector2(-115, 53);
          this.firstmessage = "Gotcha Bradley.";
          this.secondmessage = "Now if you'll excuse me, i'm getting my book back.";
          this.thirdmessage = null;
          this.currentmessage = this.firstmessage;
          engagecombat = false;
          secondcharacter = false;
          switchedcharacter = false;
          BeginCombat.won = false;
          
      }
      
      

    }
}
