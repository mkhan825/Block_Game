using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    void Start()
    {
        System.Type MyScriptType = System.Type.GetType ("wat" + ",Assembly-CSharp");
        gameObject.AddComponent(MyScriptType);
    }

    void Update()
    {

    }
}
