using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noob_Coder
{
    internal class Protagonist
    {
        float Health { get; set; }
        BodyCondition Condition { get; set; }
        HardSkills HardSkill { get; set; }
        SoftSkills SoftSkill { get; set; }
        decimal Money { get; set; }
        decimal Credit { get; set; }
        float Energy { get; set; }
        float Appearance { get; set; }

    }
}

enum BodyCondition
{
    None,
    Cold,
    Poising,
    Hunger,
    Fatigue,
    Fracture
}

enum HardSkills
{

}
enum SoftSkills
{

}
