using PriceMyLEATHERAO.Domain.Model;


namespace PriceMyHideAO.Domain.Model
{
    public class Recipe
    {
        public LeatherTiers LeatherTier { get; set; }
        public string ProductName { get; set; }
        public int RawQuantity { get; set; }
        public string RefinedMatId { get; set; }
        public string RawMatId { get; set; }

        public Recipe(LeatherTiers leatherTier)
        {
            RecipeBuilder(leatherTier);
        }

        private void RecipeBuilder(LeatherTiers leatherTier)
        {

            switch (leatherTier)
            {
                case LeatherTiers.T6_LEATHER_LEVEL1_1:
                    ProductName = "T6_LEATHER_LEVEL1@1";
                    RawQuantity = 4;
                    RefinedMatId = "T5_LEATHER_LEVEL1@1";
                    RawMatId = "T6_HIDE_LEVEL1@1";
                    break;

                case LeatherTiers.T6_LEATHER_LEVEL2_2:
                    ProductName = "T6_LEATHER_LEVEL2@2";
                    RawQuantity = 4;
                    RefinedMatId = "T5_LEATHER_LEVEL2@2";
                    RawMatId = "T6_HIDE_LEVEL2@2";
                    break;

                case LeatherTiers.T6_LEATHER_LEVEL3_3:
                    ProductName = "T6_LEATHER_LEVEL3@3";
                    RawQuantity = 4;
                    RefinedMatId = "T5_LEATHER_LEVEL3@3";
                    RawMatId = "T6_HIDE_LEVEL3@3";
                    break;

                case LeatherTiers.T6_LEATHER_LEVEL4_4:
                    ProductName = "T6_LEATHER_LEVEL4@4";
                    RawQuantity = 4;
                    RefinedMatId = "T5_LEATHER_LEVEL4@4";
                    RawMatId = "T6_HIDE_LEVEL4@4";
                    break;

                case LeatherTiers.T7_LEATHER_LEVEL1_1:
                    ProductName = "T7_LEATHER_LEVEL1@1";
                    RawQuantity = 5;
                    RefinedMatId = "T6_LEATHER_LEVEL1@1";
                    RawMatId = "T7_HIDE_LEVEL1@1";
                    break;

                case LeatherTiers.T7_LEATHER_LEVEL2_2:
                    ProductName = "T7_LEATHER_LEVEL2@2";
                    RawQuantity = 5;
                    RefinedMatId = "T6_LEATHER_LEVEL2@2";
                    RawMatId = "T7_HIDE_LEVEL2@2";
                    break;

                case LeatherTiers.T7_LEATHER_LEVEL3_3:
                    ProductName = "T7_LEATHER_LEVEL3@3";
                    RawQuantity = 5;
                    RefinedMatId = "T6_LEATHER_LEVEL3@3";
                    RawMatId = "T7_HIDE_LEVEL3@3";
                    break;

                case LeatherTiers.T7_LEATHER_LEVEL4_4:
                    ProductName = "T7_LEATHER_LEVEL4@4";
                    RawQuantity = 5;
                    RefinedMatId = "T6_LEATHER_LEVEL4@4";
                    RawMatId = "T7_HIDE_LEVEL4@4";
                    break;

                case LeatherTiers.T8_LEATHER_LEVEL1_1:
                    RawQuantity = 5;
                    RefinedMatId = "T8_LEATHER_LEVEL1@1";
                    RawMatId = "T8_HIDE_LEVEL1@1";
                    break;

                case LeatherTiers.T8_LEATHER_LEVEL2_2:
                    ProductName = "T8_LEATHER_LEVEL2@2";
                    RawQuantity = 5;
                    RefinedMatId = "T7_LEATHER_LEVEL2@2";
                    RawMatId = "T8_HIDE_LEVEL2@2";
                    break;

                case LeatherTiers.T8_LEATHER_LEVEL3_3:
                    ProductName = "T8_LEATHER_LEVEL3@3";
                    RawQuantity = 5;
                    RefinedMatId = "T7_LEATHER_LEVEL3@3";
                    RawMatId = "T8_HIDE_LEVEL3@3";
                    break;

                case LeatherTiers.T8_LEATHER_LEVEL4_4:
                    ProductName = "T8_LEATHER_LEVEL4@4";
                    RawQuantity = 5;
                    RefinedMatId = "T7_LEATHER_LEVEL4@4";
                    RawMatId = "T8_HIDE_LEVEL4@4";
                    break;

                default:
                    break;
            }
        }
    }

}
