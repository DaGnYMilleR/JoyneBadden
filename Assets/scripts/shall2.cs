using UnityEngine;
using UnityEngine.AI;

public class shall2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform target1;
    [SerializeField] private Transform target2;
    [SerializeField] private Transform target3;
    [SerializeField] private Transform targetToUp;
    private NavMeshAgent Agent;

    public static Vector3 defaulPosition;
    
    [SerializeField] private int shallNumber = 1;
    [SerializeField] private int countToEnd;
    


    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Agent.updateRotation = false;
        Agent.updateUpAxis = false;

        defaulPosition = transform.position;

    }

    void Update()
    {
        if (!Agent.pathPending && Agent.remainingDistance < 0.1f && countToEnd != 0)
        {
            switch (shallNumber)
            { 
                case 1:
                    Agent.SetDestination(target2.position);
                    shallNumber = 2;
                    countToEnd--;
                    break;
                case 2:
                    Agent.SetDestination(target3.position);
                    shallNumber = 3;
                    countToEnd--;
                    break;
                case 3:
                    Agent.SetDestination(target1.position);
                    shallNumber = 1;
                    countToEnd--;
                    break;
            }
        }
    }
    private void OnMouseDown()
    {
        Agent.SetDestination(targetToUp.position);
    }
    
    public void ResetToDefault()
    {
        transform.position = defaulPosition;
    }
}
