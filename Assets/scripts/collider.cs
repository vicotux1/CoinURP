using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collider : MonoBehaviour{
[SerializeField] private string Scenes="01";
    void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){

			SceneManager.LoadScene(Scenes);
			}
	}
}
