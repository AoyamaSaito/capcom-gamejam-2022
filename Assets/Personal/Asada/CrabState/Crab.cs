using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Crab : MonoBehaviour, IStreamable, ICommandStateController<Crab>
{
    //[SerializeField] private SpriteRenderer _spriteRenderer = null;

    private UnityAction registeredSelf = null;
    public bool IsDone { get { return false; } }//‚Æ‚è‚ ‚¦‚¸false‚Å•Ô‚µ‚Ä‚Ü‚·B
    private List<IItemCommandState<Crab>> _stateList = new List<IItemCommandState<Crab>>();//—\–ñ‚³‚ê‚Ä‚¢‚éˆ—
    private IItemCommandState<Crab> _currentState = null;
    private float _dieTime = 2.0f;

    void Awake()
    {
        _stateList.Add(new CrabDefaultState());
        _stateList.Add(new CrabDamageState());
        NextState();
    }

    public void FirstProcess()
    {
        _currentState.FirstOperation(this);
    }

    public void SecondProcess()
    {
        _currentState.SecondOperation(this);
    }

    public void ThirdProcess()
    {
        _currentState.ThirdOperation(this);
    }

    public void Remove()
    {
        _currentState.RemoveOperation(this);
    }

    public void NextState()
    {
        if (_stateList.Count > 0)
        {
            if (_currentState != null)
            {
                _currentState?.OnExit(this);
                _stateList[0].OnEnter(this, _currentState);
            }
            else
            {
                _stateList[0].OnEnter(this, null);
            }
            _currentState = _stateList[0];
            _stateList.RemoveAt(0);
        }
        else
        {
            //Debug.Log("‚È‚É‚à‚È‚µ");
        }
    }

    public void OnClick()
    {
        registeredSelf = ItemClickController.instance.Register(this);
    }

    public void DestroyObject()
    {
        Destroy(this.gameObject);
        registeredSelf.Invoke();
    }

    public void StartDie()
    {
        StartCoroutine(DieProcess());
    }

    private IEnumerator DieProcess()
    {
        StartCoroutine(Vibration(-1));
        yield return new WaitForSeconds(_dieTime);
        DestroyObject();
    }

    private IEnumerator Vibration(float vec)
    {
        this.transform.rotation = Quaternion.Euler(new Vector3(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z + 50*vec));
        yield return new WaitWhile(()=> Mathf.Abs(this.transform.rotation.z) > 180);
        StartCoroutine(Vibration(vec * -1));
    }

}
