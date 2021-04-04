using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{ public Material material;
    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    Vector3[] vertex;
    int[] triangles;

    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = material;
        GetComponent<MeshFilter>().mesh = mesh;
        //Creacion de triangulo 
        vertex = new[]
        {
            new Vector3(0,0,0),
             new Vector3(0,1,0),
              new Vector3(1,0,0),
        };
        /*esto es lo mismo que el de arriba
        vertex = new Vector3[3];
        vertex[0] = new Vector3(0, 0, 0);
        vertex[1] = new Vector3(0, 1, 0);
        vertex[2] = new Vector3(1, 0, 0);
        */
       meshFilter.mesh.vertices = vertex;
        triangles = new[]
        {
            0,1,2
        };
       meshFilter.mesh.triangles = triangles; 

    }


}
