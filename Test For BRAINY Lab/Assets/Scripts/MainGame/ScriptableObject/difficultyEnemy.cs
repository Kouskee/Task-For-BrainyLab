using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Difficulty Enemy")]
public class difficultyEnemy : ScriptableObject
{
    [SerializeField] private string difficulty;
    [SerializeField] private float speedEn;
    [SerializeField] private Color color;
}
