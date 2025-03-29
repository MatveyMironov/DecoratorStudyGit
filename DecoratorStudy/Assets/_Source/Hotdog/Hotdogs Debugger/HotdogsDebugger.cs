using System.Collections.Generic;
using UnityEngine;

namespace HotdogSystem
{
    public class HotdogsDebugger : MonoBehaviour
    {
        private void Start()
        {
            List<AHotdog> hotdogs = new()
            {
                new ClassicHotdog(),
                new CaesarHotdog(),
                new MeatHotdog()
            };

            foreach (var hotdog in hotdogs)
            {
                CreateAndDebugHotdogDecorators(hotdog);
                Debug.Log("");
            }
        }

        private void CreateAndDebugHotdogDecorators(AHotdog hotdog)
        {
            PicklesHotdogDecorator hotdogWithPickles = new(hotdog);
            FriedOnionsHotdogDecorator hotdogWithFriedOnions = new(hotdog);

            DebugHotDog(hotdog);
            DebugHotDog(hotdogWithPickles);
            DebugHotDog(hotdogWithFriedOnions);
        }

        private void DebugHotDog(AHotdog hotdog)
        {
            Debug.Log(hotdog.GetName() + " (" + hotdog.GetWeight().ToString() + "g)" + " - " + hotdog.GetCost().ToString() + "r.");
        }
    }
}
