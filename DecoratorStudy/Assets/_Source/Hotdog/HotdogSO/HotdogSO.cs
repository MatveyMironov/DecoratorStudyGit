using System.Collections.Generic;
using UnityEngine;

namespace HotdogSystem
{
    [CreateAssetMenu(fileName = "NewHotdogSO", menuName = "HotdogSO")]
    public class HotdogSO : ScriptableObject
    {
        [SerializeField] private HotdogTypes hotdogType;
        [SerializeField] private List<AdditiveTypes> additives = new();

        public AHotdog CreateHotdog()
        {
            return ApplyAdditives(CreateBaseHotdog());
        }

        private AHotdog CreateBaseHotdog()
        {
            AHotdog hotdog = null;

            switch (hotdogType)
            {
                case HotdogTypes.Classic:
                hotdog = new ClassicHotdog();
                break;

                case HotdogTypes.Caesar:
                hotdog = new CaesarHotdog();
                break;

                case HotdogTypes.Meat:
                hotdog = new MeatHotdog();
                break;
            }

            return hotdog;
        }

        private AHotdog ApplyAdditives(AHotdog hotdog)
        {
            foreach (var additive in additives)
            {
                switch (additive)
                {
                    case AdditiveTypes.Pickles:
                    hotdog = new PicklesHotdogDecorator(hotdog);
                    break;

                    case AdditiveTypes.FriedOnions:
                    hotdog = new FriedOnionsHotdogDecorator(hotdog);
                    break;
                }
            }

            return hotdog;
        }

        private enum HotdogTypes
        {
            Classic,
            Caesar,
            Meat,
        }

        private enum AdditiveTypes
        {
            Pickles,
            FriedOnions,
        }
    }
}