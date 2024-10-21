using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    private Animator bananamanAnimator;

    private void Start()
    {
        bananamanAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bananamanAnimator.SetTrigger("Wave");
        }
    }
}
