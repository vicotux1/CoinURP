using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour{
    [SerializeField] PlayerMove Player;
    private float MovX, MovY;
    void OnMovement(InputValue MovementValue){
    Vector2 MoveVector=MovementValue.Get<Vector2>();
    MovX=MoveVector.x;
    MovY=MoveVector.y; 
    Player.OnMovement(MovX, MovY); 
    }    
}
