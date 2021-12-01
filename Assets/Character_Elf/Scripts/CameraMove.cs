using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
[SerializeField] private GameObject target;
[SerializeField] private float speed;

void Update()
{
    Vector3 direction = new Vector3(0, 0, 1);
    Vector3 velocity = direction * speed;
}

}
