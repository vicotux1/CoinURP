using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour{
    private Rigidbody rb;
    public Vector3 Position_initial;
    [Range(1.0f, 200.0f)]public float speed=10.0f;
    private float MovX, MovY;

    private void Awake() {
        rb=GetComponent<Rigidbody>();
        Cursor.visible = false;
        transform.position=Position_initial;
    }

    void OnMovement(InputValue MovementValue){
        Vector2 MoveVector=MovementValue.Get<Vector2>();
        MovX=MoveVector.x;
        MovY=MoveVector.y;
         
        
}
private void FixedUpdate() {
    Vector3 move=new Vector3(MovX,transform.position.y,MovY);
    rb.AddForce(move*speed);
}

}
