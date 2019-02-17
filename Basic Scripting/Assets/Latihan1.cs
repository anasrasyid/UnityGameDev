using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Latihan1 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Fungsi Awake terpanggil");
    }
    // Use this for initialization
    void Start()
    {
        Debug.Log("Hello Dicoding!");
    }
    void FixedUpdate()
    {
        Debug.Log("Waktu untuk Fixed Update :" + Time.deltaTime);
        Debug.Log("Saya Anas adalah game developer");
    }
 
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Waktu untuk Update :" + Time.deltaTime);
    }
    void LateUpdate()
    {
        Debug.Log("Waktu untuk Late Update :" + Time.deltaTime);
    }
}
 