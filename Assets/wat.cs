using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class wat : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Transform cube_trans;
    public GameObject cube;
    void Start()
    {
        cube = new GameObject("wat");
        cube.AddComponent<MeshFilter>().mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
        cube.AddComponent<MeshRenderer>();
        cube.GetComponent<MeshRenderer>().material.color = Color.green;

        // Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
        m_Rigidbody = cube.AddComponent<Rigidbody>();
        m_Rigidbody.velocity = new Vector3(0, 10, 0);
        cube.transform.position = new Vector3(0,0,0);
        cube_trans = cube.transform;
    }

    void Update()
    {
        Vector3 position = cube_trans.position;
        print(position);

        // if > 100 dir go false
        if (position[1] >= 10) {
            m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity[0], -10, m_Rigidbody.velocity[2]);
        } else if (position[1] <= -10) {
            m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity[0], 10, m_Rigidbody.velocity[2]);
        }

        // if (position[0] >= 15) {
        //     m_Rigidbody.velocity = new Vector3(-10, m_Rigidbody.velocity[1], m_Rigidbody.velocity[2]);
        // } else if (position[0] <= -15) {
        //     m_Rigidbody.velocity = new Vector3(10, m_Rigidbody.velocity[1], m_Rigidbody.velocity[2]);
        // }
    }

    public Button yourButton;
    private void Awake()
    {
        Button buttonComponent = yourButton.GetComponent<Button>();;
        yourButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        Debug.Log("The button has clicked!");
    }
}