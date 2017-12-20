using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleManager : MonoBehaviour
{

    private ParticleSystem[] bubbles;
    private List<int> bubblesIdxList;
    private MiniSubController miniSub;
    private Rigidbody rbody;
    private Vector3 speedVector;
    private float normeSpeedVector;


    // Use this for initialization
    void Start()
    {
        bubbles = GetComponentsInChildren<ParticleSystem>() as ParticleSystem[];
        bubblesIdxList = new List<int>();
        for (int i = 0; i < bubbles.Length; i++)
        {
            if (!"SubEmitterDeath".Equals(bubbles[i].name))
            {
                bubblesIdxList.Add(i);
                bubbles[i].Play();
            }
        }
        miniSub = GetComponent<MiniSubController>();
        rbody = miniSub.GetComponent<Rigidbody>() as Rigidbody;
        speedVector = rbody.velocity;
        normeSpeedVector = Mathf.Sqrt(Mathf.Pow(speedVector.x, 2) + Mathf.Pow(speedVector.y, 2) + Mathf.Pow(speedVector.z, 2));
    }

    // Update is called once per frame
    void Update()
    {
        speedVector = rbody.velocity;
        normeSpeedVector = Mathf.Sqrt(Mathf.Pow(speedVector.x, 2) + Mathf.Pow(speedVector.y, 2) + Mathf.Pow(speedVector.z, 2));
        Debug.Log(normeSpeedVector);
        if (normeSpeedVector > 2)
        {
            foreach (int i in bubblesIdxList)
            {
                if(!bubbles[i].isPlaying)
                {
                    bubbles[i].Play(true);
                }
            }
        }
        else
        {
            foreach (int i in bubblesIdxList)
            {
                if (bubbles[i].isPlaying)
                {
                    bubbles[i].Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
                }

            }
        }
    }
}
