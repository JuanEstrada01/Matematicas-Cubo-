using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dado : MonoBehaviour
{


    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    Vector3[] vertices;
    int[] triangles;
    

    private float size = 1.62f;
    public float prueba = 1;

    public Material material;

    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = material;

        mesh = new Mesh();



        //float size = 1f;

        vertices = new Vector3[]{
            new Vector3(0, -size, 1f), //A 
            new Vector3(0, size, 1f), //B
            new Vector3(0, size, -1f), //C
            new Vector3(0, -size, -1f), //D

            new Vector3(1f, 0f, size), //E
            new Vector3(-1, 0f, size),  //F
            new Vector3(-1, 0f, size),   //G
            new Vector3(1, 0f, -size),    //H

            new Vector3(size, 1f, 0f),   //I
            new Vector3(-size, 1f, 0f),   //J
            new Vector3(-size, -1f, 0f),   //K
            new Vector3(size, -1f, 0f),  //L

            new Vector3(0f, -size, 1f), //V
            new Vector3(0f, size, 1f),  //T
            new Vector3(0f, size, -1f), //Z
            new Vector3(0f, -size, -1f), //X

            new Vector3(1f, 0, size), //U
            new Vector3(-1f, 0, size), //H
            new Vector3(-1f, 0, -size), //K
            new Vector3(1f, 0, -size), //L

            new Vector3(size, 1f, 0f), //M
            new Vector3(-size, 1f, 0f),//N
        };

        mesh.vertices = vertices;

        triangles = new[]
        {
            4, 1, 5,//0
            4, 5, 0,//1
			0, 5, 10,//2
            5, 9, 10, //3
			1, 9, 5,//4

            1, 4, 8, //5
			4, 11, 8,//6
            0, 11, 4, //7
			0, 3, 11,//8
            10, 3, 0,//9

			10, 6, 3,//10
            9, 6, 10,//11
			9, 2, 6,//12
            1, 2, 9,//13
            1, 8, 2,//14

            8, 7, 2,//15
            11, 7, 8,//16
            11, 3, 7,//17
            7, 6, 2,//18
            3, 6, 7,//19
        };

        mesh.triangles = triangles;


        GetComponent<MeshFilter>().mesh = mesh;
        mesh.Optimize();
        mesh.RecalculateNormals();

    }
}

