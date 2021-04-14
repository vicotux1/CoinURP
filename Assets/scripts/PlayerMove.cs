using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour{
   private Rigidbody rb;
   [Range(1.0f, 200.0f)]public float speed;
    private void Awake() => rb = GetComponent<Rigidbody>();


    public void OnMovement(float MovX, float MovY){
    Vector3 move=new Vector3(MovX,transform.position.y,MovY);
    rb.AddForce(move*speed);
    }
}
