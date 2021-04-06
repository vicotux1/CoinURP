using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [Range (-100, 100)] public int Points=10;
    private void Start() {
      GMScore.Score.Points(Points);
    }

    void OnTriggerEnter(Collider other){
		if (other.tag == "Player"){
    Destroy (this.gameObject);
       GMScore.Score.Counter(Points);
        }
      }  

}
