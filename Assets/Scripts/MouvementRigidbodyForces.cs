using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRigidbodyForces : MonoBehaviour
{
    public Vector3 forceInitiale = Vector3.zero;
    private Rigidbody _rb;

    void Start()
    {
        // Prends une réference au Rigidbody attaché a cet objet.
        _rb = GetComponent<Rigidbody>();

        _rb.AddForce(forceInitiale, ForceMode.VelocityChange);
        //, ForceMode.VelocityChange ne prend pas charge a la masse, on peut l'enlever pour etre normal//
    }
}
