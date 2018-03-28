using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBehaviour : MonoBehaviour {
    public GameObject target;
	public float angleSpeed = 1.0f;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = gameObject.GetComponent<NavMeshAgent>();
	}
	
    

	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.transform.position);
		Vector3 direction = new Vector3 (agent.steeringTarget.x, agent.transform.position.y, agent.steeringTarget.z) - agent.transform.position;
		if (direction != Vector3.zero) agent.transform.rotation = Quaternion.Slerp(agent.transform.rotation, Quaternion.LookRotation(direction), angleSpeed*Time.deltaTime);
	}
}
