using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrazilAnimal
{
    public abstract class Animal
    {
        protected String CName;
        protected String CSound;
        protected String CFood;


        public virtual String GetSound()
        {
            return "";
        }
        public virtual String GetName()
        {
            return "";
        }
        public virtual String GetFood()
        {
            return "";
        }
        // C'tor is not needed because this class is abstract
    }
    public class Pet : Animal
    {
        public Pet()
        {
        }
        public override String GetSound()
        {
            return "Pet Sound";
        }
        public override String GetName()
        {
            return "PET";
        }
        public override String GetFood()
        {
            return "Pet's food";
        }
    }
    public class Dogs : Pet
    {
        public Dogs()
        {

        }
        public override String GetName()
        {
            return "Dog";
        }
        public override String GetSound()
        {
            return "Bark";
        }
        public override String GetFood()
        {
            return "Bone";
        }
    }
    public class Cats : Pet
    {
        public Cats()
        {

        }


        public override String GetName()
        {
            return "Cat";
        }
        public override String GetSound()
        {
            return "Meow";
        }
        public override String GetFood()
        {
            return "Fish";
        }
    }
    public class Horses : Pet
    {
        public Horses()
        {

        }


        public override String GetName()
        {
            return "Horse";
        }
        public override String GetSound()
        {
            return "Neih";
        }
        public override String GetFood()
        {
            return "Hay";
        }
    }
    public class Yorkies : Dogs
    {
        public Yorkies()
        {

        }


        public override String GetName()
        {
            return "Yorkie Dog";
        }
        public override String GetSound()
        {
            return "Woff";
        }
        public override String GetFood()
        {
            return "Ground beef";
        }
    }
    public class StBernard : Dogs
    {
        public StBernard()
        {

        }


        public override String GetName()
        {
            return "StBernard Dog";
        }
        public override String GetSound()
        {
            return "Big Whooooooof";
        }
        public override String GetFood()
        {
            return "Lots of food";
        }
    }
}