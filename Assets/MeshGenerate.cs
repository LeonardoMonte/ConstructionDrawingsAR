using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2[] polygon = new Vector2[] {
          new Vector2(329, 326),
          new Vector2(328, 327),
          new Vector2(327, 327),
          new Vector2(326, 328),
          new Vector2(325, 328),
          new Vector2(324, 329),
          new Vector2(324, 330),
          new Vector2(323, 331),
          new Vector2(323, 332),
          new Vector2(322, 333),
          new Vector2(321, 432),
          new Vector2(320, 433),
          new Vector2(320,467),
          new Vector2(319, 468),
          new Vector2(319, 486),
          new Vector2(320, 487),
          new Vector2(320, 488),
          new Vector2(321, 489),
          new Vector2(329, 489),
          new Vector2(329, 488),
          new Vector2(330, 487),
          new Vector2(330, 479),
          new Vector2(331, 478),
          new Vector2(331, 451),
          new Vector2(332, 450),
          new Vector2(332, 415),
          new Vector2(333, 414),
          new Vector2(333, 379),
          new Vector2(334, 378),
          new Vector2(334, 345),
          new Vector2(335, 344),
          new Vector2(335, 343),
          new Vector2(339, 339),
          new Vector2(340, 339),
          new Vector2(341, 338),
          new Vector2(367, 338),
          new Vector2(368, 339),
          new Vector2(384, 339),
          new Vector2(384, 331),
          new Vector2(383, 330),
          new Vector2(382, 330),
          new Vector2(380, 328),
          new Vector2(379, 328),
          new Vector2(378, 327),
          new Vector2(350, 327),
          new Vector2(349, 326),
        };
        Mesh m = CreateMesh(polygon);
    	GameObject gameObject = new GameObject("test");
        gameObject.AddComponent(typeof(MeshRenderer));
        MeshFilter filter = gameObject.AddComponent(typeof(MeshFilter)) as MeshFilter;
        filter.mesh = m;
        //Instantiate(m, new Vector3(0, 0, 0), Quaternion.identity);
    }

    static void test()
    {

    }

    static Mesh CreateMesh(Vector2 [] poly)
    {
        // convert polygon to triangles
        Triangulator triangulator = new Triangulator(poly);
        int[] tris = triangulator.Triangulate();
        Mesh m = new Mesh();
        Vector3[] vertices = new Vector3[poly.Length*2];
       
        for(int i=0;i<poly.Length;i++)
        {
            vertices[i].x = poly[i].x;
            vertices[i].y = poly[i].y;
            vertices[i].z = -10; // front vertex
            vertices[i+poly.Length].x = poly[i].x;
            vertices[i+poly.Length].y = poly[i].y;
            vertices[i+poly.Length].z = 10;  // back vertex    
        }
        int[] triangles = new int[tris.Length*2+poly.Length*6];
        int count_tris = 0;
        for(int i=0;i<tris.Length;i+=3)
        {
            triangles[i] = tris[i];
            triangles[i+1] = tris[i+1];
            triangles[i+2] = tris[i+2];
        } // front vertices
        count_tris+=tris.Length;
        for(int i=0;i<tris.Length;i+=3)
        {
            triangles[count_tris+i] = tris[i+2]+poly.Length;
            triangles[count_tris+i+1] = tris[i+1]+poly.Length;
            triangles[count_tris+i+2] = tris[i]+poly.Length;
        } // back vertices
        count_tris+=tris.Length;
        for(int i=0;i<poly.Length;i++)
        {
          // triangles around the perimeter of the object
            int n = (i+1)%poly.Length;
            triangles[count_tris] = i;
            triangles[count_tris+1] = i + poly.Length;
            triangles[count_tris+2] = n;
            triangles[count_tris+3] = n;
            triangles[count_tris+4] = n + poly.Length;
            triangles[count_tris+5] = i + poly.Length;
            count_tris += 6;
        }
        m.vertices = vertices;
        m.triangles = triangles;
        m.RecalculateNormals();
        m.RecalculateBounds();
        m.Optimize();
        return m;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
