using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject un_cube;
    void Start()
    {
        System.Type MyScriptType = System.Type.GetType ("wat" + ",Assembly-CSharp");
        gameObject.AddComponent(MyScriptType);

        un_cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        un_cube.GetComponent<MeshRenderer>().material.color = Color.green;
    }

    void Update()
    {

    }
}
