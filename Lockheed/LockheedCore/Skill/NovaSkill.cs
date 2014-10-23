namespace LockHeedCore
{
    using System;
    using LockHeedCore.Exceptions;

    public class NovaSkill : Skill
    {
        private int speed;
        public NovaSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost, int speed)
            : base(name, reqStr, reqAgi, reqInt, tier, manaCost)
        {
            this.Speed = speed;
        }
        public override void Cast(Character character, float mouseX, float mouseY)
        {
            if (character.Stats.Mana >= this.ManaCost)
            {
                character.Stats.DecreaseMana(this.ManaCost);
                Nova Nova = new Nova("directoryAnimation", character.SpriteSheet.CurrentSprite.Position.X, character.SpriteSheet.CurrentSprite.Position.Y, this.Speed);
            }
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            private set
            {
                ExceptionsHolder.CheckNumberOutOfRangeMinValue(float.Parse(value.ToString()), 1, "Speed cannot be 0 or negative!");
                this.speed = value;
            }
        }
    }
}
