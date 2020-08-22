using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{

	public static int level = 0;
	private static Text levelUI;

    // Use this for initialization
    private void Start() {

        // increment level static variable
        level++;

        // use level to update UI text component
        levelUI = gameObject.GetComponent<Text>();
        levelUI.text = string.Concat("Level ", level.ToString());
    }

    // use this class method to reset level on a game over
    public static void reset() {
        level = 0;
    }
}
