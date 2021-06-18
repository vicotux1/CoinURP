#region assignation's previas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#endregion

public class GMScore : MonoBehaviour{
    public GMLives GM_Lives; 
    [SerializeField] private GameObject GameScenes;
    public static GMScore Score;
    public int MaxScore=0;
    public int counter=0;
    [Header ("Texto en UI")]
    [Range (0, 10)] public int total_levels;
    public Text Pointstext; 
    private void Awake() {
        Null();
    GameScenes.SetActive(false);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
        if (Score!=null){
     Destroy(this.gameObject,0);      
    }else{Score=this;
        DontDestroyOnLoad(this.gameObject);
    } 
  
        textupdate();
    }
    private void Start() {
        Null();
    }
    private void Update() {
       Scene();
       Null();
    }
    void Null(){
        if (GameScenes == null)
    GameScenes= GameObject.FindWithTag("GameScenes");
    }
    void Scene(){
        if(counter>=MaxScore){
        if (SceneManager.GetActiveScene ().buildIndex <total_levels) {
            GameScenes.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);
        } 
        if (SceneManager.GetActiveScene ().buildIndex ==total_levels) {
            GM_Lives.GameOver();
            }
        }
    }
    IEnumerator MainMenu(){
        SceneManager.LoadScene("00");
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
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
