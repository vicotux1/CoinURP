using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMLives : MonoBehaviour{
    public static GMLives GM_Lives;


   [Range (0, 9)] public int lives;
    public Text livesText;

    private void Awake() {  
    Texttostring() ;      
    if (GM_Lives!=null){
    Destroy(this.gameObject);      
    }else{GM_Lives=this;
    DontDestroyOnLoad(this.gameObject);
    Debug.Log("esto es un singleton lives");
        } 
    } 
    public void life(int count) {
    lives=lives+count;
    Texttostring();
    }
    void Texttostring() {
   livesText.text = lives.ToString();
    }
}
