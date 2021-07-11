using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class cube : MonoBehaviour
{
    private float SPEED = 30;
    Rigidbody m_Rigidbody;
    Transform box_trans;
    public GameObject box;

    void Start()
    {
        box = new GameObject("wat");
        box.AddComponent<MeshFilter>().mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
        box.AddComponent<MeshRenderer>();
        box.GetComponent<MeshRenderer>().material.color = Color.green;

        m_Rigidbody = box.AddComponent<Rigidbody>();
        m_Rigidbody.velocity = new Vector3(-SPEED, SPEED, 0);
        box.transform.position = new Vector3(0,0,0);
        box_trans = box.transform;
    }

    void Update()
    {
        Vector3 position = box_trans.position;
        print(position);

        // if > 100 dir go false
        if (position[1] >= 10) {
            m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity[0], -SPEED, m_Rigidbody.velocity[2]);
        } else if (position[1] <= -10) {
            m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity[0], SPEED, m_Rigidbody.velocity[2]);
        }

        if (position[0] >= 15) {
            m_Rigidbody.velocity = new Vector3(-SPEED, m_Rigidbody.velocity[1], m_Rigidbody.velocity[2]);
        } else if (position[0] <= -15) {
            m_Rigidbody.velocity = new Vector3(SPEED, m_Rigidbody.velocity[1], m_Rigidbody.velocity[2]);
        }
    }
}