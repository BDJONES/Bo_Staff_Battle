using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoHandCharge : MonoBehaviour
{
    public ParticleSystem chargePS;

    // Update is called once per frame
    void Start()
    {
        //Emote.beganCharging += PlayParticle;
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    bananamanAnimator.Play("Two_hand_charge_stance");
        //}
    }

    private void OnDestroy()
    {
        //Emote.beganCharging -= PlayParticle;
    }

    private void PlayParticle()
    {
        chargePS.Play();
    }
}
