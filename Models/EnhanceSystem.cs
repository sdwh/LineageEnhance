using static LineageEnhance.Pages.Index;

namespace LineageEnhance.Models
{
    public class EnhanceSystem
    {
        private readonly AppRuntime _appRuntime;

        public EnhanceSystem(AppRuntime appRuntime)
        {
            _appRuntime = appRuntime;
        }

        public async Task Enhance(Equipment equipment, bool blessed = false)
        {
            var random = new Random();

            if (blessed)
            {
                if (equipment.Enhanced >= equipment.Safe)
                {
                    if (random.Next(0, equipment.Safe) == 0)
                    {
                        equipment.Enhanced += 1;
                    }
                    else
                    {
                        equipment.Enhanced = 0;
                    }
                }
                else if (equipment.Enhanced <= 2)
                {
                    equipment.Enhanced += random.Next(1, 4);
                }
                else if (equipment.Enhanced <= 5 && equipment.Safe == 6)
                {
                    equipment.Enhanced += random.Next(1, 3);
                }
                else if (equipment.Enhanced == 3 && equipment.Safe == 4)
                {
                    equipment.Enhanced += random.Next(1, 3);
                }
                else if (equipment.Enhanced == 4 && equipment.Safe == 4)
                {
                    int rand = random.Next(0, 8);
                    if (rand == 1 || rand == 2)
                    {
                        equipment.Enhanced += rand;
                    }
                    else
                    {
                        equipment.Enhanced = 0;
                    }
                }
                else
                {
                    if (random.Next(0, equipment.Safe) == 0)
                    {
                        equipment.Enhanced += 1;
                    }
                    else
                    {
                        equipment.Enhanced = 0;
                    }
                }
            }
            else
            {
                if (equipment.Enhanced >= equipment.Safe)
                {
                    if (random.Next(0, equipment.Safe) == 0)
                    {
                        equipment.Enhanced += 1;
                    }
                    else
                    {
                        equipment.Enhanced = 0;
                    }
                }
                else
                {
                    equipment.Enhanced += 1;
                }
            }
            await Task.Delay(25);
            _appRuntime.CoolDownState = false;
        }
    }
}
