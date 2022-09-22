using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproducirAnimation : MonoBehaviour
{
    public Animation animacion;
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("personaje"))
        {
            GetComponentInChildren<Animator>().enabled = true;
        }
    }


}
