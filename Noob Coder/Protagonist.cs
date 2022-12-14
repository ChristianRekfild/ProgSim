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
        int Money { get; set; }
        decimal Credit { get; set; }
        float Energy { get; set; }
        float Appearance { get; set; }

        public bool ToGetAJob()
        {
            return false;
        }
        public bool ByAnApartment()
        {
            return false;
        }
        public bool EnrollInTraining()
        {
            return false;
        }



        public bool BuyFood()
        {
            return false;
        }
        public bool GoToSleep()
        {
            return false;
        }
        public bool GoWashUp()
        {
            return false ;
        }
        public bool GoTraining()
        {
            return false;
        }
        public bool GoHaveFun()
        { return false; }
        public bool UpgradePC()
        { return false ;}
        public bool ByThings()
        { return false; }
        public bool FindASideJob()
        { return false; }
        public bool LearnABook()
        { return false; }
        public bool GoToCourses()
        { return false; }
        public bool PlayOnPC()
        { return false;; }

        public bool TakeALoan(int amount)
        {
            return false; ;
        }
        public bool ReturnALoan(int amount)
        {
            return false; ;
        }
        public bool PutMoneyInTheBank(int amount)
        { return false; }
        public bool WithdrowMoneyFromTheBank(int amount)
        { return false; }

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
