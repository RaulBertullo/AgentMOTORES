using System.Collections;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject new_entity;

    [SerializeField] float max_time;

    public bool canSpawn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, 1);
    }

    IEnumerator timer()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(max_time);  
            GameObject gameObject = Instantiate(new_entity, transform.position, Quaternion.identity);

        }
    }
}
