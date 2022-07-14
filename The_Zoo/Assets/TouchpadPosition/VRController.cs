using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRController : MonoBehaviour
{
    // การเคลื่อนไหวเพื่อเพิ่มแรงโน้มถ่วงและการหักการหมุน
    // Projects motion to increase gravity and deduction rotation.
    public float m_Gravity = 30.0f;
    public float m_RotateIncrement = 90;
    public SteamVR_Action_Boolean m_RotatePress = null;

    public float m_Sensitivity = 0.1f;
    public float m_MaxSpeed = 1.0f;

    public SteamVR_Action_Boolean m_MovePress = null;
    public SteamVR_Action_Vector2 m_MoveValue = null;

    private float m_Speed = 0.0f;

    private CharacterController m_CharacterController = null;
   /* private Transform m_CamerRig = null;*/
    private Transform m_Head = null;

    private void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }

    private void Start()
    {
        m_Head = SteamVR_Render.Top().head;
        /*m_CamerRig = SteamVR_Render.Top().origin;*/
    }

    private void Update()
    {
        // Functions three

        /*HandleHead();*/
        HandleHeight();
        CalculateMovement();
        SnapRotation();
    }

  /*  private void HandleHead()
    {
        // Store current
        Vector3 oldPoition = m_CamerRig.position;
        Quaternion oldRotation = m_CamerRig.rotation;

        // Rotation
        transform.eulerAngles = new Vector3(0.0f, m_Head.rotation.eulerAngles.y, 0.0f);

        // Restore
        m_CamerRig.position = oldPoition;
        m_CamerRig.rotation = oldRotation;

    }*/
    private void HandleHeight()
    {
        // Get the head in local space
        float headHeight = Mathf.Clamp(m_Head.localPosition.y, 1, 2);
        m_CharacterController.height = headHeight;

        // Cut in half
        Vector3 newCenter = Vector3.zero;
        newCenter.y = m_CharacterController.height / 2;
        newCenter.y += m_CharacterController.skinWidth;

        // Move capsule in local space 
        newCenter.x = m_Head.localPosition.x;
        newCenter.z = m_Head.localPosition.z;

        /* // Rotate
         newCenter = Quaternion.Euler(0, -transform.eulerAngles.y, 0) * newCenter;*/

        // Apply
        m_CharacterController.center = newCenter;
    }

    private void CalculateMovement()
    {
        // Figure out movement orientation
        /*    Vector3 orientationEuler = new Vector3(0, m_Head.eulerAngles.y, 0);
            Quaternion orientaion = Quaternion.Euler(orientationEuler);*/

        Quaternion orientation = CaculateOrientation();

        Vector3 movement = Vector3.zero;

        // If not moveing
        /*if (m_MovePress.GetStateUp(SteamVR_Input_Sources.Any))
            m_Speed = 0;*/
        if (m_MoveValue.axis.magnitude == 0)
        {
            m_Speed = 0;
        }

        // Add, clamp
        m_Speed += m_MoveValue.axis.magnitude * m_Sensitivity;
        m_Speed = Mathf.Clamp(m_Speed, -m_MaxSpeed, m_MaxSpeed);

        // Orientation , and gravity
        movement += orientation * (m_Speed * Vector3.forward);

        // If button pressed
        /*        if (m_MovePress.state)
                {
                    
                    m_Speed += m_MoveValue.axis.y * m_Sensitivity;
                    m_Speed = Mathf.Clamp(m_Speed, -m_MaxSpeed, m_MaxSpeed);

                    // Orientation
                    movement += orientation * (m_Speed * Vector3.forward) * Time.deltaTime;
                }*/

        // Gravity // แรงโน้มถ่วง
        movement.y -= m_Gravity * Time.deltaTime;

        // Apply
        m_CharacterController.Move(movement * Time.deltaTime);

    }

    private Quaternion CaculateOrientation()
    {
        float rotation = Mathf.Atan2(m_MoveValue.axis.x, m_MoveValue.axis.y);
        rotation *= Mathf.Rad2Deg;

        Vector3 orientationEuler = new Vector3(0, m_Head.eulerAngles.y + rotation, 0);
        return Quaternion.Euler(orientationEuler);

    }

    private void SnapRotation()
    {
        float snapValue = 0.0f;

        if (m_RotatePress.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            snapValue = -Mathf.Abs(m_RotateIncrement);
        }

        if (m_RotatePress.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            snapValue = Mathf.Abs(m_RotateIncrement);
        }

        transform.RotateAround(m_Head.position, Vector3.up, snapValue);
    }
}
