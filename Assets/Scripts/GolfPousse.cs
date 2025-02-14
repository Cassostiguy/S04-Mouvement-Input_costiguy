using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfPousse : MonoBehaviour
{
    // Start is called before the first frame update
            public Vector3 forceInitiale = Vector3.zero;
    private Rigidbody _rb;

    void Start()
    {
        // Prends une r�ference au Rigidbody attach� a cet objet.
        _rb = GetComponent<Rigidbody>();

        _rb.AddForce(forceInitiale,ForceMode.VelocityChange);
        //, ForceMode.VelocityChange ne prend pas charge a la masse, on peut l'enlever pour etre normal//
    }
}
  


