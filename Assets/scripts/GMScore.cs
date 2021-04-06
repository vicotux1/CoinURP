#region assignation's previas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#endregion

public class GMScore : MonoBehaviour{
    public static GMScore Score;
    public int MaxScore=0;
    public int counter=0;
    [Header ("Texto en UI")]
    public Text Pointstext; 

    private void Awake() {
    if (Score!=null){
    Destroy(this.gameObject);      
    }else{Score=this;
    DontDestroyOnLoad(this.gameObject);
    Debug.Log("esto es un singleton");
    } 
  
        textupdate();
    }
    private void Update() {
        if(counter>=MaxScore){
        SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);
        }
    }

    public void Points(int Value){
        MaxScore=MaxScore+Value;
        Debug.Log(MaxScore);
    }
    public void Counter(int Value){

        if (counter<MaxScore){
           counter=counter+Value;
        textupdate(); }
    }
     void textupdate(){
        Pointstext.text=counter.ToString();
    } 
  

}
