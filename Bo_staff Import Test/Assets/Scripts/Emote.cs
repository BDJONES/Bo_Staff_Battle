using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Emote : MonoBehaviour
{
    private Animator bananamanAnimator;
    public float transitionSpeed = 50f;
    //public static event Action beganCharging;
    private void Start()
    {
        bananamanAnimator = GetComponent<Animator>();
        //bananamanAnimator.SetBool("isHoldingInput", true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            bananamanAnimator.SetBool("isHoldingInput", true);
            //beganCharging?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            StartCoroutine(WaitXSeconds(transitionSpeed));
            
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            bananamanAnimator.SetBool("Wave", true);
        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    bananamanAnimator.SetTrigger("Wave");
        //}
    }

    IEnumerator WaitXSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        bananamanAnimator.SetBool("isHoldingInput", false);
    }
}
