using UnityEngine;

public class PointTeleport : MonoBehaviour
{
    
    public Transform Teleport;
	private bool teleported;
	
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
			col.gameObject.transform.position = Teleport.transform.position;
		}
	}
	
}
