using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Platform
{
    public class UIManager : MonoBehaviour
    {

        [SerializeField] public Text coinText;
        [SerializeField] public Text KeyText;
        [SerializeField] public int count;

        public void CoinUI( int count)
        {
            coinText.text = count.ToString(); 
        }

        public void KeyUI(int count)
        {
            KeyText.text = count.ToString();
        }
    }
}
