using UnityEngine;

public class StartParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSystem = null;

    private void OnTriggerEnter(Collider other)
    {
        particleSystem.Play();
    }
}

/*public interface IInterface()
{
    void Start();
}*/