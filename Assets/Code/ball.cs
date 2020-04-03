using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
   
    public GameObject goalGameObject, cubeTransform;
   

    public void Start()
    {
        cubeTransform.SetActive(true);    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(goalGameObject))
        {
            cubeTransform.SetActive(false);
        }
    }
}
