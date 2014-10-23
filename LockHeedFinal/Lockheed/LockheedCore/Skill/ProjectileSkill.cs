using System;
using SFML.Graphics;
namespace LockHeedCore
{
    
    public class ProjectileSkill : Skill
    {

        public int ProjectileSpeed { get; private set; }
        public string Directory { get; set; }
        public ProjectileSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost,string directory)
            :base(name,reqStr,reqAgi,reqInt,tier,manaCost)
        {
            this.Directory = directory;
        }

        public override void Cast(Character character,float mouseX,float mouseY)
        {
            if (character.Stats.Mana >= this.ManaCost) 
            {
                character.DecreaseMana(this.ManaCost);

                var rad = Math.Atan2(mouseY - (character.BoundingBox.Top), mouseX - (character.BoundingBox.Left));
                var deltaX = (float)Math.Cos(rad);
                var deltaY = (float)Math.Sin(rad);
                Sprite projSprite = new Sprite(new Texture(this.Directory));
                projSprite.Rotation = (float)rad;
                Projectile Projectile = new Projectile(new SpriteSheet(projSprite), character.BoundingBox.Left, character.BoundingBox.Top-10, deltaX, deltaY, Program.MovementModifier);
            }     
        }

    }
}
