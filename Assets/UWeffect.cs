using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UWeffect : MonoBehaviour {

    [SerializeField] private GameObject blurPanel;
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > 250)
            blurPanel.SetActive(false);
        else
            blurPanel.SetActive(true);		
	}
}
