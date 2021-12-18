using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageControlEn : MonoBehaviour, IDamage
{
    [SerializeField] private Text text;
    [SerializeField] private GameManager gameManager;

    int i = 0;

    public void Damage()
    {
        i += 1;
        if (i < 100)
            text.text = i.ToString();
        else
            gameManager.EndGame();
    }
    private void OnDestroy()
    {
        gameManager.EndGame();
    }
}
