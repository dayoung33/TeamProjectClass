using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Sc : MonoBehaviour
{
    private ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ps)
        {
            Destroy(gameObject,3.0f);        
        }
    }
}
