using System.Collections;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] GameObject new_entity;

    [SerializeField]  private float max_time;
    [SerializeField] private float spawn_radius;

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

            float radius = Random.Range(0, spawn_radius);
            float angle = Random.Range(0, Mathf.PI * 2);
            Vector3 pos = new Vector3(1, 1, 0) * radius;
            Vector3 finalPosition = Vector3.Normalize(angle * pos) * radius;

            GameObject new_Object = Instantiate(new_entity, transform.position, Quaternion.identity);

        }
    }
}
