using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject sonZemin;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            ZeminOlustur();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ZeminOlustur()
    {
        sonZemin = Instantiate(sonZemin, sonZemin.transform.position + Vector3.left, sonZemin.transform.rotation);
    }
}
