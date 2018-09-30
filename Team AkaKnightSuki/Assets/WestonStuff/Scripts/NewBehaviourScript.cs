﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		using UnityEngine;
using System.Collections;

public class EthanScript : MonoBehaviour 
{
    Animator anim;
    int jumpHash = Animator.StringToHash("Jump");
    int runStateHash = Animator.StringToHash("Base Layer.Run");


    void Start ()
    {
        anim = GetComponent<Animator>();
    }


    void Update ()
    {
        float move = Input.GetAxis ("Vertical");
        anim.SetFloat("Speed", move);

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if(Input.GetKeyDown(KeyCode.Space) && stateInfo.nameHash == runStateHash)
        {
            anim.SetTrigger (jumpHash);
        }
    }
}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
