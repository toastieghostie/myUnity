using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{



    [SerializeField] Defender defenderPrefab;
    [SerializeField] int test;

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(43, 43, 43, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        Debug.Log("defprefab:");
        Debug.Log(defenderPrefab);
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
        FindObjectOfType<DefenderSpawner>().SetTestInt(test);
        Debug.Log(FindObjectOfType<DefenderSpawner>().GetTest());
    }
}
