using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]

public class VFXCtrl : MonoBehaviour
{
    [SerializeField] private ParticleSystem ps;
    private ParticleSystem.Particle[] _particles;
    private int alive;

    [Header("Values")]
    public float speed = 0f;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
       // SetNewParticle();
        
    }


    private void SetNewParticle()
    {
        _particles = new ParticleSystem.Particle[ps.main.maxParticles];
        alive = ps.GetParticles(_particles);
        for (int i = 0; i < alive; i++)
            _particles[i].velocity = Vector3.forward;
        ps.SetParticles(_particles, alive);
        
    }
    // Update is called once per frame
    void Update()
    {
        ps.startSpeed = speed;

    }
}