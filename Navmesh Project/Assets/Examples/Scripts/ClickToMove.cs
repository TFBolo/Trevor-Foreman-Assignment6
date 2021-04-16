using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

// Use physics raycast hit from mouse click to set agent destination
[RequireComponent(typeof(NavMeshAgent))]
public class ClickToMove : MonoBehaviour
{
    public NavMeshAgent m_Agent;
    RaycastHit m_HitInfo = new RaycastHit();
    public Camera cam;

    public ThirdPersonCharacter character;

    void Start()
    {
        m_Agent.updateRotation = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out m_HitInfo))
            {
                m_Agent.destination = m_HitInfo.point;
            }   
        }

        if (m_Agent.remainingDistance > m_Agent.stoppingDistance)
        {
            character.Move(m_Agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
        if (gameObject.transform.position.x < -23f)
        {
            cam.transform.position = new Vector3(-51f, 19f, -10f);
        }
        if (gameObject.transform.position.x > -23f && gameObject.transform.position.z < 29f && gameObject.transform.position.x < 33f)
        {
            cam.transform.position = new Vector3(5f, 19f, -10f);
        }
        if (gameObject.transform.position.x > 33f)
        {
            cam.transform.position = new Vector3(61f, 19f, -10f);
        }
        if (gameObject.transform.position.z > 29f)
        {
            cam.transform.position = new Vector3(5f, 19f, 27f);
        }
    }
}