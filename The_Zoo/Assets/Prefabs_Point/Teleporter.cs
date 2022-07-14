using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class Teleporter : MonoBehaviour
{

    public float m_DefaultLength = 5f;
    public GameObject m_Pointer;
    public SteamVR_Action_Boolean m_TeleporterAction;

    private SteamVR_Behaviour_Pose m_Pose = null;
    private bool m_HasPosition = false;

    private bool m_IsTeleporting = false;
    private float m_FadeTime = 0.5f;

    private void Awake()
    {
        m_Pose = GetComponent<SteamVR_Behaviour_Pose>();
    }
    void Start()
    {
        
    }

     private void Update()
    {
        // Pointer
        m_HasPosition = UpdatePointer();
        m_Pointer.SetActive(m_HasPosition);

        // Telepoer
        if (m_TeleporterAction.GetStateUp(m_Pose.inputSource))
        {
            TryTeleport();
        }
     }

    private void TryTeleport()
    {
        // Check for valid position and if already teleporting
        if (!m_HasPosition || m_IsTeleporting)
        {
            return;
        }

        // Get 
        Transform cameraRig = SteamVR_Render.Top().origin;
        Vector3 hasdPosition = SteamVR_Render.Top().head.position;

        // Figure out rig translation
        Vector3 groundPoition = new Vector3(hasdPosition.x, cameraRig.position.y, hasdPosition.z);
        Vector3 translateVetor = m_Pointer.transform.position - groundPoition;

        // Move 
        StartCoroutine(MoveRig(cameraRig, translateVetor));
    }

    private IEnumerator MoveRig(Transform cameraRig, Vector3 translation)
    {
        // Fiag 
        m_IsTeleporting = true;

        // Fade to black
        SteamVR_Fade.Start(Color.black, m_FadeTime, true);

        // Apply transletion
        yield return new WaitForSeconds(m_FadeTime);
        cameraRig.position += translation;

        // Fade to clear
        SteamVR_Fade.Start(Color.clear, m_FadeTime, true);

        // De-flag
        m_IsTeleporting = false;

        yield return null;
    }

    private bool UpdatePointer()
    {
        // Ray from the contreoller
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        // If it's a hit
        if (Physics.Raycast(ray, out hit, m_DefaultLength))
        {
            m_Pointer.transform.position = hit.point;
            return true;
        }
        return false;


    }
}
