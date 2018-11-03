using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ShowObjectDebug : MonoBehaviour
{
    private Text _text;
    private float _time;
    private float _nextTime;

    public PlayerVitals target;

    void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        if (_time == 0 || _time > _nextTime)
        {
            var fields = target.GetType().GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            string msg = "";

            foreach (var field in fields)
            {
                int flt = (int)field.GetValue(target);
                msg += string.Format("{0} : {1}\r\n", field.Name, flt);
            }

            _text.text = msg;
            _nextTime = 5000;
            _time = 0;
        }
        else
        {
            _time += Time.deltaTime;
        }
    }
}