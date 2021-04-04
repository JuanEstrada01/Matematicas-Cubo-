using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MakeCube : MonoBehaviour
{
    public Material material;

    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    Vector3[] vertex;



    int[] triangles;

    List<int> triangles_2;
    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();

        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        meshFilter.mesh = mesh;

        vertex = new[]
        {
            new Vector3(0,0,0),
            new Vector3(0,1,0),
            new Vector3(1,0,0),
            new Vector3(1,1,0),

            new Vector3(1,0,1),
             new Vector3(1,1,1),
              new Vector3(0,0,1),
               new Vector3(0,1,1),
        };

        /*vertex = new Vector3[3];
        vertex[0] = new Vector3(0, 0, 0);
        vertex[1] = new Vector3(0, 1, 0);
        vertex[2] = new Vector3(1, 0, 0);*/

        meshFilter.mesh.vertices = vertex;

        triangles = new[]
        {
            0,1,2,  
            2,1,2,
            2,3,4,
            4,3,5,
            4,5,6,
            6,5,7,
            6,7,0,
            0,7,1,
            1,5,3,
            5,1,7,
            0,2,4,
            4,6,0,
          
       
           

        };

        meshFilter.mesh.triangles = triangles;

    }

}
