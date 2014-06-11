using UnityEngine;
using System.Collections;

abstract public class EnemyPattern
{
    float patternTime = 4;
    public float PT { get { return patternTime; } set { patternTime = value; } }

    public abstract bool Pattern(GameObject enemy);
}
