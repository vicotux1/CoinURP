using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMLives : MonoBehaviour{
    public static GMLives Lives;
    public int lives;
    public Text livesText;
    
    private void Awake() {
   livesText.text = lives.ToString();
    }
}
