using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanderVisuals : MonoBehaviour
{
    [SerializeField] private ParticleSystem leftThrusterParticleSystem;
    [SerializeField] private ParticleSystem middleThrusterParticleSystem;
    [SerializeField] private ParticleSystem rightThrusterParticleSystem;

    private Lander lander;
    
    private void Awake()
    {
        lander = GetComponent<Lander>();
        lander.OnUpForce += LanderOnOnUpForce;
    }

    private void LanderOnOnUpForce(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Start()
    {
        ParticleSystem.EmissionModule emissionModule = leftThrusterParticleSystem.emission;
        emissionModule.enabled = false;
    }
}
