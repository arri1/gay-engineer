using UnityEngine;
using System.Collections;

public class GenerateTerrain : MonoBehaviour {

	[Range(0.1f,20.0f)]
	public float heightScale = 5;
	[Range(0.1f,40.0f)]
	public float detailScale = 5.0f;
	private Mesh mesh;
	private Vector3[] vertices;

	void Start(){
		MyMethod();
	}
	void Update(){
		
			MyMethod();

	}

	public float wavesSpeed = 2;
	private int counter = 0, zLevel = 0;
	void MyMethod(){
		
		mesh = this.GetComponent<MeshFilter>().mesh;
		vertices = mesh.vertices;

		counter = 0;
		zLevel = 0;
		for(int i = 0; i < 11; i++){
			for(int j = 0; j < 11; j++){
				CalculationMethod(counter, zLevel);
				counter += 1;
			}
			zLevel += 1;
		}

	

		mesh.vertices = vertices;
		mesh.RecalculateBounds();
		mesh.RecalculateNormals();

		Destroy(gameObject.GetComponent<MeshCollider>());
		MeshCollider collider = gameObject.AddComponent<MeshCollider>();
		collider.sharedMesh = null;
		collider.sharedMesh = mesh;
	}

	public bool waves = true;
	void CalculationMethod(int i,int minusZ){
		
		if(waves){
			vertices[i].z = Mathf.PerlinNoise(Time.time/wavesSpeed + (vertices[i].x + this.transform.position.x)/detailScale,
				Time.time/wavesSpeed + (vertices[i].y + this.transform.position.y)/detailScale) * heightScale;		
			vertices[i].z -= minusZ;
		}
		else if(!waves){
			vertices[i].z = Mathf.PerlinNoise((vertices[i].x + this.transform.position.x)/detailScale,
				(vertices[i].y + this.transform.position.y)/detailScale) * heightScale;		
			vertices[i].z -= minusZ;
		}

	}

}
