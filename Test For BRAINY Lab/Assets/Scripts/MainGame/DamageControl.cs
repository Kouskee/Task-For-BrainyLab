using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageControl : MonoBehaviour, IDamage
{
    [SerializeField] private TextMeshProUGUI text;

    int i = 0;

    public void Damage()
    {
        i += 1;
        if (i < 100)
            text.text = i.ToString();
        else
            FindObjectOfType<GameManager>()?.EndGame();
    }

    private void OnDestroy()
    {
        FindObjectOfType<GameManager>()?.EndGame();  
    }
}
