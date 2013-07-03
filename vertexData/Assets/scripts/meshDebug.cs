using UnityEngine;
using System.Collections;

public class meshDebug : MonoBehaviour {
	
	
	MeshFilter meshfilter;
	public Vector3[] idleVertices;
	public Vector3[] wavingVertices;
	
	float[] randomSeeds;
	
	// Use this for initialization
	void Start () {
	meshfilter = GetComponent<MeshFilter>();
	idleVertices = meshfilter.mesh.vertices;
	wavingVertices = meshfilter.mesh.vertices;
	
	randomSeeds = new float [idleVertices.Length];	
		
		for (int i = 0; i < randomSeeds.Length;i++)
		{
		randomSeeds[i] = Random.Range(0f,5f);	
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		
		for ( int i = 0; i < idleVertices.Length; i++){
	      idleVertices[i] = wavingVertices[i] + Vector3.up *  Mathf.Sin(Time.time * randomSeeds[i] ) * 0.3f;
		}
		
		meshfilter.mesh.vertices = idleVertices;
		meshfilter.mesh.RecalculateNormals();
		
//		for(int i = 0; i <meshfilter.mesh.vertices.Length; i++)
//		{
//		Debug.DrawRay(meshfilter.mesh.vertices[i],meshfilter.mesh.normals[i]);	
//		}
	}
}
