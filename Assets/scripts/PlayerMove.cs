using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour{
   public Rigidbody rb;
   public Vector3 Position_initial;
   [Range(1.0f, 2000.0f)]public float speed=2000.0f;
   private void Awake() {
    Reset();
    rb = GetComponent<Rigidbody>();
    }
    public void Reset() {
    Cursor.visible = false;
    rb.velocity=Vector3.zero;
   transform.position=Position_initial;  
    }
    public void OnMovement(float MovX, float MovY){
    Vector3 move=new Vector3(MovX,transform.position.y,MovY);
    rb.AddForce(move*speed);
    }
}
