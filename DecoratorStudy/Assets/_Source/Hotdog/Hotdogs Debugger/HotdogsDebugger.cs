using System.Collections.Generic;
using UnityEngine;

namespace HotdogSystem
{
    public class HotdogsDebugger : MonoBehaviour
    {
        [SerializeField] private List<HotdogSO> hotdogSOs = new();

        private void Start()
        {
            // For part 1
            /*
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
            */

            foreach (var hotdogSO in hotdogSOs)
            {
                DebugHotDog(hotdogSO.CreateHotdog());
            }
        }

        // For part 1
        /*
        private void CreateAndDebugHotdogDecorators(AHotdog hotdog)
        {
            PicklesHotdogDecorator hotdogWithPickles = new(hotdog);
            FriedOnionsHotdogDecorator hotdogWithFriedOnions = new(hotdog);

            DebugHotDog(hotdog);
            DebugHotDog(hotdogWithPickles);
            DebugHotDog(hotdogWithFriedOnions);
        }
        */

        private void DebugHotDog(AHotdog hotdog)
        {
            Debug.Log(hotdog.GetName() + " (" + hotdog.GetWeight().ToString() + "g)" + " - " + hotdog.GetCost().ToString() + "r.");
        }
    }
}
