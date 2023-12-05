using UnityEngine;

public class Erika_Jump : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Получаем компонент Animator из объекта
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool jumpPressed = Input.GetKey("space");
        // Проверяем, была ли нажата клавиша пробел
        if (jumpPressed)
        {
            // Активируем анимацию прыжка
            animator.SetTrigger("Jump");
            GetComponent<Animation>().Play("idle");
        }else{
            animator.SetBool("Jump", false);
        }
    }

}
