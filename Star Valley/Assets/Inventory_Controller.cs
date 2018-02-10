using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Controller : MonoBehaviour {

	public string[] Inventory = new string[10];
	void Start () {
		Inventory[0] = "Health";
		Inventory[1] = "Damage";
	}
	
	void Update () {
		
	}
}
