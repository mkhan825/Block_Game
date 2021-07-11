using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wat : MonoBehaviour
{
    void Start()
    {
        System.Type CubeScript = System.Type.GetType ("cube" + ",Assembly-CSharp");
        gameObject.AddComponent(CubeScript);

        System.Type ButtonScript = System.Type.GetType ("button" + ",Assembly-CSharp");
        gameObject.AddComponent(ButtonScript);
    }

    void Update()
    {

    }
}