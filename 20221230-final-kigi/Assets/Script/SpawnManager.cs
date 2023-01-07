
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] garbage;
    

    void Start()
    {
        float ReapeatTime = Random.Range(4, 8);
        InvokeRepeating("garbageSpawn", 3, ReapeatTime);
    }

    private void garbageSpawn()
    {
        int a_index = Random.Range(0, garbage.Length);
        Vector3 place = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(garbage[a_index], place, garbage[a_index].transform.rotation);
    }

    

}
