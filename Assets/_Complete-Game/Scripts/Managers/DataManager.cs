using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : SingletonMonoBehaviour<DataManager>
{
    public GameObject bullet;
    public ParticleSystem hitParticles;                // Reference to the particle system that plays when the enemy is damaged.
    protected override void UnityAwake() { }

}
