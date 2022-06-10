using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpeedUp : MonoBehaviour
{
    public ParticleSystem particle;
    private ParticleSystem.MinMaxCurve startSpeed;
    private ParticleSystem.MinMaxCurve startSize;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        startSpeed = particle.main.startSpeed;
        startSize = particle.main.startSize;
    }

    // Update is called once per frame
    void Update()
    {
        var main = particle.main;
        if (Input.GetKeyDown(KeyCode.T))
        {
            main.startSize = 5;
            main.startSpeed = 100;
        }
        main.startSpeed = startSpeed;
        main.startSize = startSize;
    }
}
