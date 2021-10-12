using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerCatCollision : MonoBehaviour
{
    [SerializeField]
    private TMP_Text points;
    private int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cat"))
        {
            score++;
            Destroy(other.gameObject);
            points.text = score.ToString();
            //audioSourceCoins.Play();
        }

        if (score == 20)
        {
            SceneManager.LoadSceneAsync("WinScene");
        }
    }
}