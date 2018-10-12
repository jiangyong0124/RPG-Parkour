using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float _moveSpeed;

    private GameObject _human;

    private Animator _animator;

    // Use this for initialization
    void Start()
    {
        _human = this.gameObject;

        _animator = this.gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        

        //HumanMove(_human, _moveSpeed);
    }
    void HumanMove(GameObject gameObject, float moveSpeed)
    {
        var horizontal = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;

        var vertical = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        gameObject.transform.Translate(new Vector3(horizontal, 0, vertical));
    }
}
