using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePyramid : MonoBehaviour
{
    public Material[] randomMaterials;
    public GameObject PrefabKostki;
    private GameObject lastGenerated;
	void Start () {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (k<=i && k<=9-i && k<=j && k<=9-j)
                    {
                        GameObject nowy = Instantiate(PrefabKostki);
                        nowy.transform.position += new Vector3(20 + 3f * j, 3f * k, 3f * i);
                        nowy.GetComponent<Renderer>().material =
                            randomMaterials[Random.Range(0, randomMaterials.Length)];
                        if (lastGenerated != null)
                            nowy.GetComponent<SpringJoint>().connectedBody = lastGenerated.GetComponent<Rigidbody>();
                        else
                            Destroy(nowy.GetComponent<SpringJoint>());
                        lastGenerated = nowy;
                    }

                }         
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
