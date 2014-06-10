using UnityEngine;
using System.Collections;

public class EnemyObject : MonoBehaviour 
{
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
        Vector3 pos = transform.position;

        if (m_fBackPos > 0)
        {
            pos.z += 0.1f;
            m_fBackPos -= 0.1f;
        }
        else pos.z -= m_fSpeed * Time.deltaTime;
        transform.position = pos;
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
