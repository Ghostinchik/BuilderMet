using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder1
{
    internal class Builder
    {
        public class Bread
        {
            public string FlourType { get; set; }
            public List<string> Ingredients { get; set; }
            public int BakingTime { get; set; }
            public string Shape { get; set; }
            public int Size { get; set; }
        }

        public abstract class BreadBuilder
        {
            protected Bread bread;

            public Bread GetBread()
            {
                return bread;
            }

            public abstract BreadBuilder SetFlourType(string flourType);
            public abstract BreadBuilder AddIngredient(string ingredient);
            public abstract BreadBuilder SetBakingTime(int bakingTime);
            public abstract BreadBuilder SetShape(string shape);
            public abstract BreadBuilder SetSize(int size);
        }

        public class SourdoughBreadBuilder : BreadBuilder
        {
            public SourdoughBreadBuilder()
            {
                bread = new Bread();
            }

            public override BreadBuilder SetFlourType(string flourType)
            {
                bread.FlourType = flourType;
                return this;
            }
            public override BreadBuilder AddIngredient(string ingredient)
            {
                if (bread.Ingredients == null)
                {
                    bread.Ingredients = new List<string>();
                }
                bread.Ingredients.Add(ingredient);
                return this;
            }
            public override BreadBuilder SetBakingTime(int bakingTime)
            {
                bread.BakingTime = bakingTime;
                return this;
            }
            public override BreadBuilder SetShape(string shape)
            {
                bread.Shape = shape;
                return this;
            }
            public override BreadBuilder SetSize(int size)
            {
                bread.Size = size;
                return this;
            }
        }


        public class WhiteBreadBuilder : BreadBuilder
        {
            public WhiteBreadBuilder()
            {
                bread = new Bread();
            }

            public override BreadBuilder SetFlourType(string flourType)
            {
                bread.FlourType = flourType;
                return this;
            }
            public override BreadBuilder AddIngredient(string ingredient)
            {
                if (bread.Ingredients == null)
                {
                    bread.Ingredients = new List<string>();
                }
                bread.Ingredients.Add(ingredient);
                return this;
            }
            public override BreadBuilder SetBakingTime(int bakingTime)
            {
                bread.BakingTime = bakingTime;
                return this;
            }
            public override BreadBuilder SetShape(string shape)
            {
                bread.Shape = shape;
                return this;
            }
            public override BreadBuilder SetSize(int size)
            {
                bread.Size = size;
                return this;
            }
        }



        public class WheatBreadBuilder : BreadBuilder
        {
            public WheatBreadBuilder()
            {
                bread = new Bread();
            }

            public override BreadBuilder SetFlourType(string flourType)
            {
                bread.FlourType = flourType;
                return this;
            }
            public override BreadBuilder AddIngredient(string ingredient)
            {
                if (bread.Ingredients == null)
                {
                    bread.Ingredients = new List<string>();
                }
                bread.Ingredients.Add(ingredient);
                return this;
            }
            public override BreadBuilder SetBakingTime(int bakingTime)
            {
                bread.BakingTime = bakingTime;
                return this;
            }
            public override BreadBuilder SetShape(string shape)
            {
                bread.Shape = shape;
                return this;
            }
            public override BreadBuilder SetSize(int size)
            {
                bread.Size = size;
                return this;
            }
        }


        public class BreadDirector
        {
            public Bread MakeBread(BreadBuilder builder)
            {
                return builder.SetFlourType("Пшеничний")
                              .AddIngredient("Сілью")
                              .AddIngredient("Водою")
                              .AddIngredient("Пшеницею")
                              .SetBakingTime(60)
                              .SetShape("Буханець")
                              .SetSize(500)
                              .GetBread();
            }
        }

        /*public class BreadDirector1
        {
            public Bread MakeBread(BreadBuilder1 builder)
            {
                return builder.SetFlourType("Пшеничний")
                              .AddIngredient("Сілью")
                              .AddIngredient("Водою")
                              .AddIngredient("Пшеницею")
                              .SetBakingTime(60)
                              .SetShape("Буханець")
                              .SetSize(500)
                              .GetBread();
            }
        }
        public class BreadDirector2
        {
            public Bread MakeBread(BreadBuilder2 builder)
            {
                return builder.SetFlourType("Пшеничний")
                              .AddIngredient("Сілью")
                              .AddIngredient("Водою")
                              .AddIngredient("Пшеницею")
                              .SetBakingTime(60)
                              .SetShape("Буханець")
                              .SetSize(500)
                              .GetBread();
            }
        }*/
    }
}
