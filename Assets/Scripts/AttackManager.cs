using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public bool equipped = false;
    public GameObject swordMesh;
    private Animator ani;

    private void Awake()
    {
        ani = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            equipped = !equipped;
            //ani.SetLayerWeight(1, equipped ? 1 : 0);
            ani.SetBool("Equipped?", equipped);
        }

        if (equipped && Input.GetMouseButtonDown(0))
        {
            ani.SetTrigger("Attack");
        }
    }
}
