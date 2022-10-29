using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Aji : MonoBehaviour,IStreamable, ICommandStateController<Aji>
{
    public ItemClickController con;
    private UnityAction registeredSelf = null;
    public enum State
    {
        Default,
        First,
        Second,
        Third
    }


    public bool IsDone { get { return _currentState.Equals(_thirdState); } }

    [SerializeField,Header("デフォルト画像")] private Sprite _defaultSprite = null;
    [SerializeField,Header("頭落とした画像")] private Sprite _firstSprite = null;
    [SerializeField, Header("鱗落とした画像")] private Sprite _secondSprite = null;
    [SerializeField,Header("身を開いた画像")] private Sprite _thirdSprite = null;


    private SpriteRenderer _spriteRenderer = null;

    private List<IItemCommandState<Aji>> _stateList = new List<IItemCommandState<Aji>>();//予約されている処理
    private IItemCommandState<Aji> _currentState = null;

    private IItemCommandState<Aji> _defaultState = new AjiDefaultState();
    private IItemCommandState<Aji> _firstState = new AjiFirstState();
    private IItemCommandState<Aji> _secondState = new AjiSecondState();
    private IItemCommandState<Aji> _thirdState = new AjiThirdState();

    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _stateList.Add(_defaultState);
        _stateList.Add(_firstState);
        _stateList.Add(_secondState);
        _stateList.Add(_thirdState);
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
            //Debug.Log("なにもなし");
        }
    }

    public void ChangeSprite(State state)
    {
        if (state.Equals(State.Default))
        {
            _spriteRenderer.sprite = _defaultSprite;
        }
        else if (state.Equals(State.First))
        {
            _spriteRenderer.sprite = _firstSprite;
        }else if (state.Equals(State.Second))
        {
            _spriteRenderer.sprite = _secondSprite;
        }else if (state.Equals(State.Third))
        {
            _spriteRenderer.sprite = _thirdSprite;
        }
    }

    public void OnClick()
    {
        registeredSelf = con.Register(this);
    }

    public void DestroyObject()
    {
        Destroy(this.gameObject);
        registeredSelf.Invoke();
    }
}
