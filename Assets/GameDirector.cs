using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public List<GameObject> m_SpawnPoints;
    public GameObject ZombiePrefab;
    public float m_delta;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnZombie(m_delta));
    }

    IEnumerator SpawnZombie(float SpawnDelta)
    {
        
        while(true)
        {
            int SpawnNum = (int)(Random.Range(0, 4));
            Debug.Log(SpawnNum);

            Instantiate(ZombiePrefab, m_SpawnPoints[SpawnNum].transform);
            yield return new WaitForSecondsRealtime(10f);

        }
    }
}
