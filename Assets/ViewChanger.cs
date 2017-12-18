using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChanger : MonoBehaviour {

    public bool firstPerson = false;
	
	// Update is called once per frame
	void Update () {
        //if(Input.GetAxis("Fire2") == 1)
        if (Input.GetKeyDown("joystick button 9"))
        {
            Debug.Log("if ok");
            StartCoroutine("SwitchView");
        }
		
	}

    private IEnumerator SwitchView()
    {
        if (firstPerson)
        {
            
            transform.localPosition = new Vector3(0f, 3.21f, 6.23f);
            Debug.Log(transform.localPosition);
            //transform.localEulerAngles = new Vector3(12.724f, 0f, 0f);
            firstPerson = false;
        }
        else
        {
            transform.localPosition = new Vector3(0f, 0.7f, -1.14f);
            Debug.Log(transform.localPosition);
            //transform.localEulerAngles = new Vector3(0f, 0f, 0f);
            firstPerson = true;
        }
        yield return null;
    }
}
