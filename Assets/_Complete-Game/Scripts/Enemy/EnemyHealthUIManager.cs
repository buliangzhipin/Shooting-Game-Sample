using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject
{
    public class EnemyHealthUIManager : MonoBehaviour
    {
        private static EnemyHealthUIManager ins;
        public static EnemyHealthUIManager Ins => ins;
        public GameObject enemyHealthUI;
        public Slider currentUI;
        public Slider showUI;
        public float showTime;
        private EnemyHealth currentHealth;
        private float current;
        private float show;
        private float timer;

        void Awake()
        {
            ins = this;
        }

        public void Show(EnemyHealth health, float previous)
        {
            enemyHealthUI.SetActive(true);
            timer = 0f;
            show = previous;
            current = health.currentHealth;
            showUI.value = previous;
            currentUI.value = current;
        }
        void Update()
        {
            timer += Time.deltaTime;
            if (timer > showTime)
            {
                enemyHealthUI.SetActive(false);
            }
            else
            {
                show = Mathf.Lerp(current, show, 0.96f);
                showUI.value = show;
            }
        }
    }
}

