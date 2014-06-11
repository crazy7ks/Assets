using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyObject : MonoBehaviour 
{
    private List<EnemyPattern> PatternQ;

    private EnemyPattern voidPattern = new EnemyMove(new Vector3(0,0,1),1,5);

    public GameObject m_deathEffect;
    public GameObject m_hitEffect;
    public static int m_stMaxHP;
    public float m_fSpeed;
    int m_iHP;
    float m_fBackPos;

	void Start ()
    {
        m_iHP = m_stMaxHP;
	}

	void Update () 
    {
        //ks COde
        //Vector3 pos = transform.position;
     
        //if (m_fBackPos > 0)
        //{//물체를 움직일땐 dt를 넣어야함
        //    pos.z += 0.1f;
        //    m_fBackPos -= 0.1f;
        //}
        //else pos.z -= m_fSpeed * Time.deltaTime;
        //transform.position = pos;

        if(PatternQ.Count != 0)
        {
            if (PatternQ[0].Pattern(gameObject))
            {
                PatternQ.RemoveAt(0); 
            }
        }
        else
        {
            voidPattern.Pattern(gameObject);
            //명령이 없을떈?
        }
	}

    public void Damaged(int power)
    {
        m_iHP -= power;
        if(m_iHP < 0)
        {
            Destroy(gameObject);
        }
    }



}
