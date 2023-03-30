using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class IntroBGManager : MonoBehaviour
{
    [SerializeField] private GameObject startObj;
    [SerializeField] private GameObject endObj;

    [SerializeField] List<GameObject> decoPrefabs = new List<GameObject>();


    private void Start()
    {
        StartCoroutine(GeneratePrefabs());
    }

    private IEnumerator GeneratePrefabs()
    {
        Instantiate(decoPrefabs[Random.Range(0, decoPrefabs.Count)], transform.position, Quaternion.identity);

        yield return new WaitForSeconds(Random.Range(1, 5f));
    }
}
