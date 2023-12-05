using UnityEngine;

public class ScriptOfJump : MonoBehaviour
{
    public float jumpForce = 10f;  // Сила прыжка
    private bool isGrounded;        // Флаг, указывающий, находится ли игрок на земле
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Проверяем, находится ли игрок на земле
        isGrounded = Physics2D.OverlapCircle(transform.position, 0.2f, LayerMask.GetMask("Ground"));

        // Проверяем, была ли нажата клавиша пробел, и игрок на земле
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Придаем игроку вертикальную силу для прыжка
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
