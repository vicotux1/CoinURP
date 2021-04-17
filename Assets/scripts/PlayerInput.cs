using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour{
    
    
    [SerializeField] PlayerMove Player;

    [Header("Movement")]
    public string AxisHorizontal;
    public string AxisVertical;
    [Header("Position")]
    public Vector3 Position_initial;
    private float MovX, MovY;
    private void Awake() {
    Reset();
    }
    public void Reset() {
    Cursor.visible = false;
    Player.rb.velocity=Vector3.zero;
    transform.position=Position_initial;  
    }

    void FixedUpdate() {
    MovX= Input.GetAxis(AxisHorizontal);
    MovY=Input.GetAxis(AxisVertical);
    Player.OnMovement(MovX, MovY);     
}


}
