using UnityEngine;
using System.Collections;


public class EnemyManager : MonoBehaviour 
{
    public GameObject[] m_enemyPrefap;
    
    private const int MAX_ENEMYCOUNT = 5;
    private GameObject[,] enemyArray;
  
    public float m_fRespawnDelay = 1F;
    public float m_fDelayTime;

    float m_fMinX;
    float m_fMaxX;
   
	void Start () 
    {
        m_fMinX = transform.position.x - renderer.bounds.size.x / 2;
        m_fMaxX = transform.position.x + renderer.bounds.size.x / 2;
       
        enemyArray = new GameObject[m_enemyPrefap.Length, MAX_ENEMYCOUNT];

        for (int n = 0; n < m_enemyPrefap.Length;n++ )
        {
                
        }

        Debug.Log(m_enemyPrefap.Length);
	}

	void Update () 
    {
        if (Time.time > m_fRespawnDelay)
        {
           m_fRespawnDelay = Time.time + m_fDelayTime;
        //    Vector3 pos = transform.position;
        //    pos.x = Random.Range(m_fMinX, m_fMaxX);
        //    GameObject enemy = Instantiate(m_enemyPrefap[0], pos, transform.rotation) as GameObject;

        //    enemy.transform.parent = gameObject.transform;
        }
	}
}
