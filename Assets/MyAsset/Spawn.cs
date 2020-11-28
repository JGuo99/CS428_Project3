using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject snackObject;
    public void Add() {
        Instantiate(snackObject, transform.position, transform.rotation);
    }
}
