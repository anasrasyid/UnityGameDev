﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan2 : MonoBehaviour {
    public int nilaiA;
    public int nilaiB;
	[Range(1,5)]
	public int nilaiC;
	// Use this for initialization
	void Start () {
		int totalNilai = (nilaiA + nilaiB) * nilaiC;
		Debug.Log("Total :" + totalNilai);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
