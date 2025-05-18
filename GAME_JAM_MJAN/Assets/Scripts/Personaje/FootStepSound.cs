using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] footstepSounds;
    public float footstepInterval = 0.5f;
    public LayerMask groundLayers;

    private AudioSource audioSource;
    private float lastFootstepTime;
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if player is moving and grounded
        if (isGrounded && rb.velocity.magnitude > 0.1f && Time.time > lastFootstepTime + footstepInterval)
        {
            PlayFootstep();
            lastFootstepTime = Time.time;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if collision is with ground layer
        if (((1 << collision.gameObject.layer) & groundLayers) != 0)
        {
            isGrounded = true;

            // Play landing sound if falling fast enough
            if (rb.velocity.y < -3f)
            {
                PlayFootstep(0.8f); // Play at lower pitch for landing
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (((1 << collision.gameObject.layer) & groundLayers) != 0)
        {
            isGrounded = false;
        }
    }

    void PlayFootstep(float pitchVariation = 1f)
    {
        if (footstepSounds.Length == 0) return;

        AudioClip clip = footstepSounds[Random.Range(0, footstepSounds.Length)];
        audioSource.pitch = Random.Range(0.9f * pitchVariation, 1.1f * pitchVariation);
        audioSource.PlayOneShot(clip);
    }
}
