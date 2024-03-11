using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingObjectController : MonoBehaviour
{
    public float _speed = 5f; // Adjust the speed as needed
    private int _direction = 1;
    public Transform _wall1;
    public Transform _wall2;

    void Update()
    {
        if(_direction == 1) // Go right
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);

            Vector3 wallDir = _wall1.position - transform.position;

            if(Vector3.Dot(transform.forward, wallDir) < 0)
            {
                _direction = -1;
            }
        }
        
        else if(_direction == -1) // Go left
        {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);

            Vector3 wallDir = _wall2.position - transform.position;

            if (Vector3.Dot(transform.forward,wallDir) > 0)
            {
                _direction = 1;
            }
        }
    }

}
