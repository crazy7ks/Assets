using UnityEngine;
using System.Collections;

public class EnemyMove : EnemyPattern 
{
    Vector3 dir;
    float speed;

    public EnemyMove(Vector3 d, float spd,float time)
    {
        dir = d;
        speed = spd;
        PT = time;
    }

    public override bool Pattern(GameObject enemy)
    {
        
        return false;
    }
}
