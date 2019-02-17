using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int c = Jumlah(40,60);
		Debug.Log("Hasil Jumlah a dan b adalah :" + c);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/// Fungsi untuk menjumlah 2 angka
	int Jumlah(int a, int b)
	{
		return a + b;
	}
}
