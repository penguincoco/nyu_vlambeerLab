using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Reset : MonoBehaviour
{
    public List<GameObject> pathMakers;
    private bool canRestart;

    //public TextMeshProUGUI restartText;
    public GameObject restartPanel;

    void Start() {
        pathMakers = new List<GameObject>();
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("PathMaker")) {
            pathMakers.Add(item);
        }
        canRestart = false;
    }
    // Update is called once per frame
    void Update() {
        if (pathMakers.Count == 0) {
            canRestart = true;
        }

        if (canRestart) {
            ShowText();
            Restart();
        }
    }

    void Restart() {
        if (Input.GetKeyDown(KeyCode.R)) {
            Pathmaker.globalTileCount = 0;
            SceneManager.LoadScene(0);
        }
    }

    void ShowText() {
        restartPanel.SetActive(true);
        //restartText.text = "Boxy Generator Completed. \nPress 'R' to generate another map!";
    }
}
