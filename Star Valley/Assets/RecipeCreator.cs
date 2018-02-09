using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New_Recipe", menuName = "Create Recipe")]
public class recipeCreator : ScriptableObject {
	//Add Ability To Add More Components

	public string[] Requirements = new string[1];

	public string Result;

}
