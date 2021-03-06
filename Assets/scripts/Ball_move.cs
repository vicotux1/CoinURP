using System;
using UnityEngine;

    public class Ball_move : MonoBehaviour
    {
        [SerializeField] private float m_MovePower = 5,
        m_MaxAngularVelocity = 25; 
        [SerializeField] private Vector3 Position_initial;
        [SerializeField] private Rigidbody m_Rigidbody;
        private const float k_GroundRayLength = 1f;


        private void Awake(){
            Reset();
            m_Rigidbody = GetComponent<Rigidbody>();
            GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }
    public void Reset() {
    Cursor.visible = false;
    m_Rigidbody.velocity=Vector3.zero;
   transform.position=Position_initial;  
    }


    public void Move(float MoveZ, float MoveY){
    m_Rigidbody.AddTorque(new Vector3(MoveY, 0, -MoveZ)*m_MovePower);
        }
    }
