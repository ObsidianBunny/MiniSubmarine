using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleManager : MonoBehaviour {

    private ParticleSystem[] bubbles;
    private List<ParticleSystem> bubblesList;
    private MiniSubController miniSub;
    private Rigidbody rbody;
    private Vector3 speed;


    // Use this for initialization
    void Start() {
        bubbles = GetComponentsInChildren<ParticleSystem>() as ParticleSystem[];
        bubblesList = new List<ParticleSystem>();
        for (int i=0; i < bubbles.Length; i++)
        {
            if(!"SubEmitterDeath".Equals(bubbles[i].name))
            {
                bubblesList.Add(bubbles[i]);
                bubblesList[i].Play();
            }
        }
        miniSub = GetComponent<MiniSubController>();
        rbody = miniSub.GetComponent<Rigidbody>() as Rigidbody;
        speed = rbody.velocity;
    }

    // Update is called once per frame
    void Update() {
        //speed = rbody.velocity;

        //if (speed.x != 0)
        //{
        //    foreach (ParticleSystem p in bubblesList)
        //    {
        //        p.Play();
        //        p.Simulate(2f,true, true);
        //    }
        //} else {
        //    foreach (ParticleSystem p in bubblesList)
        //    {
        //        p.Clear();
        //    }
        //}
    }
}
