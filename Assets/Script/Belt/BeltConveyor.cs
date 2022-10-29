using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltConveyor : MonoBehaviour
{
    [SerializeField]
    private ConveyorMove _conveyor;
    [SerializeReference]
    private GameObject[] streams;


    [Tooltip("ƒRƒ“ƒxƒA‚ÌList")]
    private List<GameObject> _conveyors = new List<GameObject>();

    private void Start()
    {
        ConveyorGenerator();
    }

    private void ConveyorGenerator()
    {
        var go = Instantiate(_conveyor.gameObject, transform.position, Quaternion.identity);
        ConveyorMove conveyorMove = go.GetComponent<ConveyorMove>();
        conveyorMove.OnEvent += ConveyorGenerator;
        if (streams != null)
        {
            StreamGenerator(conveyorMove.transform, conveyorMove.Positions[Random.Range(0, conveyorMove.Positions.Length)].localPosition);
        }
        _conveyors.Add(go);
    }

    private void StreamGenerator(Transform parent, Vector3 position)
    {
        int random = Random.Range(0, streams.Length);

        if(streams[random] != null)
        {
            var go = Instantiate(streams[random], position, Quaternion.identity);
            go.transform.SetParent(parent, false);
        }
    }
}
