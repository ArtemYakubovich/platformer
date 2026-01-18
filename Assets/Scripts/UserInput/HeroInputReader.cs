using UnityEngine;
using UnityEngine.InputSystem;

namespace PixelCrew
{
    public class HeroInputReader : MonoBehaviour
    {
        [SerializeField] private Hero _hero;

        public void OnSaySomething(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                _hero.SaySomething();
            }
        }

        public void On2Vector(InputAction.CallbackContext context)
        {
            var direction = context.ReadValue<Vector2>();
            _hero.SetDirection(direction);
        }
    }
}
