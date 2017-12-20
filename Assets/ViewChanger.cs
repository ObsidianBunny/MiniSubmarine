using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChanger : MonoBehaviour {

    [SerializeField] private Camera firstCamera;
    [SerializeField] private Camera thirdCamera;
    private GameObject bluePanel;
    public bool firstperson = false;

    private void Start()
    {
        firstCamera.enabled = false;
        bluePanel = firstCamera.gameObject.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("if ok");
            firstCamera.enabled = !firstCamera.enabled;
            thirdCamera.enabled = !thirdCamera.enabled;
            firstperson = !firstperson;
            bluePanel.SetActive(firstperson);
        }		
	}
}
