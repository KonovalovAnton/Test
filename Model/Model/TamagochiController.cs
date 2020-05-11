using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class TamagochiController
    {
        private readonly Tamagochi pet;

        public TamagochiController(Tamagochi tamagochi)
        {
            pet = tamagochi;
        }

        public void UpdateDelta()
        {
            var delta = PetStatusChanges.Delta[pet.GetStatus()];

            foreach (var item in delta)
            {
                if (pet.GetParameter(item.Key) + item.Value < 0)
                {
                    pet.SetParameter(item.Key, 0);
                }
                else if (pet.GetParameter(item.Key) + item.Value > 100)
                {
                    pet.SetParameter(item.Key, 100);
                }
                else
                {
                    pet.SetParameter(item.Key, pet.GetParameter(item.Key) + item.Value);
                }
            }
        }
    }
}
