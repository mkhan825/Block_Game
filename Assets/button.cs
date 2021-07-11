using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class button : MonoBehaviour
{
    public Button yourButton;
    void Start()
    {
        // yourButton = button.AddComponent<Button>();
		// yourButton.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {
        
    }

    void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
    }
}